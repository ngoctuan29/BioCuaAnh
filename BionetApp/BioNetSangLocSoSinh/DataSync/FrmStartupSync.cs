using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataSync.BioNetSync;

namespace DataSync
{
    public partial class FrmStartupSync : DevExpress.XtraEditors.XtraForm
    {
        public FrmStartupSync()
        {
            InitializeComponent();
        }
        private void mnStart_Click(object sender, EventArgs e)
        {
            
        }
        private void GetDuLieuBanDau()
        {
            this.PostThongTinTrungTam();
            this.GetThongTinTrungTam();
            this.GetDanhMucChiCuc();
            this.PostDanhMucChiCuc();
            this.GetDanhMucDichVu();
            //this.PostDanhMucDonViCoSo();
            //this.GetDanhSachChuongTrinh();
        }
        private void GetDanhMucChiCuc()
        {
            this.rtbStatus.SelectionColor = Color.LightYellow;
            this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :Đang đồng bộ dữ liệu Chi Cục \r\n " }));
            var res = DanhMucChiCucSync.GetDanhMucChiCuc();
            if (res.Result)
            {
                this.rtbStatus.SelectionColor = Color.LightYellow;
                this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :đồng bộ dữ liệu Chi Cục thành công \r\n " }));
            }
            else
            {
                this.rtbStatus.SelectionColor = Color.Red;
                this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :đồng bộ dữ liệu Chi Cục KHÔNG thành công\r\n Lỗi chi tiết : \r\n" + res.StringError + "\r\n" }));
            }
            this.rtbStatus.ScrollToCaret();
        }
        private void GetThongTinTrungTam()
        {
            this.rtbStatus.SelectionColor = Color.LightYellow;
            this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :Đang đồng bộ dữ liệu Trung tâm \r\n " }));
            var res = ThongTinTrungTamSync.GetThongTinTrungTam();
            if (res.Result)
            {
                this.rtbStatus.SelectionColor = Color.LightYellow;
                this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :đồng bộ dữ liệu Trung tâm thành công \r\n " }));
            }
            else
            {
                this.rtbStatus.SelectionColor = Color.Red;
                this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :đồng bộ dữ liệu Trung tâm KHÔNG thành công\r\n Lỗi chi tiết : \r\n" + res.StringError + "\r\n" }));
            }
            this.rtbStatus.ScrollToCaret();
        }
        private void PostThongTinTrungTam()
        {
            this.rtbStatus.SelectionColor = Color.LightYellow;
            this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :Đang đồng bộ dữ liệu Trung tâm \r\n " }));
            var res = ThongTinTrungTamSync.PostThongtinTrungTam();
            if (string.IsNullOrEmpty(res.StringError))
            {
                this.rtbStatus.SelectionColor = Color.LightYellow;
                this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :đồng bộ dữ liệu Trung tâm thành công \r\n " }));
            }
            else
            {
                this.rtbStatus.SelectionColor = Color.Red;
                this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + ":Thông tin chi tiết khi đồng bộ dữ liệu Thông tin Trung tâm \r\n" + res.StringError + "\r\n" }));
            }
            
            this.rtbStatus.ScrollToCaret();
        }
        private void PostDanhMucDonViCoSo()
        {
            //this.rtbStatus.SelectionColor = Color.LightYellow;
            //this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :Đang đồng bộ dữ liệu Đơn vị cơ sở \r\n " }));
            //var res = ProcessDataSync.PostDanhMucDonViCoSo();
            //if (res.Result)
            //{
            //    this.rtbStatus.SelectionColor = Color.LightYellow;
            //    this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :đồng bộ dữ liệu Đơn vị cơ sở thành công \r\n " }));
            //}
            //else
            //{
            //    this.rtbStatus.SelectionColor = Color.Red;
            //    this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :đồng bộ dữ liệu Đơn vị cơ sở KHÔNG thành công\r\n Lỗi chi tiết : \r\n" + res.StringError + "\r\n" }));
            //}
            //this.rtbStatus.ScrollToCaret();
        }
        private void PostDanhMucChiCuc()
        {
            //this.rtbStatus.SelectionColor = Color.LightYellow;
            //this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :Đang đồng bộ dữ liệu Đơn vị cơ sở \r\n " }));
            //var res = ProcessDataSync.PostDanhMucChiCuc();
            //if (res.Result)
            //{
            //    this.rtbStatus.SelectionColor = Color.LightYellow;
            //    this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :đồng bộ dữ liệu Đơn vị cơ sở thành công \r\n " }));
            //}
            //else
            //{
            //    this.rtbStatus.SelectionColor = Color.Red;
            //    this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :đồng bộ dữ liệu Đơn vị cơ sở KHÔNG thành công\r\n Lỗi chi tiết : \r\n" + res.StringError + "\r\n" }));
            //}
            //this.rtbStatus.ScrollToCaret();
        }
        private void GetDanhSachChuongTrinh()
        {
            //this.rtbStatus.SelectionColor = Color.LightYellow;
            //this.rtbStatus.AppendText(string.Concat(new object[] {DateTime.Now + " :Đang lấy dữ liệu Danh sách chương trình sàng lọc \r\n "}));
            //var res = ProcessDataSync.GetDanhSachChuongTrinh();
            //if(res.Result)
            //{
            //    this.rtbStatus.SelectionColor = Color.LightYellow;
            //    this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :Lấy dữ liệu Danh sách chương trình sàng lọc thành công \r\n " }));
            //}
            //else
            //{
            //    this.rtbStatus.SelectionColor = Color.Red;
            //    this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :Lấy dữ liệu Danh sách chương trình sàng lọc KHÔNG thành công\r\n Lỗi chi tiết : \r\n" + res.StringError  +"\r\n"}));
            //}
            //this.rtbStatus.ScrollToCaret();
               
        }
        private void GetDanhMucDichVu()
        {
            this.rtbStatus.SelectionColor = Color.LightYellow;
            this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :Đang lấy dữ liệu Danh mục dịch vụ \r\n " }));
            var res = DanhMucDichVuSync.GetDMDichVu();
            if (res.Result)
            {
                this.rtbStatus.SelectionColor = Color.LightYellow;
                this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :Lấy dữ liệu Danh mục dịch vụ thành công \r\n " }));
            }
            else
            {
                this.rtbStatus.SelectionColor = Color.Red;
                this.rtbStatus.AppendText(string.Concat(new object[] { DateTime.Now + " :Lấy dữ liệu Danh mục dịch vụ KHÔNG thành công\r\n Lỗi chi tiết : \r\n" + res.StringError }));
            }
            this.rtbStatus.ScrollToCaret();

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GetDuLieuBanDau();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}