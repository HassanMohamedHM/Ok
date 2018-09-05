namespace UILayer.WareHouses
{
    partial class FRM_BOMLines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BOMLines));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnValidate = new DevExpress.XtraBars.BarButtonItem();
            this.btnPost = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.LinesGrid = new DevExpress.XtraGrid.GridControl();
            this.LinesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repProduct = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Product_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WareHouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repWareHouse = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCost = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repWareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.btnValidate,
            this.btnPost,
            this.btnPrint});
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNew.Glyph")));
            this.btnNew.Id = 1;
            this.btnNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNew.LargeGlyph")));
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.Id = 2;
            this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnValidate
            // 
            resources.ApplyResources(this.btnValidate, "btnValidate");
            this.btnValidate.Enabled = false;
            this.btnValidate.Glyph = ((System.Drawing.Image)(resources.GetObject("btnValidate.Glyph")));
            this.btnValidate.Id = 4;
            this.btnValidate.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnValidate.LargeGlyph")));
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnValidate_ItemClick);
            // 
            // btnPost
            // 
            resources.ApplyResources(this.btnPost, "btnPost");
            this.btnPost.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPost.Glyph")));
            this.btnPost.Id = 5;
            this.btnPost.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPost.LargeGlyph")));
            this.btnPost.Name = "btnPost";
            this.btnPost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPost_ItemClick);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Enabled = false;
            this.btnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.Glyph")));
            this.btnPrint.Id = 6;
            this.btnPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.LargeGlyph")));
            this.btnPrint.Name = "btnPrint";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            resources.ApplyResources(this.ribbonPage2, "ribbonPage2");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDelete, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnValidate, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPost, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPrint, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.LinesGrid);
            this.panelControl1.Name = "panelControl1";
            // 
            // LinesGrid
            // 
            resources.ApplyResources(this.LinesGrid, "LinesGrid");
            this.LinesGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("LinesGrid.EmbeddedNavigator.AccessibleDescription");
            this.LinesGrid.EmbeddedNavigator.AccessibleName = resources.GetString("LinesGrid.EmbeddedNavigator.AccessibleName");
            this.LinesGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("LinesGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.LinesGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("LinesGrid.EmbeddedNavigator.Anchor")));
            this.LinesGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LinesGrid.EmbeddedNavigator.BackgroundImage")));
            this.LinesGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("LinesGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.LinesGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("LinesGrid.EmbeddedNavigator.ImeMode")));
            this.LinesGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("LinesGrid.EmbeddedNavigator.MaximumSize")));
            this.LinesGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("LinesGrid.EmbeddedNavigator.TextLocation")));
            this.LinesGrid.EmbeddedNavigator.ToolTip = resources.GetString("LinesGrid.EmbeddedNavigator.ToolTip");
            this.LinesGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("LinesGrid.EmbeddedNavigator.ToolTipIconType")));
            this.LinesGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("LinesGrid.EmbeddedNavigator.ToolTipTitle");
            this.LinesGrid.MainView = this.LinesView;
            this.LinesGrid.Name = "LinesGrid";
            this.LinesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDate,
            this.repProduct,
            this.repCost,
            this.repQuantity,
            this.repWareHouse});
            this.LinesGrid.UseEmbeddedNavigator = true;
            this.LinesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LinesView});
            // 
            // LinesView
            // 
            resources.ApplyResources(this.LinesView, "LinesView");
            this.LinesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Code,
            this.Product,
            this.Product_Name,
            this.WareHouse,
            this.Cost,
            this.Quantity,
            this.Total});
            this.LinesView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.LinesView.GridControl = this.LinesGrid;
            this.LinesView.Name = "LinesView";
            this.LinesView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.LinesView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.LinesView.OptionsBehavior.FocusLeaveOnTab = true;
            this.LinesView.OptionsNavigation.AutoFocusNewRow = true;
            this.LinesView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.LinesView.OptionsPrint.EnableAppearanceOddRow = true;
            this.LinesView.OptionsPrint.PrintFilterInfo = true;
            this.LinesView.OptionsView.EnableAppearanceEvenRow = true;
            this.LinesView.OptionsView.EnableAppearanceOddRow = true;
            this.LinesView.OptionsView.ShowAutoFilterRow = true;
            this.LinesView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.LinesView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.LinesView_RowCellClick);
            this.LinesView.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.LinesView_CustomRowCellEdit);
            this.LinesView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.LinesView_InitNewRow);
            this.LinesView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.LinesView_CellValueChanged);
            this.LinesView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LinesView_KeyDown);
            // 
            // Code
            // 
            this.Code.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("Code.AppearanceCell.FontSizeDelta")));
            this.Code.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Code.AppearanceCell.FontStyleDelta")));
            this.Code.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Code.AppearanceCell.GradientMode")));
            this.Code.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("Code.AppearanceCell.Image")));
            this.Code.AppearanceCell.Options.UseTextOptions = true;
            this.Code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Code.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Code.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("Code.AppearanceHeader.FontSizeDelta")));
            this.Code.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Code.AppearanceHeader.FontStyleDelta")));
            this.Code.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Code.AppearanceHeader.GradientMode")));
            this.Code.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("Code.AppearanceHeader.Image")));
            this.Code.AppearanceHeader.Options.UseTextOptions = true;
            this.Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Code.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Code, "Code");
            this.Code.FieldName = "v1";
            this.Code.Name = "Code";
            this.Code.OptionsColumn.AllowEdit = false;
            this.Code.OptionsColumn.FixedWidth = true;
            this.Code.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.True;
            this.Code.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // Product
            // 
            this.Product.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("Product.AppearanceCell.FontSizeDelta")));
            this.Product.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Product.AppearanceCell.FontStyleDelta")));
            this.Product.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Product.AppearanceCell.GradientMode")));
            this.Product.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("Product.AppearanceCell.Image")));
            this.Product.AppearanceCell.Options.UseTextOptions = true;
            this.Product.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Product.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Product.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("Product.AppearanceHeader.FontSizeDelta")));
            this.Product.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Product.AppearanceHeader.FontStyleDelta")));
            this.Product.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Product.AppearanceHeader.GradientMode")));
            this.Product.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("Product.AppearanceHeader.Image")));
            this.Product.AppearanceHeader.Options.UseTextOptions = true;
            this.Product.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Product.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Product, "Product");
            this.Product.ColumnEdit = this.repProduct;
            this.Product.FieldName = "v2";
            this.Product.Name = "Product";
            this.Product.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.True;
            this.Product.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // repProduct
            // 
            resources.ApplyResources(this.repProduct, "repProduct");
            this.repProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repProduct.Buttons"))))});
            this.repProduct.Name = "repProduct";
            this.repProduct.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            resources.ApplyResources(this.repositoryItemSearchLookUpEdit1View, "repositoryItemSearchLookUpEdit1View");
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemSearchLookUpEdit1View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemSearchLookUpEdit1View.OptionsBehavior.Editable = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.EnableAppearanceOddRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ProductName
            // 
            this.Product_Name.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("ProductName.AppearanceCell.FontSizeDelta")));
            this.Product_Name.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("ProductName.AppearanceCell.FontStyleDelta")));
            this.Product_Name.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("ProductName.AppearanceCell.GradientMode")));
            this.Product_Name.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("ProductName.AppearanceCell.Image")));
            this.Product_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Product_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Product_Name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Product_Name.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("ProductName.AppearanceHeader.FontSizeDelta")));
            this.Product_Name.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("ProductName.AppearanceHeader.FontStyleDelta")));
            this.Product_Name.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("ProductName.AppearanceHeader.GradientMode")));
            this.Product_Name.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("ProductName.AppearanceHeader.Image")));
            this.Product_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Product_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Product_Name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Product_Name, "ProductName");
            this.Product_Name.FieldName = "v7";
            this.Product_Name.Name = "ProductName";
            this.Product_Name.OptionsColumn.AllowEdit = false;
            this.Product_Name.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // WareHouse
            // 
            this.WareHouse.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("WareHouse.AppearanceCell.FontSizeDelta")));
            this.WareHouse.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouse.AppearanceCell.FontStyleDelta")));
            this.WareHouse.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouse.AppearanceCell.GradientMode")));
            this.WareHouse.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("WareHouse.AppearanceCell.Image")));
            this.WareHouse.AppearanceCell.Options.UseTextOptions = true;
            this.WareHouse.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouse.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouse.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("WareHouse.AppearanceHeader.FontSizeDelta")));
            this.WareHouse.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouse.AppearanceHeader.FontStyleDelta")));
            this.WareHouse.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouse.AppearanceHeader.GradientMode")));
            this.WareHouse.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("WareHouse.AppearanceHeader.Image")));
            this.WareHouse.AppearanceHeader.Options.UseTextOptions = true;
            this.WareHouse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouse.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.WareHouse, "WareHouse");
            this.WareHouse.ColumnEdit = this.repWareHouse;
            this.WareHouse.FieldName = "v3";
            this.WareHouse.Name = "WareHouse";
            this.WareHouse.OptionsColumn.FixedWidth = true;
            this.WareHouse.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.True;
            this.WareHouse.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // repWareHouse
            // 
            resources.ApplyResources(this.repWareHouse, "repWareHouse");
            this.repWareHouse.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repWareHouse.Buttons"))))});
            this.repWareHouse.Name = "repWareHouse";
            this.repWareHouse.View = this.bandedGridView1;
            this.repWareHouse.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.BandedView;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            resources.ApplyResources(this.bandedGridView1, "bandedGridView1");
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3});
            this.bandedGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("gridBand1.AppearanceHeader.FontSizeDelta")));
            this.gridBand1.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("gridBand1.AppearanceHeader.FontStyleDelta")));
            this.gridBand1.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("gridBand1.AppearanceHeader.GradientMode")));
            this.gridBand1.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("gridBand1.AppearanceHeader.Image")));
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.gridBand1, "gridBand1");
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.VisibleIndex = 0;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn2.AppearanceCell.FontSizeDelta")));
            this.bandedGridColumn2.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn2.AppearanceCell.FontStyleDelta")));
            this.bandedGridColumn2.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn2.AppearanceCell.GradientMode")));
            this.bandedGridColumn2.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn2.AppearanceCell.Image")));
            this.bandedGridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumn2.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn2.AppearanceHeader.FontSizeDelta")));
            this.bandedGridColumn2.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn2.AppearanceHeader.FontStyleDelta")));
            this.bandedGridColumn2.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn2.AppearanceHeader.GradientMode")));
            this.bandedGridColumn2.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn2.AppearanceHeader.Image")));
            this.bandedGridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.bandedGridColumn2, "bandedGridColumn2");
            this.bandedGridColumn2.FieldName = "v2";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn1.AppearanceCell.FontSizeDelta")));
            this.bandedGridColumn1.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn1.AppearanceCell.FontStyleDelta")));
            this.bandedGridColumn1.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn1.AppearanceCell.GradientMode")));
            this.bandedGridColumn1.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn1.AppearanceCell.Image")));
            this.bandedGridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumn1.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn1.AppearanceHeader.FontSizeDelta")));
            this.bandedGridColumn1.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn1.AppearanceHeader.FontStyleDelta")));
            this.bandedGridColumn1.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn1.AppearanceHeader.GradientMode")));
            this.bandedGridColumn1.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn1.AppearanceHeader.Image")));
            this.bandedGridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.bandedGridColumn1, "bandedGridColumn1");
            this.bandedGridColumn1.FieldName = "v1";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("gridBand2.AppearanceHeader.FontSizeDelta")));
            this.gridBand2.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("gridBand2.AppearanceHeader.FontStyleDelta")));
            this.gridBand2.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("gridBand2.AppearanceHeader.GradientMode")));
            this.gridBand2.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("gridBand2.AppearanceHeader.Image")));
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.gridBand2, "gridBand2");
            this.gridBand2.Columns.Add(this.bandedGridColumn3);
            this.gridBand2.VisibleIndex = 1;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn3.AppearanceCell.FontSizeDelta")));
            this.bandedGridColumn3.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn3.AppearanceCell.FontStyleDelta")));
            this.bandedGridColumn3.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn3.AppearanceCell.GradientMode")));
            this.bandedGridColumn3.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn3.AppearanceCell.Image")));
            this.bandedGridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumn3.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn3.AppearanceHeader.FontSizeDelta")));
            this.bandedGridColumn3.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn3.AppearanceHeader.FontStyleDelta")));
            this.bandedGridColumn3.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn3.AppearanceHeader.GradientMode")));
            this.bandedGridColumn3.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn3.AppearanceHeader.Image")));
            this.bandedGridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.bandedGridColumn3, "bandedGridColumn3");
            this.bandedGridColumn3.FieldName = "v3";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // Cost
            // 
            this.Cost.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("Cost.AppearanceCell.FontSizeDelta")));
            this.Cost.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Cost.AppearanceCell.FontStyleDelta")));
            this.Cost.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Cost.AppearanceCell.GradientMode")));
            this.Cost.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("Cost.AppearanceCell.Image")));
            this.Cost.AppearanceCell.Options.UseTextOptions = true;
            this.Cost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cost.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Cost.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("Cost.AppearanceHeader.FontSizeDelta")));
            this.Cost.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Cost.AppearanceHeader.FontStyleDelta")));
            this.Cost.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Cost.AppearanceHeader.GradientMode")));
            this.Cost.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("Cost.AppearanceHeader.Image")));
            this.Cost.AppearanceHeader.Options.UseTextOptions = true;
            this.Cost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cost.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Cost, "Cost");
            this.Cost.ColumnEdit = this.repCost;
            this.Cost.FieldName = "v4";
            this.Cost.Name = "Cost";
            this.Cost.OptionsColumn.AllowEdit = false;
            this.Cost.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.True;
            this.Cost.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // repCost
            // 
            resources.ApplyResources(this.repCost, "repCost");
            this.repCost.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repCost.Buttons"))))});
            this.repCost.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repCost.Mask.AutoComplete")));
            this.repCost.Mask.BeepOnError = ((bool)(resources.GetObject("repCost.Mask.BeepOnError")));
            this.repCost.Mask.EditMask = resources.GetString("repCost.Mask.EditMask");
            this.repCost.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repCost.Mask.IgnoreMaskBlank")));
            this.repCost.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repCost.Mask.MaskType")));
            this.repCost.Mask.PlaceHolder = ((char)(resources.GetObject("repCost.Mask.PlaceHolder")));
            this.repCost.Mask.SaveLiteral = ((bool)(resources.GetObject("repCost.Mask.SaveLiteral")));
            this.repCost.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repCost.Mask.ShowPlaceHolders")));
            this.repCost.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repCost.Mask.UseMaskAsDisplayFormat")));
            this.repCost.Name = "repCost";
            // 
            // Quantity
            // 
            this.Quantity.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("Quantity.AppearanceCell.FontSizeDelta")));
            this.Quantity.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Quantity.AppearanceCell.FontStyleDelta")));
            this.Quantity.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Quantity.AppearanceCell.GradientMode")));
            this.Quantity.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("Quantity.AppearanceCell.Image")));
            this.Quantity.AppearanceCell.Options.UseTextOptions = true;
            this.Quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Quantity.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("Quantity.AppearanceHeader.FontSizeDelta")));
            this.Quantity.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Quantity.AppearanceHeader.FontStyleDelta")));
            this.Quantity.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Quantity.AppearanceHeader.GradientMode")));
            this.Quantity.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("Quantity.AppearanceHeader.Image")));
            this.Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Quantity, "Quantity");
            this.Quantity.ColumnEdit = this.repQuantity;
            this.Quantity.FieldName = "v5";
            this.Quantity.Name = "Quantity";
            this.Quantity.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.True;
            this.Quantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // repQuantity
            // 
            resources.ApplyResources(this.repQuantity, "repQuantity");
            this.repQuantity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repQuantity.Buttons"))))});
            this.repQuantity.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repQuantity.Mask.AutoComplete")));
            this.repQuantity.Mask.BeepOnError = ((bool)(resources.GetObject("repQuantity.Mask.BeepOnError")));
            this.repQuantity.Mask.EditMask = resources.GetString("repQuantity.Mask.EditMask");
            this.repQuantity.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repQuantity.Mask.IgnoreMaskBlank")));
            this.repQuantity.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repQuantity.Mask.MaskType")));
            this.repQuantity.Mask.PlaceHolder = ((char)(resources.GetObject("repQuantity.Mask.PlaceHolder")));
            this.repQuantity.Mask.SaveLiteral = ((bool)(resources.GetObject("repQuantity.Mask.SaveLiteral")));
            this.repQuantity.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repQuantity.Mask.ShowPlaceHolders")));
            this.repQuantity.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repQuantity.Mask.UseMaskAsDisplayFormat")));
            this.repQuantity.Name = "repQuantity";
            // 
            // Total
            // 
            this.Total.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("Total.AppearanceCell.FontSizeDelta")));
            this.Total.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Total.AppearanceCell.FontStyleDelta")));
            this.Total.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Total.AppearanceCell.GradientMode")));
            this.Total.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("Total.AppearanceCell.Image")));
            this.Total.AppearanceCell.Options.UseTextOptions = true;
            this.Total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Total.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("Total.AppearanceHeader.FontSizeDelta")));
            this.Total.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Total.AppearanceHeader.FontStyleDelta")));
            this.Total.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Total.AppearanceHeader.GradientMode")));
            this.Total.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("Total.AppearanceHeader.Image")));
            this.Total.AppearanceHeader.Options.UseTextOptions = true;
            this.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Total, "Total");
            this.Total.FieldName = "v6";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // repDate
            // 
            resources.ApplyResources(this.repDate, "repDate");
            this.repDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repDate.Buttons"))))});
            this.repDate.CalendarTimeProperties.AccessibleDescription = resources.GetString("repDate.CalendarTimeProperties.AccessibleDescription");
            this.repDate.CalendarTimeProperties.AccessibleName = resources.GetString("repDate.CalendarTimeProperties.AccessibleName");
            this.repDate.CalendarTimeProperties.AutoHeight = ((bool)(resources.GetObject("repDate.CalendarTimeProperties.AutoHeight")));
            this.repDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repDate.CalendarTimeProperties.Buttons"))))});
            this.repDate.CalendarTimeProperties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repDate.CalendarTimeProperties.Mask.AutoComplete")));
            this.repDate.CalendarTimeProperties.Mask.BeepOnError = ((bool)(resources.GetObject("repDate.CalendarTimeProperties.Mask.BeepOnError")));
            this.repDate.CalendarTimeProperties.Mask.EditMask = resources.GetString("repDate.CalendarTimeProperties.Mask.EditMask");
            this.repDate.CalendarTimeProperties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repDate.CalendarTimeProperties.Mask.IgnoreMaskBlank")));
            this.repDate.CalendarTimeProperties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repDate.CalendarTimeProperties.Mask.MaskType")));
            this.repDate.CalendarTimeProperties.Mask.PlaceHolder = ((char)(resources.GetObject("repDate.CalendarTimeProperties.Mask.PlaceHolder")));
            this.repDate.CalendarTimeProperties.Mask.SaveLiteral = ((bool)(resources.GetObject("repDate.CalendarTimeProperties.Mask.SaveLiteral")));
            this.repDate.CalendarTimeProperties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repDate.CalendarTimeProperties.Mask.ShowPlaceHolders")));
            this.repDate.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repDate.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat")));
            this.repDate.CalendarTimeProperties.NullValuePrompt = resources.GetString("repDate.CalendarTimeProperties.NullValuePrompt");
            this.repDate.CalendarTimeProperties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("repDate.CalendarTimeProperties.NullValuePromptShowForEmptyValue")));
            this.repDate.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.repDate.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repDate.Mask.AutoComplete")));
            this.repDate.Mask.BeepOnError = ((bool)(resources.GetObject("repDate.Mask.BeepOnError")));
            this.repDate.Mask.EditMask = resources.GetString("repDate.Mask.EditMask");
            this.repDate.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repDate.Mask.IgnoreMaskBlank")));
            this.repDate.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repDate.Mask.MaskType")));
            this.repDate.Mask.PlaceHolder = ((char)(resources.GetObject("repDate.Mask.PlaceHolder")));
            this.repDate.Mask.SaveLiteral = ((bool)(resources.GetObject("repDate.Mask.SaveLiteral")));
            this.repDate.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repDate.Mask.ShowPlaceHolders")));
            this.repDate.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repDate.Mask.UseMaskAsDisplayFormat")));
            this.repDate.Name = "repDate";
            this.repDate.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // FRM_BOMLines
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FRM_BOMLines";
            this.Ribbon = this.ribbonControl1;
            this.Load += new System.EventHandler(this.FRM_BOMJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LinesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repWareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnValidate;
        private DevExpress.XtraBars.BarButtonItem btnPost;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl LinesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView LinesView;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn WareHouse;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDate;
        private DevExpress.XtraGrid.Columns.GridColumn Product;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Cost;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repWareHouse;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Columns.GridColumn Product_Name;
    }
}