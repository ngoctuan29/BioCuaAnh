namespace BioNetSangLocSoSinh.FrmReports
{
    partial class FrmBaoCaoDonVi_ChiTiet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoDonVi_ChiTiet));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.GC_Phieu = new DevExpress.XtraGrid.GridControl();
            this.GV_Phieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_GCPhieu_ChiCuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GCPhieu_DonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GCPhieu_MaPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GCPhieu_TinhTrangPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GCPhieu_TrangThaiMau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GCPhieu_MaBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GCPhieu_MaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GCPhieu_TenBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonVi = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtChiCuc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_idChiCuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TenChiCuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.butPrint = new DevExpress.XtraEditors.SimpleButton();
            this.butOK = new DevExpress.XtraEditors.SimpleButton();
            this.dllNgay = new UserControlDate.dllNgay();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Phieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Phieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChiCuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl16);
            this.panelControl1.Controls.Add(this.txtDonVi);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.txtChiCuc);
            this.panelControl1.Controls.Add(this.butPrint);
            this.panelControl1.Controls.Add(this.butOK);
            this.panelControl1.Controls.Add(this.dllNgay);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1301, 91);
            this.panelControl1.TabIndex = 0;
            // 
            // GC_Phieu
            // 
            this.GC_Phieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GC_Phieu.Location = new System.Drawing.Point(0, 91);
            this.GC_Phieu.MainView = this.GV_Phieu;
            this.GC_Phieu.Name = "GC_Phieu";
            this.GC_Phieu.Size = new System.Drawing.Size(1301, 668);
            this.GC_Phieu.TabIndex = 1;
            this.GC_Phieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Phieu});
            // 
            // GV_Phieu
            // 
            this.GV_Phieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_GCPhieu_ChiCuc,
            this.col_GCPhieu_DonVi,
            this.col_GCPhieu_MaPhieu,
            this.col_GCPhieu_TinhTrangPhieu,
            this.col_GCPhieu_TrangThaiMau,
            this.col_GCPhieu_MaBN,
            this.col_GCPhieu_MaKhachHang,
            this.col_GCPhieu_TenBN});
            this.GV_Phieu.GridControl = this.GC_Phieu;
            this.GV_Phieu.Name = "GV_Phieu";
            // 
            // col_GCPhieu_ChiCuc
            // 
            this.col_GCPhieu_ChiCuc.Caption = "Chi cục";
            this.col_GCPhieu_ChiCuc.Name = "col_GCPhieu_ChiCuc";
            this.col_GCPhieu_ChiCuc.Visible = true;
            this.col_GCPhieu_ChiCuc.VisibleIndex = 0;
            // 
            // col_GCPhieu_DonVi
            // 
            this.col_GCPhieu_DonVi.Caption = "Đơn vị";
            this.col_GCPhieu_DonVi.Name = "col_GCPhieu_DonVi";
            this.col_GCPhieu_DonVi.Visible = true;
            this.col_GCPhieu_DonVi.VisibleIndex = 1;
            // 
            // col_GCPhieu_MaPhieu
            // 
            this.col_GCPhieu_MaPhieu.Caption = "Mã phiếu";
            this.col_GCPhieu_MaPhieu.Name = "col_GCPhieu_MaPhieu";
            this.col_GCPhieu_MaPhieu.Visible = true;
            this.col_GCPhieu_MaPhieu.VisibleIndex = 2;
            // 
            // col_GCPhieu_TinhTrangPhieu
            // 
            this.col_GCPhieu_TinhTrangPhieu.Caption = "Tình trạng";
            this.col_GCPhieu_TinhTrangPhieu.Name = "col_GCPhieu_TinhTrangPhieu";
            this.col_GCPhieu_TinhTrangPhieu.Visible = true;
            this.col_GCPhieu_TinhTrangPhieu.VisibleIndex = 3;
            // 
            // col_GCPhieu_TrangThaiMau
            // 
            this.col_GCPhieu_TrangThaiMau.Caption = "Trạng thái mẫu";
            this.col_GCPhieu_TrangThaiMau.Name = "col_GCPhieu_TrangThaiMau";
            this.col_GCPhieu_TrangThaiMau.Visible = true;
            this.col_GCPhieu_TrangThaiMau.VisibleIndex = 4;
            // 
            // col_GCPhieu_MaBN
            // 
            this.col_GCPhieu_MaBN.Caption = "Mã Bệnh nhân";
            this.col_GCPhieu_MaBN.Name = "col_GCPhieu_MaBN";
            this.col_GCPhieu_MaBN.Visible = true;
            this.col_GCPhieu_MaBN.VisibleIndex = 5;
            // 
            // col_GCPhieu_MaKhachHang
            // 
            this.col_GCPhieu_MaKhachHang.Caption = "Mã khach hàng";
            this.col_GCPhieu_MaKhachHang.Name = "col_GCPhieu_MaKhachHang";
            this.col_GCPhieu_MaKhachHang.Visible = true;
            this.col_GCPhieu_MaKhachHang.VisibleIndex = 6;
            // 
            // col_GCPhieu_TenBN
            // 
            this.col_GCPhieu_TenBN.Caption = "Tên bệnh nhân";
            this.col_GCPhieu_TenBN.Name = "col_GCPhieu_TenBN";
            this.col_GCPhieu_TenBN.Visible = true;
            this.col_GCPhieu_TenBN.VisibleIndex = 7;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(350, 38);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(49, 17);
            this.labelControl16.TabIndex = 1067;
            this.labelControl16.Text = "Đơn vị :";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(399, 34);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonVi.Properties.DisplayMember = "TenDVCS";
            this.txtDonVi.Properties.NullText = "Chọn";
            this.txtDonVi.Properties.PopupFormMinSize = new System.Drawing.Size(350, 350);
            this.txtDonVi.Properties.PopupFormSize = new System.Drawing.Size(270, 300);
            this.txtDonVi.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.txtDonVi.Properties.ShowFooter = false;
            this.txtDonVi.Properties.ValueMember = "MaDVCS";
            this.txtDonVi.Properties.View = this.gridView1;
            this.txtDonVi.Size = new System.Drawing.Size(204, 22);
            this.txtDonVi.TabIndex = 1068;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã";
            this.gridColumn1.FieldName = "MaDVCS";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Đơn vị";
            this.gridColumn2.FieldName = "TenDVCS";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(344, 6);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(54, 17);
            this.labelControl9.TabIndex = 1065;
            this.labelControl9.Text = "Chi cục :";
            // 
            // txtChiCuc
            // 
            this.txtChiCuc.Location = new System.Drawing.Point(399, 2);
            this.txtChiCuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChiCuc.Name = "txtChiCuc";
            this.txtChiCuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtChiCuc.Properties.DisplayMember = "TenChiCuc";
            this.txtChiCuc.Properties.NullText = "Chọn";
            this.txtChiCuc.Properties.PopupFormMinSize = new System.Drawing.Size(350, 350);
            this.txtChiCuc.Properties.PopupFormSize = new System.Drawing.Size(270, 300);
            this.txtChiCuc.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.txtChiCuc.Properties.ShowFooter = false;
            this.txtChiCuc.Properties.ValueMember = "MaChiCuc";
            this.txtChiCuc.Properties.View = this.gridView2;
            this.txtChiCuc.Size = new System.Drawing.Size(204, 22);
            this.txtChiCuc.TabIndex = 1066;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_idChiCuc,
            this.col_TenChiCuc});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowColumnHeaders = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // col_idChiCuc
            // 
            this.col_idChiCuc.Caption = "Mã";
            this.col_idChiCuc.FieldName = "MaChiCuc";
            this.col_idChiCuc.Name = "col_idChiCuc";
            // 
            // col_TenChiCuc
            // 
            this.col_TenChiCuc.Caption = "ChiCuc";
            this.col_TenChiCuc.FieldName = "TenChiCuc";
            this.col_TenChiCuc.Name = "col_TenChiCuc";
            this.col_TenChiCuc.Visible = true;
            this.col_TenChiCuc.VisibleIndex = 0;
            // 
            // butPrint
            // 
            this.butPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.butPrint.Image = ((System.Drawing.Image)(resources.GetObject("butPrint.Image")));
            this.butPrint.Location = new System.Drawing.Point(626, 46);
            this.butPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(93, 32);
            this.butPrint.TabIndex = 1064;
            this.butPrint.Text = "In";
            // 
            // butOK
            // 
            this.butOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.butOK.Image = ((System.Drawing.Image)(resources.GetObject("butOK.Image")));
            this.butOK.Location = new System.Drawing.Point(626, 6);
            this.butOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(93, 32);
            this.butOK.TabIndex = 1063;
            this.butOK.Text = "Lấy số liệu";
            // 
            // dllNgay
            // 
            this.dllNgay.BackColor = System.Drawing.Color.Transparent;
            this.dllNgay.Location = new System.Drawing.Point(0, 0);
            this.dllNgay.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dllNgay.Name = "dllNgay";
            this.dllNgay.Size = new System.Drawing.Size(344, 90);
            this.dllNgay.TabIndex = 1062;
            // 
            // FrmBaoCaoDonVi_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 759);
            this.Controls.Add(this.GC_Phieu);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaoCaoDonVi_ChiTiet";
            this.Text = "FrmBaoCaoDonVi_ChiTiet";
            this.Load += new System.EventHandler(this.FrmBaoCaoDonVi_ChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Phieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Phieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChiCuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl GC_Phieu;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_Phieu;
        private DevExpress.XtraGrid.Columns.GridColumn col_GCPhieu_ChiCuc;
        private DevExpress.XtraGrid.Columns.GridColumn col_GCPhieu_DonVi;
        private DevExpress.XtraGrid.Columns.GridColumn col_GCPhieu_MaPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn col_GCPhieu_TinhTrangPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn col_GCPhieu_TrangThaiMau;
        private DevExpress.XtraGrid.Columns.GridColumn col_GCPhieu_MaBN;
        private DevExpress.XtraGrid.Columns.GridColumn col_GCPhieu_MaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn col_GCPhieu_TenBN;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.SearchLookUpEdit txtDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SearchLookUpEdit txtChiCuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col_idChiCuc;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenChiCuc;
        private DevExpress.XtraEditors.SimpleButton butPrint;
        private DevExpress.XtraEditors.SimpleButton butOK;
        private UserControlDate.dllNgay dllNgay;
    }
}