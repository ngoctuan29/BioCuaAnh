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
using BioNetBLL;

namespace BioNetSangLocSoSinh.FrmReports
{
    public partial class FrmBaoCaoDonVi_ChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public FrmBaoCaoDonVi_ChiTiet()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoDonVi_ChiTiet_Load(object sender, EventArgs e)
        {
            this.txtChiCuc.Properties.DataSource = BioNet_Bus.GetDieuKienLocBaoCao_ChiCuc();
            this.txtDonVi.Properties.DataSource = BioNet_Bus.GetDieuKienLocBaoCao_DonVi("all");
        }
    }
}