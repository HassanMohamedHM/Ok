namespace UILayer.WareHouses
{
    partial class FRM_BOMJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BOMJournal));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnLines = new DevExpress.XtraBars.BarButtonItem();
            this.btnValidate = new DevExpress.XtraBars.BarButtonItem();
            this.btnPost = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repJournal = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.HeaderGrid = new DevExpress.XtraGrid.GridControl();
            this.HeaderView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BOMDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Journal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Posted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OverViewPage = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.CmbGetGeneralJournals = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderView)).BeginInit();
            this.OverViewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbGetGeneralJournals.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            this.btnLines,
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
            // btnLines
            // 
            resources.ApplyResources(this.btnLines, "btnLines");
            this.btnLines.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLines.Glyph")));
            this.btnLines.Id = 3;
            this.btnLines.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLines.LargeGlyph")));
            this.btnLines.Name = "btnLines";
            this.btnLines.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLines_ItemClick);
            // 
            // btnValidate
            // 
            resources.ApplyResources(this.btnValidate, "btnValidate");
            this.btnValidate.Enabled = false;
            this.btnValidate.Glyph = ((System.Drawing.Image)(resources.GetObject("btnValidate.Glyph")));
            this.btnValidate.Id = 4;
            this.btnValidate.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnValidate.LargeGlyph")));
            this.btnValidate.Name = "btnValidate";
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
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLines, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnValidate, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPost, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPrint, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // repJournal
            // 
            resources.ApplyResources(this.repJournal, "repJournal");
            this.repJournal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repJournal.Buttons"))))});
            this.repJournal.Name = "repJournal";
            this.repJournal.View = this.repositoryItemSearchLookUpEdit1View;
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
            // HeaderGrid
            // 
            resources.ApplyResources(this.HeaderGrid, "HeaderGrid");
            this.HeaderGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("HeaderGrid.EmbeddedNavigator.AccessibleDescription");
            this.HeaderGrid.EmbeddedNavigator.AccessibleName = resources.GetString("HeaderGrid.EmbeddedNavigator.AccessibleName");
            this.HeaderGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("HeaderGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.HeaderGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("HeaderGrid.EmbeddedNavigator.Anchor")));
            this.HeaderGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeaderGrid.EmbeddedNavigator.BackgroundImage")));
            this.HeaderGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("HeaderGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.HeaderGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("HeaderGrid.EmbeddedNavigator.ImeMode")));
            this.HeaderGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("HeaderGrid.EmbeddedNavigator.MaximumSize")));
            this.HeaderGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("HeaderGrid.EmbeddedNavigator.TextLocation")));
            this.HeaderGrid.EmbeddedNavigator.ToolTip = resources.GetString("HeaderGrid.EmbeddedNavigator.ToolTip");
            this.HeaderGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("HeaderGrid.EmbeddedNavigator.ToolTipIconType")));
            this.HeaderGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("HeaderGrid.EmbeddedNavigator.ToolTipTitle");
            this.HeaderGrid.MainView = this.HeaderView;
            this.HeaderGrid.Name = "HeaderGrid";
            this.HeaderGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDate,
            this.repJournal});
            this.HeaderGrid.UseEmbeddedNavigator = true;
            this.HeaderGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HeaderView});
            // 
            // HeaderView
            // 
            resources.ApplyResources(this.HeaderView, "HeaderView");
            this.HeaderView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Code,
            this.BOMDate,
            this.Journal,
            this.Description,
            this.Posted});
            this.HeaderView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.HeaderView.GridControl = this.HeaderGrid;
            this.HeaderView.Name = "HeaderView";
            this.HeaderView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.HeaderView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.HeaderView.OptionsBehavior.FocusLeaveOnTab = true;
            this.HeaderView.OptionsNavigation.AutoFocusNewRow = true;
            this.HeaderView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.HeaderView.OptionsPrint.EnableAppearanceOddRow = true;
            this.HeaderView.OptionsPrint.PrintFilterInfo = true;
            this.HeaderView.OptionsView.EnableAppearanceEvenRow = true;
            this.HeaderView.OptionsView.EnableAppearanceOddRow = true;
            this.HeaderView.OptionsView.ShowAutoFilterRow = true;
            this.HeaderView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.HeaderView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.HeaderView_RowClick);
            this.HeaderView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.HeaderView_RowCellClick);
            this.HeaderView.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.HeaderView_CustomRowCellEdit);
            this.HeaderView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.HeaderView_InitNewRow);
            this.HeaderView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.HeaderView_CellValueChanged);
            this.HeaderView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HeaderView_KeyDown);
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
            // BOMDate
            // 
            this.BOMDate.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("BOMDate.AppearanceCell.FontSizeDelta")));
            this.BOMDate.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("BOMDate.AppearanceCell.FontStyleDelta")));
            this.BOMDate.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("BOMDate.AppearanceCell.GradientMode")));
            this.BOMDate.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("BOMDate.AppearanceCell.Image")));
            this.BOMDate.AppearanceCell.Options.UseTextOptions = true;
            this.BOMDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BOMDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BOMDate.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("BOMDate.AppearanceHeader.FontSizeDelta")));
            this.BOMDate.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("BOMDate.AppearanceHeader.FontStyleDelta")));
            this.BOMDate.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("BOMDate.AppearanceHeader.GradientMode")));
            this.BOMDate.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("BOMDate.AppearanceHeader.Image")));
            this.BOMDate.AppearanceHeader.Options.UseTextOptions = true;
            this.BOMDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BOMDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.BOMDate, "BOMDate");
            this.BOMDate.ColumnEdit = this.repDate;
            this.BOMDate.FieldName = "v2";
            this.BOMDate.Name = "BOMDate";
            this.BOMDate.OptionsColumn.FixedWidth = true;
            this.BOMDate.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.True;
            this.BOMDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // Journal
            // 
            this.Journal.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("Journal.AppearanceCell.FontSizeDelta")));
            this.Journal.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Journal.AppearanceCell.FontStyleDelta")));
            this.Journal.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Journal.AppearanceCell.GradientMode")));
            this.Journal.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("Journal.AppearanceCell.Image")));
            this.Journal.AppearanceCell.Options.UseTextOptions = true;
            this.Journal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Journal.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Journal.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("Journal.AppearanceHeader.FontSizeDelta")));
            this.Journal.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Journal.AppearanceHeader.FontStyleDelta")));
            this.Journal.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Journal.AppearanceHeader.GradientMode")));
            this.Journal.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("Journal.AppearanceHeader.Image")));
            this.Journal.AppearanceHeader.Options.UseTextOptions = true;
            this.Journal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Journal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Journal, "Journal");
            this.Journal.ColumnEdit = this.repJournal;
            this.Journal.FieldName = "v3";
            this.Journal.Name = "Journal";
            this.Journal.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.True;
            this.Journal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // Description
            // 
            this.Description.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("Description.AppearanceCell.FontSizeDelta")));
            this.Description.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Description.AppearanceCell.FontStyleDelta")));
            this.Description.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Description.AppearanceCell.GradientMode")));
            this.Description.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("Description.AppearanceCell.Image")));
            this.Description.AppearanceCell.Options.UseTextOptions = true;
            this.Description.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Description.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Description.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("Description.AppearanceHeader.FontSizeDelta")));
            this.Description.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Description.AppearanceHeader.FontStyleDelta")));
            this.Description.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Description.AppearanceHeader.GradientMode")));
            this.Description.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("Description.AppearanceHeader.Image")));
            this.Description.AppearanceHeader.Options.UseTextOptions = true;
            this.Description.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Description.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Description, "Description");
            this.Description.FieldName = "v4";
            this.Description.Name = "Description";
            this.Description.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.True;
            this.Description.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // Posted
            // 
            this.Posted.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("Posted.AppearanceCell.FontSizeDelta")));
            this.Posted.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Posted.AppearanceCell.FontStyleDelta")));
            this.Posted.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Posted.AppearanceCell.GradientMode")));
            this.Posted.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("Posted.AppearanceCell.Image")));
            this.Posted.AppearanceCell.Options.UseTextOptions = true;
            this.Posted.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Posted.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Posted.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("Posted.AppearanceHeader.FontSizeDelta")));
            this.Posted.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Posted.AppearanceHeader.FontStyleDelta")));
            this.Posted.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Posted.AppearanceHeader.GradientMode")));
            this.Posted.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("Posted.AppearanceHeader.Image")));
            this.Posted.AppearanceHeader.Options.UseTextOptions = true;
            this.Posted.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Posted.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Posted, "Posted");
            this.Posted.FieldName = "v5";
            this.Posted.Name = "Posted";
            this.Posted.OptionsColumn.AllowEdit = false;
            this.Posted.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.True;
            this.Posted.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // OverViewPage
            // 
            resources.ApplyResources(this.OverViewPage, "OverViewPage");
            this.OverViewPage.Controls.Add(this.panelControl2);
            this.OverViewPage.Controls.Add(this.HeaderGrid);
            this.OverViewPage.Name = "OverViewPage";
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.CmbGetGeneralJournals);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Name = "panelControl2";
            // 
            // CmbGetGeneralJournals
            // 
            resources.ApplyResources(this.CmbGetGeneralJournals, "CmbGetGeneralJournals");
            this.CmbGetGeneralJournals.MenuManager = this.ribbonControl1;
            this.CmbGetGeneralJournals.Name = "CmbGetGeneralJournals";
            this.CmbGetGeneralJournals.Properties.AccessibleDescription = resources.GetString("CmbGetGeneralJournals.Properties.AccessibleDescription");
            this.CmbGetGeneralJournals.Properties.AccessibleName = resources.GetString("CmbGetGeneralJournals.Properties.AccessibleName");
            this.CmbGetGeneralJournals.Properties.AutoHeight = ((bool)(resources.GetObject("CmbGetGeneralJournals.Properties.AutoHeight")));
            this.CmbGetGeneralJournals.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("CmbGetGeneralJournals.Properties.Buttons"))))});
            this.CmbGetGeneralJournals.Properties.Items.AddRange(new object[] {
            resources.GetString("CmbGetGeneralJournals.Properties.Items"),
            resources.GetString("CmbGetGeneralJournals.Properties.Items1"),
            resources.GetString("CmbGetGeneralJournals.Properties.Items2")});
            this.CmbGetGeneralJournals.Properties.NullValuePrompt = resources.GetString("CmbGetGeneralJournals.Properties.NullValuePrompt");
            this.CmbGetGeneralJournals.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("CmbGetGeneralJournals.Properties.NullValuePromptShowForEmptyValue")));
            this.CmbGetGeneralJournals.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // xtraTabControl1
            // 
            resources.ApplyResources(this.xtraTabControl1, "xtraTabControl1");
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.OverViewPage;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.OverViewPage});
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Name = "panelControl1";
            // 
            // FRM_BOMJournal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FRM_BOMJournal";
            this.Ribbon = this.ribbonControl1;
            this.Activated += new System.EventHandler(this.FRM_BOMJournal_Activated);
            this.Load += new System.EventHandler(this.FRM_BOMJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderView)).EndInit();
            this.OverViewPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbGetGeneralJournals.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnLines;
        private DevExpress.XtraBars.BarButtonItem btnValidate;
        private DevExpress.XtraBars.BarButtonItem btnPost;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl HeaderGrid;
        private DevExpress.XtraTab.XtraTabPage OverViewPage;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repJournal;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit CmbGetGeneralJournals;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView HeaderView;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn BOMDate;
        private DevExpress.XtraGrid.Columns.GridColumn Journal;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn Posted;
    }
}