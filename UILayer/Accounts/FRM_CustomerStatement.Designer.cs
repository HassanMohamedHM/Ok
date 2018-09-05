namespace UILayer.Accounts
{
    partial class FRM_CustomerStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CustomerStatement));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDisplay = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.DateFrom = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.DateTo = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnPeriodDisplay = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.CustomerDebit = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.CustomerCredit = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.CustomerBalance = new DevExpress.XtraBars.BarStaticItem();
            this.Customer = new DevExpress.XtraBars.BarEditItem();
            this.CustomerSearchLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.CustomerStatementGrid = new DevExpress.XtraGrid.GridControl();
            this.CustomerStatementView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DebitAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreditAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSearchLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerStatementGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerStatementView)).BeginInit();
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
            this.CustomerDebit,
            this.barStaticItem2,
            this.CustomerCredit,
            this.barStaticItem3,
            this.CustomerBalance,
            this.Customer});
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.CustomerSearchLookUpEdit});
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
            // CustomerDebit
            // 
            resources.ApplyResources(this.CustomerDebit, "CustomerDebit");
            this.CustomerDebit.Id = 13;
            this.CustomerDebit.Name = "CustomerDebit";
            this.CustomerDebit.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            resources.ApplyResources(this.barStaticItem2, "barStaticItem2");
            this.barStaticItem2.Id = 15;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // CustomerCredit
            // 
            resources.ApplyResources(this.CustomerCredit, "CustomerCredit");
            this.CustomerCredit.Id = 16;
            this.CustomerCredit.Name = "CustomerCredit";
            this.CustomerCredit.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            resources.ApplyResources(this.barStaticItem3, "barStaticItem3");
            this.barStaticItem3.Id = 17;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // CustomerBalance
            // 
            resources.ApplyResources(this.CustomerBalance, "CustomerBalance");
            this.CustomerBalance.Id = 18;
            this.CustomerBalance.Name = "CustomerBalance";
            this.CustomerBalance.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // Customer
            // 
            resources.ApplyResources(this.Customer, "Customer");
            this.Customer.Edit = this.CustomerSearchLookUpEdit;
            this.Customer.Id = 19;
            this.Customer.Name = "Customer";
            // 
            // CustomerSearchLookUpEdit
            // 
            resources.ApplyResources(this.CustomerSearchLookUpEdit, "CustomerSearchLookUpEdit");
            this.CustomerSearchLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("CustomerSearchLookUpEdit.Buttons"))))});
            this.CustomerSearchLookUpEdit.Name = "CustomerSearchLookUpEdit";
            this.CustomerSearchLookUpEdit.View = this.repositoryItemSearchLookUpEdit1View;
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
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Customer);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDisplay);
            this.ribbonPageGroup1.ItemLinks.Add(this.DateFrom, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.DateTo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPeriodDisplay);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPrint, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.CustomerDebit);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2, true);
            this.ribbonStatusBar.ItemLinks.Add(this.CustomerCredit);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem3, true);
            this.ribbonStatusBar.ItemLinks.Add(this.CustomerBalance);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            // 
            // CustomerStatementGrid
            // 
            resources.ApplyResources(this.CustomerStatementGrid, "CustomerStatementGrid");
            this.CustomerStatementGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("CustomerStatementGrid.EmbeddedNavigator.AccessibleDescription");
            this.CustomerStatementGrid.EmbeddedNavigator.AccessibleName = resources.GetString("CustomerStatementGrid.EmbeddedNavigator.AccessibleName");
            this.CustomerStatementGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("CustomerStatementGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.CustomerStatementGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("CustomerStatementGrid.EmbeddedNavigator.Anchor")));
            this.CustomerStatementGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomerStatementGrid.EmbeddedNavigator.BackgroundImage")));
            this.CustomerStatementGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("CustomerStatementGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.CustomerStatementGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("CustomerStatementGrid.EmbeddedNavigator.ImeMode")));
            this.CustomerStatementGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("CustomerStatementGrid.EmbeddedNavigator.MaximumSize")));
            this.CustomerStatementGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("CustomerStatementGrid.EmbeddedNavigator.TextLocation")));
            this.CustomerStatementGrid.EmbeddedNavigator.ToolTip = resources.GetString("CustomerStatementGrid.EmbeddedNavigator.ToolTip");
            this.CustomerStatementGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("CustomerStatementGrid.EmbeddedNavigator.ToolTipIconType")));
            this.CustomerStatementGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("CustomerStatementGrid.EmbeddedNavigator.ToolTipTitle");
            this.CustomerStatementGrid.MainView = this.CustomerStatementView;
            this.CustomerStatementGrid.MenuManager = this.ribbon;
            this.CustomerStatementGrid.Name = "CustomerStatementGrid";
            this.CustomerStatementGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CustomerStatementView});
            // 
            // CustomerStatementView
            // 
            resources.ApplyResources(this.CustomerStatementView, "CustomerStatementView");
            this.CustomerStatementView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Date,
            this.Time,
            this.DebitAmount,
            this.CreditAmount});
            this.CustomerStatementView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.CustomerStatementView.GridControl = this.CustomerStatementGrid;
            this.CustomerStatementView.Name = "CustomerStatementView";
            this.CustomerStatementView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.CustomerStatementView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.CustomerStatementView.OptionsBehavior.Editable = false;
            this.CustomerStatementView.OptionsPrint.AllowMultilineHeaders = true;
            this.CustomerStatementView.OptionsPrint.PrintDetails = true;
            this.CustomerStatementView.OptionsPrint.PrintFilterInfo = true;
            this.CustomerStatementView.OptionsPrint.PrintPreview = true;
            this.CustomerStatementView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.CustomerStatementView.OptionsView.EnableAppearanceEvenRow = true;
            this.CustomerStatementView.OptionsView.EnableAppearanceOddRow = true;
            this.CustomerStatementView.OptionsView.ShowAutoFilterRow = true;
            this.CustomerStatementView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.CustomerStatementView.OptionsView.ShowGroupedColumns = true;
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
            // 
            // FRM_CustomerStatement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomerStatementGrid);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "FRM_CustomerStatement";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.FRM_CustomerStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSearchLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerStatementGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerStatementView)).EndInit();
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
        private DevExpress.XtraGrid.GridControl CustomerStatementGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView CustomerStatementView;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Time;
        private DevExpress.XtraGrid.Columns.GridColumn DebitAmount;
        private DevExpress.XtraGrid.Columns.GridColumn CreditAmount;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem CustomerDebit;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem CustomerCredit;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem CustomerBalance;
        private DevExpress.XtraBars.BarEditItem Customer;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit CustomerSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
    }
}