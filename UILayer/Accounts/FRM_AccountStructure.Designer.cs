namespace UILayer.Accounts
{
    partial class FRM_AccountStructure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AccountStructure));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnModify = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.AccountStructureGrid = new DevExpress.XtraGrid.GridControl();
            this.AccountStructureView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.FinancialDeminsionGrid = new DevExpress.XtraGrid.GridControl();
            this.FinancialDeminsionView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FinDemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FinDemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFinDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAddSegment = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.FinancialCategory = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtStructureName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Account = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtStructureCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountStructureGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountStructureView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialDeminsionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialDeminsionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStructureName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Account.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStructureCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnAddNew,
            this.btnSave,
            this.btnModify,
            this.btnDelete});
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            // 
            // btnAddNew
            // 
            resources.ApplyResources(this.btnAddNew, "btnAddNew");
            this.btnAddNew.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Glyph")));
            this.btnAddNew.Id = 1;
            this.btnAddNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddNew.LargeGlyph")));
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNew_ItemClick);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Enabled = false;
            this.btnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSave.Glyph")));
            this.btnSave.Id = 2;
            this.btnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSave.LargeGlyph")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnModify
            // 
            resources.ApplyResources(this.btnModify, "btnModify");
            this.btnModify.Enabled = false;
            this.btnModify.Glyph = ((System.Drawing.Image)(resources.GetObject("btnModify.Glyph")));
            this.btnModify.Id = 3;
            this.btnModify.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnModify.LargeGlyph")));
            this.btnModify.Name = "btnModify";
            this.btnModify.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Enabled = false;
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.Id = 4;
            this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnModify, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Name = "panelControl1";
            // 
            // panelControl3
            // 
            resources.ApplyResources(this.panelControl3, "panelControl3");
            this.panelControl3.Controls.Add(this.AccountStructureGrid);
            this.panelControl3.Name = "panelControl3";
            // 
            // AccountStructureGrid
            // 
            resources.ApplyResources(this.AccountStructureGrid, "AccountStructureGrid");
            this.AccountStructureGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("AccountStructureGrid.EmbeddedNavigator.AccessibleDescription");
            this.AccountStructureGrid.EmbeddedNavigator.AccessibleName = resources.GetString("AccountStructureGrid.EmbeddedNavigator.AccessibleName");
            this.AccountStructureGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("AccountStructureGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.AccountStructureGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("AccountStructureGrid.EmbeddedNavigator.Anchor")));
            this.AccountStructureGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AccountStructureGrid.EmbeddedNavigator.BackgroundImage")));
            this.AccountStructureGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("AccountStructureGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.AccountStructureGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("AccountStructureGrid.EmbeddedNavigator.ImeMode")));
            this.AccountStructureGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("AccountStructureGrid.EmbeddedNavigator.MaximumSize")));
            this.AccountStructureGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("AccountStructureGrid.EmbeddedNavigator.TextLocation")));
            this.AccountStructureGrid.EmbeddedNavigator.ToolTip = resources.GetString("AccountStructureGrid.EmbeddedNavigator.ToolTip");
            this.AccountStructureGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("AccountStructureGrid.EmbeddedNavigator.ToolTipIconType")));
            this.AccountStructureGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("AccountStructureGrid.EmbeddedNavigator.ToolTipTitle");
            this.AccountStructureGrid.MainView = this.AccountStructureView;
            this.AccountStructureGrid.Name = "AccountStructureGrid";
            this.AccountStructureGrid.UseEmbeddedNavigator = true;
            this.AccountStructureGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.AccountStructureView});
            // 
            // AccountStructureView
            // 
            this.AccountStructureView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.AccountStructureView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.AccountStructureView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.ColumnFilterButton.GradientMode")));
            this.AccountStructureView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.ColumnFilterButton.Image")));
            this.AccountStructureView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.FocusedCell.FontSizeDelta")));
            this.AccountStructureView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.FocusedCell.FontStyleDelta")));
            this.AccountStructureView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.FocusedCell.GradientMode")));
            this.AccountStructureView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.FocusedCell.Image")));
            this.AccountStructureView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.FocusedRow.FontSizeDelta")));
            this.AccountStructureView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.FocusedRow.FontStyleDelta")));
            this.AccountStructureView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.FocusedRow.GradientMode")));
            this.AccountStructureView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.FocusedRow.Image")));
            this.AccountStructureView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.HeaderPanel.FontSizeDelta")));
            this.AccountStructureView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.HeaderPanel.FontStyleDelta")));
            this.AccountStructureView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.HeaderPanel.GradientMode")));
            this.AccountStructureView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.HeaderPanel.Image")));
            this.AccountStructureView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.HorzLine.FontSizeDelta")));
            this.AccountStructureView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.HorzLine.FontStyleDelta")));
            this.AccountStructureView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.HorzLine.GradientMode")));
            this.AccountStructureView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.HorzLine.Image")));
            this.AccountStructureView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.OddRow.FontSizeDelta")));
            this.AccountStructureView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.OddRow.FontStyleDelta")));
            this.AccountStructureView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.OddRow.GradientMode")));
            this.AccountStructureView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.OddRow.Image")));
            this.AccountStructureView.Appearance.OddRow.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.Preview.FontSizeDelta")));
            this.AccountStructureView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.Preview.FontStyleDelta")));
            this.AccountStructureView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.Preview.GradientMode")));
            this.AccountStructureView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.Preview.Image")));
            this.AccountStructureView.Appearance.Preview.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.Row.FontSizeDelta")));
            this.AccountStructureView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.Row.FontStyleDelta")));
            this.AccountStructureView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.Row.GradientMode")));
            this.AccountStructureView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.Row.Image")));
            this.AccountStructureView.Appearance.Row.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.SelectedRow.FontSizeDelta")));
            this.AccountStructureView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.SelectedRow.FontStyleDelta")));
            this.AccountStructureView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.SelectedRow.GradientMode")));
            this.AccountStructureView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.SelectedRow.Image")));
            this.AccountStructureView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.TopNewRow.FontSizeDelta")));
            this.AccountStructureView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.TopNewRow.FontStyleDelta")));
            this.AccountStructureView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.TopNewRow.GradientMode")));
            this.AccountStructureView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.TopNewRow.Image")));
            this.AccountStructureView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.VertLine.FontSizeDelta")));
            this.AccountStructureView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.VertLine.FontStyleDelta")));
            this.AccountStructureView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.VertLine.GradientMode")));
            this.AccountStructureView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.VertLine.Image")));
            this.AccountStructureView.Appearance.VertLine.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("AccountStructureView.Appearance.ViewCaption.FontSizeDelta")));
            this.AccountStructureView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccountStructureView.Appearance.ViewCaption.FontStyleDelta")));
            this.AccountStructureView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccountStructureView.Appearance.ViewCaption.GradientMode")));
            this.AccountStructureView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("AccountStructureView.Appearance.ViewCaption.Image")));
            this.AccountStructureView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.AccountStructureView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountStructureView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountStructureView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AccountStructureView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.AccountStructureView, "AccountStructureView");
            this.AccountStructureView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.AccountStructureView.GridControl = this.AccountStructureGrid;
            this.AccountStructureView.Name = "AccountStructureView";
            this.AccountStructureView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.AccountStructureView.OptionsBehavior.Editable = false;
            this.AccountStructureView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.AccountStructureView.OptionsPrint.EnableAppearanceOddRow = true;
            this.AccountStructureView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.AccountStructureView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.AccountStructureView.OptionsView.EnableAppearanceEvenRow = true;
            this.AccountStructureView.OptionsView.EnableAppearanceOddRow = true;
            this.AccountStructureView.OptionsView.RowAutoHeight = true;
            this.AccountStructureView.OptionsView.ShowAutoFilterRow = true;
            this.AccountStructureView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.AccountStructureView.OptionsView.ShowGroupedColumns = true;
            this.AccountStructureView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.AccountStructureView_RowClick);
            this.AccountStructureView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.AccountStructureView_FocusedRowChanged);
            this.AccountStructureView.RowCountChanged += new System.EventHandler(this.AccountStructureView_RowCountChanged);
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.txtStructureName);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.Account);
            this.panelControl2.Controls.Add(this.txtStructureCode);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Name = "panelControl2";
            // 
            // groupControl1
            // 
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Controls.Add(this.FinancialDeminsionGrid);
            this.groupControl1.Controls.Add(this.btnAddSegment);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.FinancialCategory);
            this.groupControl1.Name = "groupControl1";
            // 
            // FinancialDeminsionGrid
            // 
            resources.ApplyResources(this.FinancialDeminsionGrid, "FinancialDeminsionGrid");
            this.FinancialDeminsionGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("FinancialDeminsionGrid.EmbeddedNavigator.AccessibleDescription");
            this.FinancialDeminsionGrid.EmbeddedNavigator.AccessibleName = resources.GetString("FinancialDeminsionGrid.EmbeddedNavigator.AccessibleName");
            this.FinancialDeminsionGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("FinancialDeminsionGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.FinancialDeminsionGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("FinancialDeminsionGrid.EmbeddedNavigator.Anchor")));
            this.FinancialDeminsionGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FinancialDeminsionGrid.EmbeddedNavigator.BackgroundImage")));
            this.FinancialDeminsionGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("FinancialDeminsionGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.FinancialDeminsionGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("FinancialDeminsionGrid.EmbeddedNavigator.ImeMode")));
            this.FinancialDeminsionGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("FinancialDeminsionGrid.EmbeddedNavigator.MaximumSize")));
            this.FinancialDeminsionGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("FinancialDeminsionGrid.EmbeddedNavigator.TextLocation")));
            this.FinancialDeminsionGrid.EmbeddedNavigator.ToolTip = resources.GetString("FinancialDeminsionGrid.EmbeddedNavigator.ToolTip");
            this.FinancialDeminsionGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("FinancialDeminsionGrid.EmbeddedNavigator.ToolTipIconType")));
            this.FinancialDeminsionGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("FinancialDeminsionGrid.EmbeddedNavigator.ToolTipTitle");
            this.FinancialDeminsionGrid.MainView = this.FinancialDeminsionView;
            this.FinancialDeminsionGrid.MenuManager = this.ribbon;
            this.FinancialDeminsionGrid.Name = "FinancialDeminsionGrid";
            this.FinancialDeminsionGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnFinDelete});
            this.FinancialDeminsionGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.FinancialDeminsionView});
            // 
            // FinancialDeminsionView
            // 
            resources.ApplyResources(this.FinancialDeminsionView, "FinancialDeminsionView");
            this.FinancialDeminsionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FinDemCode,
            this.FinDemName,
            this.gridColumn3});
            this.FinancialDeminsionView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.FinancialDeminsionView.GridControl = this.FinancialDeminsionGrid;
            this.FinancialDeminsionView.Name = "FinancialDeminsionView";
            this.FinancialDeminsionView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.FinancialDeminsionView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.FinancialDeminsionView.OptionsFilter.AllowFilterEditor = false;
            this.FinancialDeminsionView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.FinancialDeminsionView.OptionsView.EnableAppearanceEvenRow = true;
            this.FinancialDeminsionView.OptionsView.EnableAppearanceOddRow = true;
            this.FinancialDeminsionView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.FinancialDeminsionView.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.FinancialDeminsionView.OptionsView.ShowDetailButtons = false;
            this.FinancialDeminsionView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.FinancialDeminsionView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.FinancialDeminsionView.OptionsView.ShowGroupPanel = false;
            // 
            // FinDemCode
            // 
            this.FinDemCode.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("FinDemCode.AppearanceCell.FontSizeDelta")));
            this.FinDemCode.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("FinDemCode.AppearanceCell.FontStyleDelta")));
            this.FinDemCode.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("FinDemCode.AppearanceCell.GradientMode")));
            this.FinDemCode.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("FinDemCode.AppearanceCell.Image")));
            this.FinDemCode.AppearanceCell.Options.UseTextOptions = true;
            this.FinDemCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FinDemCode.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("FinDemCode.AppearanceHeader.FontSizeDelta")));
            this.FinDemCode.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("FinDemCode.AppearanceHeader.FontStyleDelta")));
            this.FinDemCode.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("FinDemCode.AppearanceHeader.GradientMode")));
            this.FinDemCode.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("FinDemCode.AppearanceHeader.Image")));
            this.FinDemCode.AppearanceHeader.Options.UseTextOptions = true;
            this.FinDemCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.FinDemCode, "FinDemCode");
            this.FinDemCode.FieldName = "DemCode";
            this.FinDemCode.Name = "FinDemCode";
            this.FinDemCode.OptionsColumn.AllowEdit = false;
            this.FinDemCode.OptionsColumn.AllowFocus = false;
            this.FinDemCode.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.FinDemCode.OptionsColumn.AllowMove = false;
            this.FinDemCode.OptionsColumn.AllowShowHide = false;
            this.FinDemCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.FinDemCode.OptionsColumn.FixedWidth = true;
            this.FinDemCode.OptionsColumn.ShowInCustomizationForm = false;
            this.FinDemCode.OptionsColumn.ShowInExpressionEditor = false;
            this.FinDemCode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // FinDemName
            // 
            this.FinDemName.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("FinDemName.AppearanceCell.FontSizeDelta")));
            this.FinDemName.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("FinDemName.AppearanceCell.FontStyleDelta")));
            this.FinDemName.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("FinDemName.AppearanceCell.GradientMode")));
            this.FinDemName.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("FinDemName.AppearanceCell.Image")));
            this.FinDemName.AppearanceCell.Options.UseTextOptions = true;
            this.FinDemName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FinDemName.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("FinDemName.AppearanceHeader.FontSizeDelta")));
            this.FinDemName.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("FinDemName.AppearanceHeader.FontStyleDelta")));
            this.FinDemName.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("FinDemName.AppearanceHeader.GradientMode")));
            this.FinDemName.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("FinDemName.AppearanceHeader.Image")));
            this.FinDemName.AppearanceHeader.Options.UseTextOptions = true;
            this.FinDemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.FinDemName, "FinDemName");
            this.FinDemName.FieldName = "DemName";
            this.FinDemName.Name = "FinDemName";
            this.FinDemName.OptionsColumn.AllowEdit = false;
            this.FinDemName.OptionsColumn.AllowFocus = false;
            this.FinDemName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.FinDemName.OptionsColumn.AllowMove = false;
            this.FinDemName.OptionsColumn.ShowInCustomizationForm = false;
            this.FinDemName.OptionsColumn.ShowInExpressionEditor = false;
            this.FinDemName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("gridColumn3.AppearanceCell.FontSizeDelta")));
            this.gridColumn3.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("gridColumn3.AppearanceCell.FontStyleDelta")));
            this.gridColumn3.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("gridColumn3.AppearanceCell.GradientMode")));
            this.gridColumn3.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn3.AppearanceCell.Image")));
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("gridColumn3.AppearanceHeader.FontSizeDelta")));
            this.gridColumn3.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("gridColumn3.AppearanceHeader.FontStyleDelta")));
            this.gridColumn3.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("gridColumn3.AppearanceHeader.GradientMode")));
            this.gridColumn3.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn3.AppearanceHeader.Image")));
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.gridColumn3, "gridColumn3");
            this.gridColumn3.ColumnEdit = this.btnFinDelete;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // btnFinDelete
            // 
            resources.ApplyResources(this.btnFinDelete, "btnFinDelete");
            resources.ApplyResources(serializableAppearanceObject1, "serializableAppearanceObject1");
            this.btnFinDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("btnFinDelete.Buttons"))), resources.GetString("btnFinDelete.Buttons1"), ((int)(resources.GetObject("btnFinDelete.Buttons2"))), ((bool)(resources.GetObject("btnFinDelete.Buttons3"))), ((bool)(resources.GetObject("btnFinDelete.Buttons4"))), ((bool)(resources.GetObject("btnFinDelete.Buttons5"))), ((DevExpress.XtraEditors.ImageLocation)(resources.GetObject("btnFinDelete.Buttons6"))), ((System.Drawing.Image)(resources.GetObject("btnFinDelete.Buttons7"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, resources.GetString("btnFinDelete.Buttons8"), ((object)(resources.GetObject("btnFinDelete.Buttons9"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("btnFinDelete.Buttons10"))), ((bool)(resources.GetObject("btnFinDelete.Buttons11"))))});
            this.btnFinDelete.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("btnFinDelete.Mask.AutoComplete")));
            this.btnFinDelete.Mask.BeepOnError = ((bool)(resources.GetObject("btnFinDelete.Mask.BeepOnError")));
            this.btnFinDelete.Mask.EditMask = resources.GetString("btnFinDelete.Mask.EditMask");
            this.btnFinDelete.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("btnFinDelete.Mask.IgnoreMaskBlank")));
            this.btnFinDelete.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("btnFinDelete.Mask.MaskType")));
            this.btnFinDelete.Mask.PlaceHolder = ((char)(resources.GetObject("btnFinDelete.Mask.PlaceHolder")));
            this.btnFinDelete.Mask.SaveLiteral = ((bool)(resources.GetObject("btnFinDelete.Mask.SaveLiteral")));
            this.btnFinDelete.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("btnFinDelete.Mask.ShowPlaceHolders")));
            this.btnFinDelete.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("btnFinDelete.Mask.UseMaskAsDisplayFormat")));
            this.btnFinDelete.Name = "btnFinDelete";
            this.btnFinDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnFinDelete.Click += new System.EventHandler(this.btnFinDelete_Click);
            // 
            // btnAddSegment
            // 
            resources.ApplyResources(this.btnAddSegment, "btnAddSegment");
            this.btnAddSegment.Name = "btnAddSegment";
            this.btnAddSegment.Click += new System.EventHandler(this.btnAddSegment_Click);
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // FinancialCategory
            // 
            resources.ApplyResources(this.FinancialCategory, "FinancialCategory");
            this.FinancialCategory.MenuManager = this.ribbon;
            this.FinancialCategory.Name = "FinancialCategory";
            this.FinancialCategory.Properties.AccessibleDescription = resources.GetString("FinancialCategory.Properties.AccessibleDescription");
            this.FinancialCategory.Properties.AccessibleName = resources.GetString("FinancialCategory.Properties.AccessibleName");
            this.FinancialCategory.Properties.AutoHeight = ((bool)(resources.GetObject("FinancialCategory.Properties.AutoHeight")));
            this.FinancialCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("FinancialCategory.Properties.Buttons"))))});
            this.FinancialCategory.Properties.NullText = resources.GetString("FinancialCategory.Properties.NullText");
            this.FinancialCategory.Properties.NullValuePrompt = resources.GetString("FinancialCategory.Properties.NullValuePrompt");
            this.FinancialCategory.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("FinancialCategory.Properties.NullValuePromptShowForEmptyValue")));
            this.FinancialCategory.Properties.View = this.gridView1;
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // txtStructureName
            // 
            resources.ApplyResources(this.txtStructureName, "txtStructureName");
            this.txtStructureName.MenuManager = this.ribbon;
            this.txtStructureName.Name = "txtStructureName";
            this.txtStructureName.Properties.AccessibleDescription = resources.GetString("txtStructureName.Properties.AccessibleDescription");
            this.txtStructureName.Properties.AccessibleName = resources.GetString("txtStructureName.Properties.AccessibleName");
            this.txtStructureName.Properties.AutoHeight = ((bool)(resources.GetObject("txtStructureName.Properties.AutoHeight")));
            this.txtStructureName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtStructureName.Properties.Mask.AutoComplete")));
            this.txtStructureName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtStructureName.Properties.Mask.BeepOnError")));
            this.txtStructureName.Properties.Mask.EditMask = resources.GetString("txtStructureName.Properties.Mask.EditMask");
            this.txtStructureName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtStructureName.Properties.Mask.IgnoreMaskBlank")));
            this.txtStructureName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtStructureName.Properties.Mask.MaskType")));
            this.txtStructureName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtStructureName.Properties.Mask.PlaceHolder")));
            this.txtStructureName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtStructureName.Properties.Mask.SaveLiteral")));
            this.txtStructureName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtStructureName.Properties.Mask.ShowPlaceHolders")));
            this.txtStructureName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtStructureName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtStructureName.Properties.NullValuePrompt = resources.GetString("txtStructureName.Properties.NullValuePrompt");
            this.txtStructureName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtStructureName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // Account
            // 
            resources.ApplyResources(this.Account, "Account");
            this.Account.MenuManager = this.ribbon;
            this.Account.Name = "Account";
            this.Account.Properties.AccessibleDescription = resources.GetString("Account.Properties.AccessibleDescription");
            this.Account.Properties.AccessibleName = resources.GetString("Account.Properties.AccessibleName");
            this.Account.Properties.AutoHeight = ((bool)(resources.GetObject("Account.Properties.AutoHeight")));
            this.Account.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("Account.Properties.Buttons"))))});
            this.Account.Properties.NullText = resources.GetString("Account.Properties.NullText");
            this.Account.Properties.NullValuePrompt = resources.GetString("Account.Properties.NullValuePrompt");
            this.Account.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("Account.Properties.NullValuePromptShowForEmptyValue")));
            this.Account.Properties.View = this.searchLookUpEdit1View;
            // 
            // searchLookUpEdit1View
            // 
            resources.ApplyResources(this.searchLookUpEdit1View, "searchLookUpEdit1View");
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtStructureCode
            // 
            resources.ApplyResources(this.txtStructureCode, "txtStructureCode");
            this.txtStructureCode.MenuManager = this.ribbon;
            this.txtStructureCode.Name = "txtStructureCode";
            this.txtStructureCode.Properties.AccessibleDescription = resources.GetString("txtStructureCode.Properties.AccessibleDescription");
            this.txtStructureCode.Properties.AccessibleName = resources.GetString("txtStructureCode.Properties.AccessibleName");
            this.txtStructureCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtStructureCode.Properties.AutoHeight")));
            this.txtStructureCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtStructureCode.Properties.Mask.AutoComplete")));
            this.txtStructureCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtStructureCode.Properties.Mask.BeepOnError")));
            this.txtStructureCode.Properties.Mask.EditMask = resources.GetString("txtStructureCode.Properties.Mask.EditMask");
            this.txtStructureCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtStructureCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtStructureCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtStructureCode.Properties.Mask.MaskType")));
            this.txtStructureCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtStructureCode.Properties.Mask.PlaceHolder")));
            this.txtStructureCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtStructureCode.Properties.Mask.SaveLiteral")));
            this.txtStructureCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtStructureCode.Properties.Mask.ShowPlaceHolders")));
            this.txtStructureCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtStructureCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtStructureCode.Properties.NullValuePrompt = resources.GetString("txtStructureCode.Properties.NullValuePrompt");
            this.txtStructureCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtStructureCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // FRM_AccountStructure
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "FRM_AccountStructure";
            this.Ribbon = this.ribbon;
            this.Load += new System.EventHandler(this.FRM_AccountStructure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountStructureGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountStructureView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialDeminsionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialDeminsionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStructureName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Account.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStructureCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnModify;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl FinancialDeminsionGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView FinancialDeminsionView;
        private DevExpress.XtraGrid.Columns.GridColumn FinDemCode;
        private DevExpress.XtraGrid.Columns.GridColumn FinDemName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnFinDelete;
        private DevExpress.XtraEditors.SimpleButton btnAddSegment;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit FinancialCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtStructureName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit Account;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtStructureCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl AccountStructureGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView AccountStructureView;
    }
}