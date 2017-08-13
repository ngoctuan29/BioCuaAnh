using System.Linq;
using System.Text;
using BioNetModel.Data;
using BioNetModel;
using Bionet.API.Models;
using System.Net;
using System.Security;
using System.Web.Script.Serialization;
using System.Web;
using System.Data.Linq;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Security.Cryptography;
using DataSync;
using System.Data;
using System.Reflection;
using DataSync.BioNetSync;
using System.Drawing;
using System.Collections.Generic;
using System;

namespace DataSync.BioNetSync
{
    

    public class DanhMucGoiDichVuTheoDonViSync
    {
        private static BioNetDBContextDataContext db = null;
        // private static string linkhost = "http://localhost:53112";
        private static string linkDanhMucGoiDichVuTheoDonVi = "/api/goidichvuchung/getallGoiDichVu?keyword=&page=0&pagesize=999";
        private static string linkPostDanhMucGoiDichVuTheoDonVi = "/api/chitietgoidichvu/getServiceByServicePackage/";

        public static PsReponse GetDMGoiDichVuChung()
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
                        var result = cn.GetRespone(cn.CreateLink(linkDanhMucGoiDichVuTheoDonVi), token);
                        if (result.Result)
                        {
                            string json = result.ValueResult;
                            JavaScriptSerializer jss = new JavaScriptSerializer();
                            ObjectModel.RootObjectAPI Repo = jss.Deserialize<ObjectModel.RootObjectAPI>(json);
                            if (Repo != null)
                            {
                                if (Repo.TotalCount > 0)
                                {
                                    foreach (var item in Repo.Items)
                                    {
                                        PSDanhMucGoiDichVuTheoDonVi ct = new PSDanhMucGoiDichVuTheoDonVi();
                                        ct = cn.CovertDynamicToObjectModel(item, ct);
                                        UpdateDMGoiDichVuTheoDonVi(ct);
                                    }
                                    res.Result = true;
                                }

                            }
                            else
                            {
                                res.Result = false;
                                res.StringError = result.ErorrResult;
                            }
                        }
                        else
                        {
                            res.Result = false;
                            res.StringError = result.ErorrResult;
                        }
                    }
                    else
                    {
                        res.Result = false;
                        res.StringError = "Kiểm tra lại kết nối mạng hoặc tài khoản đồng bộ!";
                    }

                }
                else
                {
                    res.Result = false;
                    res.StringError = "Chưa có  tài khoản đồng bộ!";
                }

            }
            catch (Exception ex)
            {
                res.Result = false;
                res.StringError = DateTime.Now.ToString() + "Lỗi khi get dữ liệu Danh Mục Gói Dịch Vụ Chung từ server \r\n " + ex.Message;
            }
            return res;
        }
        public static PsReponse UpdateDMGoiDichVuTheoDonVi(PSDanhMucGoiDichVuTheoDonVi cl)
        {
            PsReponse res = new PsReponse();
            try
            {
                ProcessDataSync cn = new ProcessDataSync();
                db = cn.db;
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();

                var kyt = db.PSDanhMucGoiDichVuTheoDonVis.FirstOrDefault(p => p.IDGoiDichVuChung == cl.IDGoiDichVuChung &&p.MaDVCS==cl.MaDVCS);
                if (kyt != null)
                {
                    kyt.TenGoiDichVuTrungTam = Encoding.UTF8.GetString(Encoding.Default.GetBytes(cl.TenGoiDichVuTrungTam));
                    kyt.DonGia = cl.DonGia;
                    kyt.ChietKhau = cl.ChietKhau;
                    db.SubmitChanges();
                }
                else
                {
                    PSDanhMucGoiDichVuTheoDonVi kyth = new PSDanhMucGoiDichVuTheoDonVi();
                    kyth.ChietKhau = cl.ChietKhau;
                    kyth.DonGia = cl.DonGia;
                    kyth.MaDVCS = cl.MaDVCS;
                    kyth.IDGoiDichVuChung = cl.IDGoiDichVuChung;
                    kyth.TenGoiDichVuTrungTam = Encoding.UTF8.GetString(Encoding.Default.GetBytes(cl.TenGoiDichVuTrungTam));
                    db.PSDanhMucGoiDichVuTheoDonVis.InsertOnSubmit(kyth);
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
