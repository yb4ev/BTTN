namespace QuanLyVVP.Views
{
    partial class Loaisp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loaisp));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TxtIdloaisp = new DevExpress.XtraEditors.TextEdit();
            this.TxtTenloaisp = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Lb = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutC = new DevExpress.XtraLayout.LayoutControlItem();
            this.qLyVVPDataSetLoaiSP = new QuanLyVVP.QLyVVPDataSetLoaiSP();
            this.lOAISPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAISPTableAdapter = new QuanLyVVP.QLyVVPDataSetLoaiSPTableAdapters.LOAISPTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdloaisp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenloaisp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdloaisp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTenloaisp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLyVVPDataSetLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TxtIdloaisp);
            this.layoutControl1.Controls.Add(this.TxtTenloaisp);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(707, 102);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TxtIdloaisp
            // 
            this.TxtIdloaisp.Location = new System.Drawing.Point(101, 36);
            this.TxtIdloaisp.Name = "TxtIdloaisp";
            this.TxtIdloaisp.Properties.ReadOnly = true;
            this.TxtIdloaisp.Size = new System.Drawing.Size(594, 20);
            this.TxtIdloaisp.StyleController = this.layoutControl1;
            this.TxtIdloaisp.TabIndex = 4;
            // 
            // TxtTenloaisp
            // 
            this.TxtTenloaisp.Location = new System.Drawing.Point(101, 60);
            this.TxtTenloaisp.Name = "TxtTenloaisp";
            this.TxtTenloaisp.Properties.MaxLength = 30;
            this.TxtTenloaisp.Properties.ReadOnly = true;
            this.TxtTenloaisp.Size = new System.Drawing.Size(594, 20);
            this.TxtTenloaisp.StyleController = this.layoutControl1;
            this.TxtTenloaisp.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Lb,
            this.layoutControlItem2,
            this.simpleLabelItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(707, 102);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // Lb
            // 
            this.Lb.Control = this.TxtIdloaisp;
            this.Lb.Location = new System.Drawing.Point(0, 24);
            this.Lb.Name = "Lb";
            this.Lb.Size = new System.Drawing.Size(687, 24);
            this.Lb.Text = "Mã loại sản phẩm";
            this.Lb.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtTenloaisp;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(687, 34);
            this.layoutControlItem2.Text = "Tên loại sản phẩm";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(86, 13);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(687, 24);
            this.simpleLabelItem1.Text = "Thông tin loại sản phẩm";
            this.simpleLabelItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TxtIdloaisp;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(687, 24);
            this.layoutControlItem1.Text = "Mã loại sản phẩm";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(86, 13);
            // 
            // LayoutC
            // 
            this.LayoutC.Control = this.TxtTenloaisp;
            this.LayoutC.CustomizationFormText = "layoutControlItem1";
            this.LayoutC.Location = new System.Drawing.Point(0, 48);
            this.LayoutC.Name = "LayoutC";
            this.LayoutC.Size = new System.Drawing.Size(687, 24);
            this.LayoutC.Text = "Tên loại sản phẩm";
            this.LayoutC.TextSize = new System.Drawing.Size(86, 13);
            // 
            // qLyVVPDataSetLoaiSP
            // 
            this.qLyVVPDataSetLoaiSP.DataSetName = "QLyVVPDataSetLoaiSP";
            this.qLyVVPDataSetLoaiSP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAISPBindingSource
            // 
            this.lOAISPBindingSource.DataMember = "LOAISP";
            this.lOAISPBindingSource.DataSource = this.qLyVVPDataSetLoaiSP;
            // 
            // lOAISPTableAdapter
            // 
            this.lOAISPTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1,
            this.BtnThem,
            this.BtnXoa,
            this.BtnCapNhat,
            this.BtnHuy,
            this.BtnSua});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(147, 142);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnCapNhat),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnHuy)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // BtnThem
            // 
            this.BtnThem.Caption = "Thêm";
            this.BtnThem.Id = 1;
            this.BtnThem.ImageOptions.SvgImage = global::QuanLyVVP.Properties.Resources.actions_addcircled;
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThem_ItemClick);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Caption = "Xoá";
            this.BtnXoa.Id = 2;
            this.BtnXoa.ImageOptions.SvgImage = global::QuanLyVVP.Properties.Resources.actions_deletecircled;
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnXoa_ItemClick);
            // 
            // BtnSua
            // 
            this.BtnSua.Caption = "Sửa";
            this.BtnSua.Id = 5;
            this.BtnSua.ImageOptions.SvgImage = global::QuanLyVVP.Properties.Resources.actions_edit;
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSua_ItemClick);
            // 
            // BtnCapNhat
            // 
            this.BtnCapNhat.Caption = "Cập nhật";
            this.BtnCapNhat.Id = 3;
            this.BtnCapNhat.ImageOptions.Image = global::QuanLyVVP.Properties.Resources.recurrence_16x161;
            this.BtnCapNhat.ImageOptions.LargeImage = global::QuanLyVVP.Properties.Resources.recurrence_32x321;
            this.BtnCapNhat.Name = "BtnCapNhat";
            this.BtnCapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCapNhat_ItemClick);
            // 
            // BtnHuy
            // 
            this.BtnHuy.Caption = "Huỷ";
            this.BtnHuy.Enabled = false;
            this.BtnHuy.Id = 4;
            this.BtnHuy.ImageOptions.Image = global::QuanLyVVP.Properties.Resources.removepivotfield_16x16;
            this.BtnHuy.ImageOptions.LargeImage = global::QuanLyVVP.Properties.Resources.removepivotfield_32x32;
            this.BtnHuy.Name = "BtnHuy";
            this.BtnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnHuy_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(707, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 425);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(707, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 401);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(707, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 401);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemButtonEdit1;
            this.barEditItem1.Id = 0;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdloaisp,
            this.colTenloaisp});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Tìm kiếm";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdloaisp, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIdloaisp
            // 
            this.colIdloaisp.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdloaisp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdloaisp.Caption = "Mã loại sản phẩm";
            this.colIdloaisp.CustomizationCaption = "Mã loại sản phẩm";
            this.colIdloaisp.FieldName = "Idloaisp";
            this.colIdloaisp.Name = "colIdloaisp";
            this.colIdloaisp.OptionsEditForm.Caption = "Mã loại sản phẩm";
            this.colIdloaisp.Visible = true;
            this.colIdloaisp.VisibleIndex = 0;
            this.colIdloaisp.Width = 208;
            // 
            // colTenloaisp
            // 
            this.colTenloaisp.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenloaisp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenloaisp.Caption = "Tên loại sản phẩm";
            this.colTenloaisp.CustomizationCaption = "Tên loại sản phẩm";
            this.colTenloaisp.FieldName = "Tenloaisp";
            this.colTenloaisp.Name = "colTenloaisp";
            this.colTenloaisp.OptionsEditForm.Caption = "Tên loại sản phẩm";
            this.colTenloaisp.Visible = true;
            this.colTenloaisp.VisibleIndex = 1;
            this.colTenloaisp.Width = 860;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.lOAISPBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 126);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(707, 299);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Loaisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 448);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loaisp";
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.Loaisp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdloaisp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTenloaisp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLyVVPDataSetLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit TxtIdloaisp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit TxtTenloaisp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlItem LayoutC;
        private DevExpress.XtraLayout.LayoutControlItem Lb;
        private QLyVVPDataSetLoaiSP qLyVVPDataSetLoaiSP;
        private System.Windows.Forms.BindingSource lOAISPBindingSource;
        private QLyVVPDataSetLoaiSPTableAdapters.LOAISPTableAdapter lOAISPTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnThem;
        private DevExpress.XtraBars.BarButtonItem BtnXoa;
        private DevExpress.XtraBars.BarButtonItem BtnCapNhat;
        private DevExpress.XtraBars.BarButtonItem BtnHuy;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdloaisp;
        private DevExpress.XtraGrid.Columns.GridColumn colTenloaisp;
        private DevExpress.XtraBars.BarButtonItem BtnSua;
    }
}