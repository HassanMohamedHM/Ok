namespace UILayer.Accounts
{
    partial class FRM_TrialBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TrialBalance));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.DateFrom = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.DateTo = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnDisplay = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TrialBalanceGrid = new DevExpress.XtraGrid.GridControl();
            this.TrialBalanceBand = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn7 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn8 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridAccount = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.BeginingBalanceGrid = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.BalanceGrid = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ClosingBalanceGrid = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrialBalanceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrialBalanceBand)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.DateFrom,
            this.DateTo,
            this.btnDisplay,
            this.btnPrint});
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // DateFrom
            // 
            resources.ApplyResources(this.DateFrom, "DateFrom");
            this.DateFrom.Edit = this.repositoryItemDateEdit1;
            this.DateFrom.Id = 1;
            this.DateFrom.Name = "DateFrom";
            // 
            // repositoryItemDateEdit1
            // 
            resources.ApplyResources(this.repositoryItemDateEdit1, "repositoryItemDateEdit1");
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit1.Buttons"))))});
            this.repositoryItemDateEdit1.CalendarTimeProperties.AccessibleDescription = resources.GetString("repositoryItemDateEdit1.CalendarTimeProperties.AccessibleDescription");
            this.repositoryItemDateEdit1.CalendarTimeProperties.AccessibleName = resources.GetString("repositoryItemDateEdit1.CalendarTimeProperties.AccessibleName");
            this.repositoryItemDateEdit1.CalendarTimeProperties.AutoHeight = ((bool)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.AutoHeight")));
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.Buttons"))))});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.Mask.AutoComplete")));
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.Mask.BeepOnError")));
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.EditMask = resources.GetString("repositoryItemDateEdit1.CalendarTimeProperties.Mask.EditMask");
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.Mask.IgnoreMaskBlank")));
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.Mask.MaskType")));
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.Mask.PlaceHolder")));
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.Mask.SaveLiteral")));
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.Mask.ShowPlaceHolders")));
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemDateEdit1.CalendarTimeProperties.NullValuePrompt = resources.GetString("repositoryItemDateEdit1.CalendarTimeProperties.NullValuePrompt");
            this.repositoryItemDateEdit1.CalendarTimeProperties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.NullValuePromptShowForEmptyValue")));
            this.repositoryItemDateEdit1.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.repositoryItemDateEdit1.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemDateEdit1.Mask.AutoComplete")));
            this.repositoryItemDateEdit1.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemDateEdit1.Mask.BeepOnError")));
            this.repositoryItemDateEdit1.Mask.EditMask = resources.GetString("repositoryItemDateEdit1.Mask.EditMask");
            this.repositoryItemDateEdit1.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemDateEdit1.Mask.IgnoreMaskBlank")));
            this.repositoryItemDateEdit1.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemDateEdit1.Mask.MaskType")));
            this.repositoryItemDateEdit1.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemDateEdit1.Mask.PlaceHolder")));
            this.repositoryItemDateEdit1.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemDateEdit1.Mask.SaveLiteral")));
            this.repositoryItemDateEdit1.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemDateEdit1.Mask.ShowPlaceHolders")));
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // DateTo
            // 
            resources.ApplyResources(this.DateTo, "DateTo");
            this.DateTo.Edit = this.repositoryItemDateEdit2;
            this.DateTo.Id = 2;
            this.DateTo.Name = "DateTo";
            // 
            // repositoryItemDateEdit2
            // 
            resources.ApplyResources(this.repositoryItemDateEdit2, "repositoryItemDateEdit2");
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit2.Buttons"))))});
            this.repositoryItemDateEdit2.CalendarTimeProperties.AccessibleDescription = resources.GetString("repositoryItemDateEdit2.CalendarTimeProperties.AccessibleDescription");
            this.repositoryItemDateEdit2.CalendarTimeProperties.AccessibleName = resources.GetString("repositoryItemDateEdit2.CalendarTimeProperties.AccessibleName");
            this.repositoryItemDateEdit2.CalendarTimeProperties.AutoHeight = ((bool)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.AutoHeight")));
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.Buttons"))))});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.Mask.AutoComplete")));
            this.repositoryItemDateEdit2.CalendarTimeProperties.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.Mask.BeepOnError")));
            this.repositoryItemDateEdit2.CalendarTimeProperties.Mask.EditMask = resources.GetString("repositoryItemDateEdit2.CalendarTimeProperties.Mask.EditMask");
            this.repositoryItemDateEdit2.CalendarTimeProperties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.Mask.IgnoreMaskBlank")));
            this.repositoryItemDateEdit2.CalendarTimeProperties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.Mask.MaskType")));
            this.repositoryItemDateEdit2.CalendarTimeProperties.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.Mask.PlaceHolder")));
            this.repositoryItemDateEdit2.CalendarTimeProperties.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.Mask.SaveLiteral")));
            this.repositoryItemDateEdit2.CalendarTimeProperties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.Mask.ShowPlaceHolders")));
            this.repositoryItemDateEdit2.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemDateEdit2.CalendarTimeProperties.NullValuePrompt = resources.GetString("repositoryItemDateEdit2.CalendarTimeProperties.NullValuePrompt");
            this.repositoryItemDateEdit2.CalendarTimeProperties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.NullValuePromptShowForEmptyValue")));
            this.repositoryItemDateEdit2.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.repositoryItemDateEdit2.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemDateEdit2.Mask.AutoComplete")));
            this.repositoryItemDateEdit2.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemDateEdit2.Mask.BeepOnError")));
            this.repositoryItemDateEdit2.Mask.EditMask = resources.GetString("repositoryItemDateEdit2.Mask.EditMask");
            this.repositoryItemDateEdit2.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemDateEdit2.Mask.IgnoreMaskBlank")));
            this.repositoryItemDateEdit2.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemDateEdit2.Mask.MaskType")));
            this.repositoryItemDateEdit2.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemDateEdit2.Mask.PlaceHolder")));
            this.repositoryItemDateEdit2.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemDateEdit2.Mask.SaveLiteral")));
            this.repositoryItemDateEdit2.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemDateEdit2.Mask.ShowPlaceHolders")));
            this.repositoryItemDateEdit2.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemDateEdit2.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // btnDisplay
            // 
            resources.ApplyResources(this.btnDisplay, "btnDisplay");
            this.btnDisplay.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDisplay.Glyph")));
            this.btnDisplay.Id = 3;
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDisplay_ItemClick);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.Glyph")));
            this.btnPrint.Id = 4;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.DateFrom);
            this.ribbonPageGroup1.ItemLinks.Add(this.DateTo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDisplay);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPrint, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.TrialBalanceGrid);
            this.panelControl1.Name = "panelControl1";
            // 
            // TrialBalanceGrid
            // 
            resources.ApplyResources(this.TrialBalanceGrid, "TrialBalanceGrid");
            this.TrialBalanceGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("TrialBalanceGrid.EmbeddedNavigator.AccessibleDescription");
            this.TrialBalanceGrid.EmbeddedNavigator.AccessibleName = resources.GetString("TrialBalanceGrid.EmbeddedNavigator.AccessibleName");
            this.TrialBalanceGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("TrialBalanceGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.TrialBalanceGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("TrialBalanceGrid.EmbeddedNavigator.Anchor")));
            this.TrialBalanceGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TrialBalanceGrid.EmbeddedNavigator.BackgroundImage")));
            this.TrialBalanceGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("TrialBalanceGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.TrialBalanceGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("TrialBalanceGrid.EmbeddedNavigator.ImeMode")));
            this.TrialBalanceGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("TrialBalanceGrid.EmbeddedNavigator.MaximumSize")));
            this.TrialBalanceGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("TrialBalanceGrid.EmbeddedNavigator.TextLocation")));
            this.TrialBalanceGrid.EmbeddedNavigator.ToolTip = resources.GetString("TrialBalanceGrid.EmbeddedNavigator.ToolTip");
            this.TrialBalanceGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("TrialBalanceGrid.EmbeddedNavigator.ToolTipIconType")));
            this.TrialBalanceGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("TrialBalanceGrid.EmbeddedNavigator.ToolTipTitle");
            this.TrialBalanceGrid.MainView = this.TrialBalanceBand;
            this.TrialBalanceGrid.MenuManager = this.ribbon;
            this.TrialBalanceGrid.Name = "TrialBalanceGrid";
            this.TrialBalanceGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TrialBalanceBand});
            // 
            // TrialBalanceBand
            // 
            this.TrialBalanceBand.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.GridAccount,
            this.BeginingBalanceGrid,
            this.BalanceGrid,
            this.ClosingBalanceGrid});
            resources.ApplyResources(this.TrialBalanceBand, "TrialBalanceBand");
            this.TrialBalanceBand.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn6,
            this.bandedGridColumn7,
            this.bandedGridColumn8});
            this.TrialBalanceBand.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.TrialBalanceBand.GridControl = this.TrialBalanceGrid;
            this.TrialBalanceBand.Name = "TrialBalanceBand";
            this.TrialBalanceBand.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.TrialBalanceBand.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.TrialBalanceBand.OptionsBehavior.Editable = false;
            this.TrialBalanceBand.OptionsCustomization.AllowBandMoving = false;
            this.TrialBalanceBand.OptionsPrint.EnableAppearanceEvenRow = true;
            this.TrialBalanceBand.OptionsPrint.EnableAppearanceOddRow = true;
            this.TrialBalanceBand.OptionsPrint.ExpandAllDetails = true;
            this.TrialBalanceBand.OptionsPrint.PrintDetails = true;
            this.TrialBalanceBand.OptionsPrint.PrintFilterInfo = true;
            this.TrialBalanceBand.OptionsPrint.PrintPreview = true;
            this.TrialBalanceBand.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.TrialBalanceBand.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.TrialBalanceBand.OptionsView.EnableAppearanceEvenRow = true;
            this.TrialBalanceBand.OptionsView.EnableAppearanceOddRow = true;
            this.TrialBalanceBand.OptionsView.ShowAutoFilterRow = true;
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
            this.bandedGridColumn1.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
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
            this.bandedGridColumn2.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
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
            this.bandedGridColumn3.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn4.AppearanceCell.FontSizeDelta")));
            this.bandedGridColumn4.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn4.AppearanceCell.FontStyleDelta")));
            this.bandedGridColumn4.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn4.AppearanceCell.GradientMode")));
            this.bandedGridColumn4.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn4.AppearanceCell.Image")));
            this.bandedGridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumn4.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn4.AppearanceHeader.FontSizeDelta")));
            this.bandedGridColumn4.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn4.AppearanceHeader.FontStyleDelta")));
            this.bandedGridColumn4.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn4.AppearanceHeader.GradientMode")));
            this.bandedGridColumn4.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn4.AppearanceHeader.Image")));
            this.bandedGridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.bandedGridColumn4, "bandedGridColumn4");
            this.bandedGridColumn4.FieldName = "v4";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn5.AppearanceCell.FontSizeDelta")));
            this.bandedGridColumn5.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn5.AppearanceCell.FontStyleDelta")));
            this.bandedGridColumn5.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn5.AppearanceCell.GradientMode")));
            this.bandedGridColumn5.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn5.AppearanceCell.Image")));
            this.bandedGridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumn5.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn5.AppearanceHeader.FontSizeDelta")));
            this.bandedGridColumn5.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn5.AppearanceHeader.FontStyleDelta")));
            this.bandedGridColumn5.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn5.AppearanceHeader.GradientMode")));
            this.bandedGridColumn5.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn5.AppearanceHeader.Image")));
            this.bandedGridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.bandedGridColumn5, "bandedGridColumn5");
            this.bandedGridColumn5.FieldName = "v5";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn6.AppearanceCell.FontSizeDelta")));
            this.bandedGridColumn6.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn6.AppearanceCell.FontStyleDelta")));
            this.bandedGridColumn6.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn6.AppearanceCell.GradientMode")));
            this.bandedGridColumn6.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn6.AppearanceCell.Image")));
            this.bandedGridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumn6.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn6.AppearanceHeader.FontSizeDelta")));
            this.bandedGridColumn6.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn6.AppearanceHeader.FontStyleDelta")));
            this.bandedGridColumn6.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn6.AppearanceHeader.GradientMode")));
            this.bandedGridColumn6.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn6.AppearanceHeader.Image")));
            this.bandedGridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.bandedGridColumn6, "bandedGridColumn6");
            this.bandedGridColumn6.FieldName = "v6";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn6.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // bandedGridColumn7
            // 
            this.bandedGridColumn7.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn7.AppearanceCell.FontSizeDelta")));
            this.bandedGridColumn7.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn7.AppearanceCell.FontStyleDelta")));
            this.bandedGridColumn7.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn7.AppearanceCell.GradientMode")));
            this.bandedGridColumn7.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn7.AppearanceCell.Image")));
            this.bandedGridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumn7.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn7.AppearanceHeader.FontSizeDelta")));
            this.bandedGridColumn7.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn7.AppearanceHeader.FontStyleDelta")));
            this.bandedGridColumn7.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn7.AppearanceHeader.GradientMode")));
            this.bandedGridColumn7.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn7.AppearanceHeader.Image")));
            this.bandedGridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.bandedGridColumn7, "bandedGridColumn7");
            this.bandedGridColumn7.FieldName = "v7";
            this.bandedGridColumn7.Name = "bandedGridColumn7";
            this.bandedGridColumn7.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // bandedGridColumn8
            // 
            this.bandedGridColumn8.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn8.AppearanceCell.FontSizeDelta")));
            this.bandedGridColumn8.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn8.AppearanceCell.FontStyleDelta")));
            this.bandedGridColumn8.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn8.AppearanceCell.GradientMode")));
            this.bandedGridColumn8.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn8.AppearanceCell.Image")));
            this.bandedGridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn8.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumn8.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("bandedGridColumn8.AppearanceHeader.FontSizeDelta")));
            this.bandedGridColumn8.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("bandedGridColumn8.AppearanceHeader.FontStyleDelta")));
            this.bandedGridColumn8.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("bandedGridColumn8.AppearanceHeader.GradientMode")));
            this.bandedGridColumn8.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("bandedGridColumn8.AppearanceHeader.Image")));
            this.bandedGridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn8.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.bandedGridColumn8, "bandedGridColumn8");
            this.bandedGridColumn8.FieldName = "v8";
            this.bandedGridColumn8.Name = "bandedGridColumn8";
            this.bandedGridColumn8.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // GridAccount
            // 
            this.GridAccount.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("GridAccount.AppearanceHeader.FontSizeDelta")));
            this.GridAccount.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("GridAccount.AppearanceHeader.FontStyleDelta")));
            this.GridAccount.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("GridAccount.AppearanceHeader.GradientMode")));
            this.GridAccount.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("GridAccount.AppearanceHeader.Image")));
            this.GridAccount.AppearanceHeader.Options.UseTextOptions = true;
            this.GridAccount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridAccount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.GridAccount, "GridAccount");
            this.GridAccount.Columns.Add(this.bandedGridColumn1);
            this.GridAccount.Columns.Add(this.bandedGridColumn2);
            this.GridAccount.OptionsBand.AllowMove = false;
            this.GridAccount.VisibleIndex = 0;
            // 
            // BeginingBalanceGrid
            // 
            this.BeginingBalanceGrid.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("BeginingBalanceGrid.AppearanceHeader.FontSizeDelta")));
            this.BeginingBalanceGrid.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("BeginingBalanceGrid.AppearanceHeader.FontStyleDelta")));
            this.BeginingBalanceGrid.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("BeginingBalanceGrid.AppearanceHeader.GradientMode")));
            this.BeginingBalanceGrid.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("BeginingBalanceGrid.AppearanceHeader.Image")));
            this.BeginingBalanceGrid.AppearanceHeader.Options.UseTextOptions = true;
            this.BeginingBalanceGrid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BeginingBalanceGrid.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.BeginingBalanceGrid, "BeginingBalanceGrid");
            this.BeginingBalanceGrid.Columns.Add(this.bandedGridColumn3);
            this.BeginingBalanceGrid.Columns.Add(this.bandedGridColumn4);
            this.BeginingBalanceGrid.OptionsBand.AllowMove = false;
            this.BeginingBalanceGrid.VisibleIndex = 1;
            // 
            // BalanceGrid
            // 
            this.BalanceGrid.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("BalanceGrid.AppearanceHeader.FontSizeDelta")));
            this.BalanceGrid.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("BalanceGrid.AppearanceHeader.FontStyleDelta")));
            this.BalanceGrid.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("BalanceGrid.AppearanceHeader.GradientMode")));
            this.BalanceGrid.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("BalanceGrid.AppearanceHeader.Image")));
            this.BalanceGrid.AppearanceHeader.Options.UseTextOptions = true;
            this.BalanceGrid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BalanceGrid.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.BalanceGrid, "BalanceGrid");
            this.BalanceGrid.Columns.Add(this.bandedGridColumn5);
            this.BalanceGrid.Columns.Add(this.bandedGridColumn6);
            this.BalanceGrid.OptionsBand.AllowMove = false;
            this.BalanceGrid.VisibleIndex = 2;
            // 
            // ClosingBalanceGrid
            // 
            this.ClosingBalanceGrid.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("ClosingBalanceGrid.AppearanceHeader.FontSizeDelta")));
            this.ClosingBalanceGrid.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("ClosingBalanceGrid.AppearanceHeader.FontStyleDelta")));
            this.ClosingBalanceGrid.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("ClosingBalanceGrid.AppearanceHeader.GradientMode")));
            this.ClosingBalanceGrid.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("ClosingBalanceGrid.AppearanceHeader.Image")));
            this.ClosingBalanceGrid.AppearanceHeader.Options.UseTextOptions = true;
            this.ClosingBalanceGrid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClosingBalanceGrid.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.ClosingBalanceGrid, "ClosingBalanceGrid");
            this.ClosingBalanceGrid.Columns.Add(this.bandedGridColumn7);
            this.ClosingBalanceGrid.Columns.Add(this.bandedGridColumn8);
            this.ClosingBalanceGrid.OptionsBand.AllowMove = false;
            this.ClosingBalanceGrid.VisibleIndex = 3;
            // 
            // FRM_TrialBalance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "FRM_TrialBalance";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrialBalanceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrialBalanceBand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarEditItem DateFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem DateTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem btnDisplay;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl TrialBalanceGrid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView TrialBalanceBand;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn8;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand GridAccount;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand BeginingBalanceGrid;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand BalanceGrid;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand ClosingBalanceGrid;
    }
}