using BioNetModel;
using BioNetModel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace DataSync.BioNetSync
{
   public class DanhMucDonViCoSoSync
    {
        private static BioNetDBContextDataContext db = null;
        private static string linkPostDanhMucDonViCoSo = "/api/donvicoso/AddUpFromApp";
        private static string linkGetDanhMucDonVi = "/api/donvicoso/getall?keyword=&page=0&pagesize=20";
        public static PsReponse PostDanhMucDonViCoSo()
        {
            PsReponse res = new PsReponse();
            try
            {
                ProcessDataSync cn = new ProcessDataSync();
                db = cn.db;
                var account = db.PSAccount_Syncs.FirstOrDefault();
                if (account != null)
                {
                    string token = cn.GetToken(account.userName, account.passWord);
                    if (!string.IsNullOrEmpty(token))
                    {
                        var datas = db.PSDanhMucDonViCoSos.Where(p => p.isDongBo == false);
                        foreach (var data in datas)
                        {
                            string jsonstr = new JavaScriptSerializer().Serialize(data);
                            var result = cn.PostRespone(cn.CreateLink(linkPostDanhMucDonViCoSo), token, jsonstr);
                            if (result.Result)
                            {
                                res.StringError += "Dữ liệu đơn vị " + data.TenDVCS + " đã được đồng bộ lên tổng cục \r\n";
                                var resupdate = UpdateStatusSyncDanhMucDonVi(data);
                                if (!resupdate.Result)
                                {
                                    res.StringError += "Dữ liệu đơn vị " + data.TenDVCS + " chưa được cập nhật \r\n";
                                }
                            }
                            else
                            {
                                res.Result = false;
                                res.StringError += "Dữ liệu đơn vị " + data.TenDVCS + " chưa được đồng bộ lên tổng cục \r\n";
                            }

                        }
                    }
                    
                }

            }
            catch (Exception ex)
            {
                res.Result = false;
                res.StringError += DateTime.Now.ToString() + "Lỗi khi đồng bộ dữ liệu Danh Sách Đơn Vị Lên Tổng Cục \r\n " + ex.Message;

            }
            return res;
        }
        private static PsReponse UpdateStatusSyncDanhMucDonVi(PSDanhMucDonViCoSo dvcs)
        {
            PsReponse res = new PsReponse();
            
            try
            {
                ProcessDataSync cn = new ProcessDataSync();
                db = cn.db;
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                var dv = db.PSDanhMucDonViCoSos.FirstOrDefault(p => p.MaDVCS == dvcs.MaDVCS);
                if (dv != null)
                {
                    dv.isDongBo = true;
                    db.SubmitChanges();
                }
                db.Transaction.Commit();
                db.Connection.Close();
                res.Result = true;
            }
            catch (Exception ex)
            {
                db.Transaction.Rollback();
                db.Connection.Close();
                res.Result = false;
                res.StringError = ex.ToString();
            }
            return res;
        }
    }
}
