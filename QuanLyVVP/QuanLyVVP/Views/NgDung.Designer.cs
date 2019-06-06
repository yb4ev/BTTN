namespace QuanLyVVP.Views
{
    partial class NgDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NgDung));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.BtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.BtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCapnhat = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtTenngdung = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TxtMatkhau = new DevExpress.XtraEditors.TextEdit();
            this.TxtTendn = new DevExpress.XtraEditors.TextEdit();
            this.TxtChucvu = new DevExpress.XtraEditors.TextEdit();
            this.TxtIdngdung = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.nGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLyVVPDataSetAll = new QuanLyVVP.QLyVVPDataSetAll();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdngdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenngdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTendn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatkhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nGUOIDUNGTableAdapter = new QuanLyVVP.QLyVVPDataSetAllTableAdapters.NGUOIDUNGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTenngdung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTendn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtChucvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdngdung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLyVVPDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
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
            this.BtnCapnhat,
            this.BtnHuy});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnCapnhat),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnHuy)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // BtnThem
            // 
            this.BtnThem.Caption = "Thêm";
            this.BtnThem.Id = 0;
            this.BtnThem.ImageOptions.SvgImage = global::QuanLyVVP.Properties.Resources.actions_addcircled;
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThem_ItemClick);
            // 
            // BtnSua
            // 
            this.BtnSua.Caption = "Sửa";
            this.BtnSua.Id = 1;
            this.BtnSua.ImageOptions.SvgImage = global::QuanLyVVP.Properties.Resources.actions_edit;
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSua_ItemClick);
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
            // BtnCapnhat
            // 
            this.BtnCapnhat.Caption = "Cập nhật";
            this.BtnCapnhat.Id = 3;
            this.BtnCapnhat.ImageOptions.Image = global::QuanLyVVP.Properties.Resources.recurrence_16x16;
            this.BtnCapnhat.Name = "BtnCapnhat";
            this.BtnCapnhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnCapnhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCapnhat_ItemClick);
            // 
            // BtnHuy
            // 
            this.BtnHuy.Caption = "Huỷ";
            this.BtnHuy.Enabled = false;
            this.BtnHuy.Id = 4;
            this.BtnHuy.ImageOptions.Image = global::QuanLyVVP.Properties.Resources.removepivotfield_16x16;
            this.BtnHuy.Name = "BtnHuy";
            this.BtnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnHuy_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusBar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusBar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(752, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 409);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(752, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 385);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(752, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 385);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.simpleLabelItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(752, 134);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtTenngdung;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(366, 24);
            this.layoutControlItem2.Text = "Tên người dùng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // TxtTenngdung
            // 
            this.TxtTenngdung.Location = new System.Drawing.Point(90, 60);
            this.TxtTenngdung.MenuManager = this.barManager1;
            this.TxtTenngdung.Name = "TxtTenngdung";
            this.TxtTenngdung.Properties.MaxLength = 30;
            this.TxtTenngdung.Properties.ReadOnly = true;
            this.TxtTenngdung.Size = new System.Drawing.Size(284, 20);
            this.TxtTenngdung.StyleController = this.layoutControl1;
            this.TxtTenngdung.TabIndex = 11;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TxtMatkhau);
            this.layoutControl1.Controls.Add(this.TxtTendn);
            this.layoutControl1.Controls.Add(this.TxtChucvu);
            this.layoutControl1.Controls.Add(this.TxtTenngdung);
            this.layoutControl1.Controls.Add(this.TxtIdngdung);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(752, 134);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TxtMatkhau
            // 
            this.TxtMatkhau.Location = new System.Drawing.Point(456, 60);
            this.TxtMatkhau.MenuManager = this.barManager1;
            this.TxtMatkhau.Name = "TxtMatkhau";
            this.TxtMatkhau.Properties.MaxLength = 10;
            this.TxtMatkhau.Properties.ReadOnly = true;
            this.TxtMatkhau.Size = new System.Drawing.Size(284, 20);
            this.TxtMatkhau.StyleController = this.layoutControl1;
            this.TxtMatkhau.TabIndex = 14;
            // 
            // TxtTendn
            // 
            this.TxtTendn.Location = new System.Drawing.Point(456, 36);
            this.TxtTendn.MenuManager = this.barManager1;
            this.TxtTendn.Name = "TxtTendn";
            this.TxtTendn.Properties.MaxLength = 10;
            this.TxtTendn.Properties.ReadOnly = true;
            this.TxtTendn.Size = new System.Drawing.Size(284, 20);
            this.TxtTendn.StyleController = this.layoutControl1;
            this.TxtTendn.TabIndex = 13;
            // 
            // TxtChucvu
            // 
            this.TxtChucvu.Location = new System.Drawing.Point(90, 84);
            this.TxtChucvu.MenuManager = this.barManager1;
            this.TxtChucvu.Name = "TxtChucvu";
            this.TxtChucvu.Properties.MaxLength = 20;
            this.TxtChucvu.Properties.ReadOnly = true;
            this.TxtChucvu.Size = new System.Drawing.Size(284, 20);
            this.TxtChucvu.StyleController = this.layoutControl1;
            this.TxtChucvu.TabIndex = 12;
            // 
            // TxtIdngdung
            // 
            this.TxtIdngdung.Location = new System.Drawing.Point(90, 36);
            this.TxtIdngdung.MenuManager = this.barManager1;
            this.TxtIdngdung.Name = "TxtIdngdung";
            this.TxtIdngdung.Properties.ReadOnly = true;
            this.TxtIdngdung.Size = new System.Drawing.Size(284, 20);
            this.TxtIdngdung.StyleController = this.layoutControl1;
            this.TxtIdngdung.TabIndex = 10;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TxtIdngdung;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(366, 24);
            this.layoutControlItem1.Text = "Mã người dùng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
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
            this.simpleLabelItem1.Size = new System.Drawing.Size(732, 24);
            this.simpleLabelItem1.Text = "Thông tin người dùng";
            this.simpleLabelItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.TxtTendn;
            this.layoutControlItem4.Location = new System.Drawing.Point(366, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(366, 24);
            this.layoutControlItem4.Text = "Tên đăng nhập";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.TxtMatkhau;
            this.layoutControlItem5.Location = new System.Drawing.Point(366, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(366, 66);
            this.layoutControlItem5.Text = "Mật khẩu";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TxtChucvu;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(366, 42);
            this.layoutControlItem3.Text = "Chức vụ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 13);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nGUOIDUNGBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 158);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(752, 251);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGBindingSource.DataMember = "NGUOIDUNG";
            this.nGUOIDUNGBindingSource.DataSource = this.qLyVVPDataSetAll;
            // 
            // qLyVVPDataSetAll
            // 
            this.qLyVVPDataSetAll.DataSetName = "QLyVVPDataSetAll";
            this.qLyVVPDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdngdung,
            this.colTenngdung,
            this.colChucvu,
            this.colTendn,
            this.colMatkhau});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Tìm kiếm....";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIdngdung
            // 
            this.colIdngdung.AppearanceCell.Options.UseTextOptions = true;
            this.colIdngdung.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdngdung.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colIdngdung.AppearanceHeader.Options.UseFont = true;
            this.colIdngdung.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdngdung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdngdung.Caption = "Mã người dùng";
            this.colIdngdung.FieldName = "Idngdung";
            this.colIdngdung.Name = "colIdngdung";
            this.colIdngdung.Visible = true;
            this.colIdngdung.VisibleIndex = 0;
            this.colIdngdung.Width = 167;
            // 
            // colTenngdung
            // 
            this.colTenngdung.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenngdung.AppearanceHeader.Options.UseFont = true;
            this.colTenngdung.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenngdung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenngdung.Caption = "Tên người dùng";
            this.colTenngdung.FieldName = "Tenngdung";
            this.colTenngdung.Name = "colTenngdung";
            this.colTenngdung.Visible = true;
            this.colTenngdung.VisibleIndex = 1;
            this.colTenngdung.Width = 238;
            // 
            // colChucvu
            // 
            this.colChucvu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colChucvu.AppearanceHeader.Options.UseFont = true;
            this.colChucvu.AppearanceHeader.Options.UseTextOptions = true;
            this.colChucvu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChucvu.Caption = "Chức vụ";
            this.colChucvu.FieldName = "Chucvu";
            this.colChucvu.Name = "colChucvu";
            this.colChucvu.Visible = true;
            this.colChucvu.VisibleIndex = 2;
            this.colChucvu.Width = 182;
            // 
            // colTendn
            // 
            this.colTendn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTendn.AppearanceHeader.Options.UseFont = true;
            this.colTendn.AppearanceHeader.Options.UseTextOptions = true;
            this.colTendn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTendn.Caption = "Tên đăng nhập";
            this.colTendn.FieldName = "Tendn";
            this.colTendn.Name = "colTendn";
            this.colTendn.Visible = true;
            this.colTendn.VisibleIndex = 3;
            this.colTendn.Width = 222;
            // 
            // colMatkhau
            // 
            this.colMatkhau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMatkhau.AppearanceHeader.Options.UseFont = true;
            this.colMatkhau.AppearanceHeader.Options.UseTextOptions = true;
            this.colMatkhau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMatkhau.Caption = "Mật khẩu";
            this.colMatkhau.FieldName = "Matkhau";
            this.colMatkhau.Name = "colMatkhau";
            this.colMatkhau.Visible = true;
            this.colMatkhau.VisibleIndex = 4;
            this.colMatkhau.Width = 259;
            // 
            // nGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // NgDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 432);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NgDung";
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.NgDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTenngdung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTendn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtChucvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdngdung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLyVVPDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem BtnThem;
        private DevExpress.XtraBars.BarButtonItem BtnSua;
        private DevExpress.XtraBars.BarButtonItem BtnXoa;
        private DevExpress.XtraBars.BarButtonItem BtnCapnhat;
        private DevExpress.XtraBars.BarButtonItem BtnHuy;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private QLyVVPDataSetAll qLyVVPDataSetAll;
        private System.Windows.Forms.BindingSource nGUOIDUNGBindingSource;
        private QLyVVPDataSetAllTableAdapters.NGUOIDUNGTableAdapter nGUOIDUNGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdngdung;
        private DevExpress.XtraGrid.Columns.GridColumn colTenngdung;
        private DevExpress.XtraGrid.Columns.GridColumn colChucvu;
        private DevExpress.XtraGrid.Columns.GridColumn colTendn;
        private DevExpress.XtraGrid.Columns.GridColumn colMatkhau;
        private DevExpress.XtraEditors.TextEdit TxtMatkhau;
        private DevExpress.XtraEditors.TextEdit TxtTendn;
        private DevExpress.XtraEditors.TextEdit TxtChucvu;
        private DevExpress.XtraEditors.TextEdit TxtTenngdung;
        private DevExpress.XtraEditors.TextEdit TxtIdngdung;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}