namespace QuanLyVVP.Views
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.BtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.TxtTimkiem = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.BtnTimkiem = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TxtSdt = new DevExpress.XtraEditors.TextEdit();
            this.TxtDiachi = new DevExpress.XtraEditors.TextEdit();
            this.TxtTenkh = new DevExpress.XtraEditors.TextEdit();
            this.TxtIdkh = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLyVVPDataSetAll = new QuanLyVVP.QLyVVPDataSetAll();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kHACHHANGTableAdapter = new QuanLyVVP.QLyVVPDataSetAllTableAdapters.KHACHHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTenkh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdkh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLyVVPDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.BtnThem,
            this.BtnSua,
            this.BtnXoa,
            this.BtnCapNhat,
            this.BtnHuy,
            this.TxtTimkiem,
            this.BtnTimkiem});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 14;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnXoa),
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
            // BtnSua
            // 
            this.BtnSua.Caption = "Sửa";
            this.BtnSua.Id = 2;
            this.BtnSua.ImageOptions.SvgImage = global::QuanLyVVP.Properties.Resources.actions_edit;
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSua_ItemClick);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Caption = "Xoá";
            this.BtnXoa.Id = 3;
            this.BtnXoa.ImageOptions.SvgImage = global::QuanLyVVP.Properties.Resources.actions_deletecircled;
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnXoa_ItemClick);
            // 
            // BtnCapNhat
            // 
            this.BtnCapNhat.Caption = "Cập nhật";
            this.BtnCapNhat.Id = 4;
            this.BtnCapNhat.ImageOptions.Image = global::QuanLyVVP.Properties.Resources.recurrence_16x16;
            this.BtnCapNhat.Name = "BtnCapNhat";
            this.BtnCapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCapNhat_ItemClick);
            // 
            // BtnHuy
            // 
            this.BtnHuy.Caption = "Huỷ";
            this.BtnHuy.Enabled = false;
            this.BtnHuy.Id = 5;
            this.BtnHuy.ImageOptions.Image = global::QuanLyVVP.Properties.Resources.removepivotfield_16x16;
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
            this.barDockControlTop.Size = new System.Drawing.Size(556, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 404);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(556, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 380);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(556, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 380);
            // 
            // TxtTimkiem
            // 
            this.TxtTimkiem.Edit = this.repositoryItemTextEdit3;
            this.TxtTimkiem.Id = 11;
            this.TxtTimkiem.Name = "TxtTimkiem";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // BtnTimkiem
            // 
            this.BtnTimkiem.Id = 13;
            this.BtnTimkiem.ImageOptions.SvgImage = global::QuanLyVVP.Properties.Resources.actions_zoom1;
            this.BtnTimkiem.Name = "BtnTimkiem";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemTextEdit2.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TxtSdt);
            this.layoutControl1.Controls.Add(this.TxtDiachi);
            this.layoutControl1.Controls.Add(this.TxtTenkh);
            this.layoutControl1.Controls.Add(this.TxtIdkh);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(646, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(556, 105);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TxtSdt
            // 
            this.TxtSdt.Location = new System.Drawing.Point(91, 60);
            this.TxtSdt.MenuManager = this.barManager1;
            this.TxtSdt.Name = "TxtSdt";
            this.TxtSdt.Properties.Mask.BeepOnError = true;
            this.TxtSdt.Properties.Mask.EditMask = "0000000000";
            this.TxtSdt.Properties.Mask.IgnoreMaskBlank = false;
            this.TxtSdt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSdt.Properties.Mask.SaveLiteral = false;
            this.TxtSdt.Properties.MaxLength = 10;
            this.TxtSdt.Properties.ReadOnly = true;
            this.TxtSdt.Size = new System.Drawing.Size(178, 20);
            this.TxtSdt.StyleController = this.layoutControl1;
            this.TxtSdt.TabIndex = 3;
            // 
            // TxtDiachi
            // 
            this.TxtDiachi.Location = new System.Drawing.Point(352, 60);
            this.TxtDiachi.MenuManager = this.barManager1;
            this.TxtDiachi.Name = "TxtDiachi";
            this.TxtDiachi.Properties.MaxLength = 30;
            this.TxtDiachi.Properties.ReadOnly = true;
            this.TxtDiachi.Size = new System.Drawing.Size(192, 20);
            this.TxtDiachi.StyleController = this.layoutControl1;
            this.TxtDiachi.TabIndex = 4;
            // 
            // TxtTenkh
            // 
            this.TxtTenkh.Location = new System.Drawing.Point(352, 36);
            this.TxtTenkh.MenuManager = this.barManager1;
            this.TxtTenkh.Name = "TxtTenkh";
            this.TxtTenkh.Properties.MaxLength = 30;
            this.TxtTenkh.Properties.ReadOnly = true;
            this.TxtTenkh.Size = new System.Drawing.Size(192, 20);
            this.TxtTenkh.StyleController = this.layoutControl1;
            this.TxtTenkh.TabIndex = 2;
            // 
            // TxtIdkh
            // 
            this.TxtIdkh.Location = new System.Drawing.Point(91, 36);
            this.TxtIdkh.MenuManager = this.barManager1;
            this.TxtIdkh.Name = "TxtIdkh";
            this.TxtIdkh.Properties.ReadOnly = true;
            this.TxtIdkh.Size = new System.Drawing.Size(178, 20);
            this.TxtIdkh.StyleController = this.layoutControl1;
            this.TxtIdkh.TabIndex = 1;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.simpleLabelItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(556, 105);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TxtIdkh;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(261, 24);
            this.layoutControlItem1.Text = "Mã khách hàng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(76, 13);
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
            this.simpleLabelItem1.Size = new System.Drawing.Size(536, 24);
            this.simpleLabelItem1.Text = "Thông tin khách hàng";
            this.simpleLabelItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TxtDiachi;
            this.layoutControlItem3.Location = new System.Drawing.Point(261, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(275, 37);
            this.layoutControlItem3.Text = "Địa chỉ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.TxtSdt;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(261, 37);
            this.layoutControlItem4.Text = "Số điện thoại";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtTenkh;
            this.layoutControlItem2.Location = new System.Drawing.Point(261, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(275, 24);
            this.layoutControlItem2.Text = "Tên khách hàng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(76, 13);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kHACHHANGBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 129);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(556, 275);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLyVVPDataSetAll;
            // 
            // qLyVVPDataSetAll
            // 
            this.qLyVVPDataSetAll.DataSetName = "QLyVVPDataSetAll";
            this.qLyVVPDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdkh,
            this.colTenkh,
            this.colDiachi,
            this.colSdt});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIdkh
            // 
            this.colIdkh.AppearanceCell.Options.UseTextOptions = true;
            this.colIdkh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdkh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colIdkh.AppearanceHeader.Options.UseFont = true;
            this.colIdkh.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdkh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdkh.Caption = "Mã khách hàng";
            this.colIdkh.FieldName = "Idkh";
            this.colIdkh.Name = "colIdkh";
            this.colIdkh.Visible = true;
            this.colIdkh.VisibleIndex = 0;
            this.colIdkh.Width = 203;
            // 
            // colTenkh
            // 
            this.colTenkh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenkh.AppearanceHeader.Options.UseFont = true;
            this.colTenkh.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenkh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenkh.Caption = "Tên khách hàng";
            this.colTenkh.FieldName = "Tenkh";
            this.colTenkh.Name = "colTenkh";
            this.colTenkh.Visible = true;
            this.colTenkh.VisibleIndex = 1;
            this.colTenkh.Width = 270;
            // 
            // colDiachi
            // 
            this.colDiachi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDiachi.AppearanceHeader.Options.UseFont = true;
            this.colDiachi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiachi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiachi.Caption = "Địa chỉ";
            this.colDiachi.FieldName = "Diachi";
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Visible = true;
            this.colDiachi.VisibleIndex = 2;
            this.colDiachi.Width = 362;
            // 
            // colSdt
            // 
            this.colSdt.AppearanceCell.Options.UseTextOptions = true;
            this.colSdt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSdt.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSdt.AppearanceHeader.Options.UseFont = true;
            this.colSdt.AppearanceHeader.Options.UseTextOptions = true;
            this.colSdt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSdt.Caption = "Số điện thoại";
            this.colSdt.FieldName = "Sdt";
            this.colSdt.Name = "colSdt";
            this.colSdt.Visible = true;
            this.colSdt.VisibleIndex = 3;
            this.colSdt.Width = 233;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 427);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KhachHang";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTenkh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdkh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLyVVPDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnThem;
        private DevExpress.XtraBars.BarButtonItem BtnSua;
        private DevExpress.XtraBars.BarButtonItem BtnXoa;
        private DevExpress.XtraBars.BarButtonItem BtnCapNhat;
        private DevExpress.XtraBars.BarButtonItem BtnHuy;
        private DevExpress.XtraBars.BarEditItem TxtTimkiem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarButtonItem BtnTimkiem;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private QLyVVPDataSetAll qLyVVPDataSetAll;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLyVVPDataSetAllTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdkh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenkh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colSdt;
        private DevExpress.XtraEditors.TextEdit TxtSdt;
        private DevExpress.XtraEditors.TextEdit TxtDiachi;
        private DevExpress.XtraEditors.TextEdit TxtTenkh;
        private DevExpress.XtraEditors.TextEdit TxtIdkh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}