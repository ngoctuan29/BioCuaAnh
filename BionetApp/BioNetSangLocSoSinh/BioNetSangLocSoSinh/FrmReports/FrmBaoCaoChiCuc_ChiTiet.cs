using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BioNetSangLocSoSinh.FrmReports
{
    public partial class FrmBaoCaoChiCuc_ChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public FrmBaoCaoChiCuc_ChiTiet()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoChiCuc_ChiTiet_Load(object sender, EventArgs e)
        {
            FrmReports.urcReportTrungTam_DonVi urc = new urcReportTrungTam_DonVi();
            urc.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(urc);
        }
        //private void FrmBaoCaoChiTiet_TrungTam_Load(object sender, EventArgs e)
        //{
        //    

        //}
    }
}