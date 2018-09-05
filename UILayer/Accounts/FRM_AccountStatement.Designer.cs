namespace UILayer.Accounts
{
    partial class FRM_AccountStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AccountStatement));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDisplay = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.DateFrom = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.DateTo = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnPeriodDisplay = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.AccountDebit = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.AccountCredit = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem5 = new DevExpress.XtraBars.BarStaticItem();
            this.AccountBalance = new DevExpress.XtraBars.BarStaticItem();
            this.Account = new DevExpress.XtraBars.BarEditItem();
            this.AccountSearchLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.AccountStatementGrid = new DevExpress.XtraGrid.GridControl();
            this.AccountStatementView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DebitAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreditAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountSearchLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountStatementGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountStatementView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDisplay,
            this.btnPrint,
            this.DateFrom,
            this.DateTo,
            this.btnPeriodDisplay,
            this.barStaticItem1,
            this.AccountDebit,
            this.barStaticItem3,
            this.AccountCredit,
            this.barStaticItem5,
            this.AccountBalance,
            this.Account});
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.AccountSearchLookUpEdit});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDisplay
            // 
            resources.ApplyResources(this.btnDisplay, "btnDisplay");
            this.btnDisplay.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDisplay.Glyph")));
            this.btnDisplay.Id = 5;
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDisplay_ItemClick);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.Glyph")));
            this.btnPrint.Id = 6;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // DateFrom
            // 
            resources.ApplyResources(this.DateFrom, "DateFrom");
            this.DateFrom.Edit = this.repositoryItemDateEdit1;
            this.DateFrom.Id = 8;
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
            // 
            // DateTo
            // 
            resources.ApplyResources(this.DateTo, "DateTo");
            this.DateTo.Edit = this.repositoryItemDateEdit2;
            this.DateTo.Id = 9;
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
            // 
            // btnPeriodDisplay
            // 
            resources.ApplyResources(this.btnPeriodDisplay, "btnPeriodDisplay");
            this.btnPeriodDisplay.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPeriodDisplay.Glyph")));
            this.btnPeriodDisplay.Id = 11;
            this.btnPeriodDisplay.Name = "btnPeriodDisplay";
            this.btnPeriodDisplay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPeriodDisplay_ItemClick);
            // 
            // barStaticItem1
            // 
            resources.ApplyResources(this.barStaticItem1, "barStaticItem1");
            this.barStaticItem1.Id = 12;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // AccountDebit
            // 
            resources.ApplyResources(this.AccountDebit, "AccountDebit");
            this.AccountDebit.Id = 13;
            this.AccountDebit.Name = "AccountDebit";
            this.AccountDebit.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            resources.ApplyResources(this.barStaticItem3, "barStaticItem3");
            this.barStaticItem3.Id = 14;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // AccountCredit
            // 
            resources.ApplyResources(this.AccountCredit, "AccountCredit");
            this.AccountCredit.Id = 15;
            this.AccountCredit.Name = "AccountCredit";
            this.AccountCredit.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem5
            // 
            resources.ApplyResources(this.barStaticItem5, "barStaticItem5");
            this.barStaticItem5.Id = 16;
            this.barStaticItem5.Name = "barStaticItem5";
            this.barStaticItem5.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // AccountBalance
            // 
            resources.ApplyResources(this.AccountBalance, "AccountBalance");
            this.AccountBalance.Id = 17;
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // Account
            // 
            resources.ApplyResources(this.Account, "Account");
            this.Account.Edit = this.AccountSearchLookUpEdit;
            this.Account.Id = 18;
            this.Account.Name = "Account";
            // 
            // AccountSearchLookUpEdit
            // 
            resources.ApplyResources(this.AccountSearchLookUpEdit, "AccountSearchLookUpEdit");
            this.AccountSearchLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("AccountSearchLookUpEdit.Buttons"))))});
            this.AccountSearchLookUpEdit.Name = "AccountSearchLookUpEdit";
            this.AccountSearchLookUpEdit.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            resources.ApplyResources(this.repositoryItemSearchLookUpEdit1View, "repositoryItemSearchLookUpEdit1View");
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.EnableAppearanceOddRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Account);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDisplay);
            this.ribbonPageGroup1.ItemLinks.Add(this.DateFrom, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.DateTo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPeriodDisplay);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPrint, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.AccountDebit);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem3, true);
            this.ribbonStatusBar.ItemLinks.Add(this.AccountCredit);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem5, true);
            this.ribbonStatusBar.ItemLinks.Add(this.AccountBalance);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            // 
            // AccountStatementGrid
            // 
            resources.ApplyResources(this.AccountStatementGrid, "AccountStatementGrid");
            this.AccountStatementGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("AccountStatementGrid.EmbeddedNavigator.AccessibleDescription");
            this.AccountStatementGrid.EmbeddedNavigator.AccessibleName = resources.GetString("AccountStatementGrid.EmbeddedNavigator.AccessibleName");
            this.AccountStatementGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("AccountStatementGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.AccountStatementGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("AccountStatementGrid.EmbeddedNavigator.Anchor")));
            this.AccountStatementGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AccountStatementGrid.EmbeddedNavigator.BackgroundImage")));
            this.AccountStatementGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("AccountStatementGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.AccountStatementGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("AccountStatementGrid.EmbeddedNavigator.ImeMode")));
            this.AccountStatementGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("AccountStatementGrid.EmbeddedNavigator.MaximumSize")));
            this.AccountStatementGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("AccountStatementGrid.EmbeddedNavigator.TextLocation")));
            this.AccountStatementGrid.EmbeddedNavigator.ToolTip = resources.GetString("AccountStatementGrid.EmbeddedNavigator.ToolTip");
            this.AccountStatementGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("AccountStatementGrid.EmbeddedNavigator.ToolTipIconType")));
            this.AccountStatementGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("AccountStatementGrid.EmbeddedNavigator.ToolTipTitle");
            this.AccountStatementGrid.MainView = this.AccountStatementView;
            this.AccountStatementGrid.MenuManager = this.ribbon;
            this.AccountStatementGrid.Name = "AccountStatementGrid";
            this.AccountStatementGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.AccountStatementView});
            // 
            // AccountStatementView
            // 
            resources.ApplyResources(this.AccountStatementView, "AccountStatementView");
            this.AccountStatementView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Date,
            this.Time,
            this.DebitAmount,
            this.CreditAmount});
            this.AccountStatementView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.AccountStatementView.GridControl = this.AccountStatementGrid;
            this.AccountStatementView.Name = "AccountStatementView";
            this.AccountStatementView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.AccountStatementView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.AccountStatementView.OptionsBehavior.Editable = false;
            this.AccountStatementView.OptionsPrint.AllowMultilineHeaders = true;
            this.AccountStatementView.OptionsPrint.PrintDetails = true;
            this.AccountStatementView.OptionsPrint.PrintFilterInfo = true;
            this.AccountStatementView.OptionsPrint.PrintPreview = true;
            this.AccountStatementView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.AccountStatementView.OptionsView.EnableAppearanceEvenRow = true;
            this.AccountStatementView.OptionsView.EnableAppearanceOddRow = true;
            this.AccountStatementView.OptionsView.ShowAutoFilterRow = true;
            this.AccountStatementView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.AccountStatementView.OptionsView.ShowGroupedColumns = true;
            // 
            // Date
            // 
            this.Date.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("Date.AppearanceCell.FontSizeDelta")));
            this.Date.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Date.AppearanceCell.FontStyleDelta")));
            this.Date.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Date.AppearanceCell.GradientMode")));
            this.Date.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("Date.AppearanceCell.Image")));
            this.Date.AppearanceCell.Options.UseTextOptions = true;
            this.Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Date.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Date.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("Date.AppearanceHeader.FontSizeDelta")));
            this.Date.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Date.AppearanceHeader.FontStyleDelta")));
            this.Date.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Date.AppearanceHeader.GradientMode")));
            this.Date.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("Date.AppearanceHeader.Image")));
            this.Date.AppearanceHeader.Options.UseTextOptions = true;
            this.Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Date.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Date, "Date");
            this.Date.FieldName = "v1";
            this.Date.Name = "Date";
            this.Date.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // Time
            // 
            this.Time.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("Time.AppearanceCell.FontSizeDelta")));
            this.Time.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Time.AppearanceCell.FontStyleDelta")));
            this.Time.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Time.AppearanceCell.GradientMode")));
            this.Time.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("Time.AppearanceCell.Image")));
            this.Time.AppearanceCell.Options.UseTextOptions = true;
            this.Time.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Time.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Time.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("Time.AppearanceHeader.FontSizeDelta")));
            this.Time.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Time.AppearanceHeader.FontStyleDelta")));
            this.Time.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Time.AppearanceHeader.GradientMode")));
            this.Time.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("Time.AppearanceHeader.Image")));
            this.Time.AppearanceHeader.Options.UseTextOptions = true;
            this.Time.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Time.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Time, "Time");
            this.Time.FieldName = "v2";
            this.Time.Name = "Time";
            this.Time.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // DebitAmount
            // 
            this.DebitAmount.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("DebitAmount.AppearanceCell.FontSizeDelta")));
            this.DebitAmount.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("DebitAmount.AppearanceCell.FontStyleDelta")));
            this.DebitAmount.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("DebitAmount.AppearanceCell.GradientMode")));
            this.DebitAmount.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("DebitAmount.AppearanceCell.Image")));
            this.DebitAmount.AppearanceCell.Options.UseTextOptions = true;
            this.DebitAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DebitAmount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DebitAmount.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("DebitAmount.AppearanceHeader.FontSizeDelta")));
            this.DebitAmount.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("DebitAmount.AppearanceHeader.FontStyleDelta")));
            this.DebitAmount.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("DebitAmount.AppearanceHeader.GradientMode")));
            this.DebitAmount.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("DebitAmount.AppearanceHeader.Image")));
            this.DebitAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.DebitAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DebitAmount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.DebitAmount, "DebitAmount");
            this.DebitAmount.FieldName = "v3";
            this.DebitAmount.Name = "DebitAmount";
            this.DebitAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // CreditAmount
            // 
            this.CreditAmount.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("CreditAmount.AppearanceCell.FontSizeDelta")));
            this.CreditAmount.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CreditAmount.AppearanceCell.FontStyleDelta")));
            this.CreditAmount.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CreditAmount.AppearanceCell.GradientMode")));
            this.CreditAmount.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("CreditAmount.AppearanceCell.Image")));
            this.CreditAmount.AppearanceCell.Options.UseTextOptions = true;
            this.CreditAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CreditAmount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CreditAmount.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("CreditAmount.AppearanceHeader.FontSizeDelta")));
            this.CreditAmount.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CreditAmount.AppearanceHeader.FontStyleDelta")));
            this.CreditAmount.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CreditAmount.AppearanceHeader.GradientMode")));
            this.CreditAmount.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("CreditAmount.AppearanceHeader.Image")));
            this.CreditAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.CreditAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CreditAmount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.CreditAmount, "CreditAmount");
            this.CreditAmount.FieldName = "v4";
            this.CreditAmount.Name = "CreditAmount";
            this.CreditAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // FRM_AccountStatement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AccountStatementGrid);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "FRM_AccountStatement";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.FRM_AccountStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountSearchLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountStatementGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountStatementView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDisplay;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarEditItem DateFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem DateTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem btnPeriodDisplay;
        private DevExpress.XtraGrid.GridControl AccountStatementGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView AccountStatementView;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Time;
        private DevExpress.XtraGrid.Columns.GridColumn DebitAmount;
        private DevExpress.XtraGrid.Columns.GridColumn CreditAmount;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem AccountDebit;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem AccountCredit;
        private DevExpress.XtraBars.BarStaticItem barStaticItem5;
        private DevExpress.XtraBars.BarStaticItem AccountBalance;
        private DevExpress.XtraBars.BarEditItem Account;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit AccountSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
    }
}