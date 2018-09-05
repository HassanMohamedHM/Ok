namespace UILayer.Invoices
{
    partial class FRM_Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Sales));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAllSalesInvoices = new DevExpress.XtraBars.BarButtonItem();
            this.btnCashSalesInvoices = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccrualSalesInvoices = new DevExpress.XtraBars.BarButtonItem();
            this.FromItem = new DevExpress.XtraBars.BarEditItem();
            this.FromDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ToItem = new DevExpress.XtraBars.BarEditItem();
            this.ToDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnDisplaySpecifiedSales = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.SalesGrid = new DevExpress.XtraGrid.GridControl();
            this.SalesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnAllSalesInvoices,
            this.btnCashSalesInvoices,
            this.btnAccrualSalesInvoices,
            this.FromItem,
            this.ToItem,
            this.btnDisplaySpecifiedSales,
            this.btnPrint});
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.FromDate,
            this.ToDate,
            this.repositoryItemSearchLookUpEdit1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAllSalesInvoices
            // 
            resources.ApplyResources(this.btnAllSalesInvoices, "btnAllSalesInvoices");
            this.btnAllSalesInvoices.Id = 1;
            this.btnAllSalesInvoices.Name = "btnAllSalesInvoices";
            this.btnAllSalesInvoices.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAllSalesInvoices_ItemClick);
            // 
            // btnCashSalesInvoices
            // 
            resources.ApplyResources(this.btnCashSalesInvoices, "btnCashSalesInvoices");
            this.btnCashSalesInvoices.Id = 2;
            this.btnCashSalesInvoices.Name = "btnCashSalesInvoices";
            this.btnCashSalesInvoices.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCashSalesInvoices_ItemClick);
            // 
            // btnAccrualSalesInvoices
            // 
            resources.ApplyResources(this.btnAccrualSalesInvoices, "btnAccrualSalesInvoices");
            this.btnAccrualSalesInvoices.Id = 3;
            this.btnAccrualSalesInvoices.Name = "btnAccrualSalesInvoices";
            this.btnAccrualSalesInvoices.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccrualSalesInvoices_ItemClick);
            // 
            // FromItem
            // 
            resources.ApplyResources(this.FromItem, "FromItem");
            this.FromItem.Edit = this.FromDate;
            this.FromItem.Id = 5;
            this.FromItem.Name = "FromItem";
            // 
            // FromDate
            // 
            resources.ApplyResources(this.FromDate, "FromDate");
            this.FromDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("FromDate.Buttons"))))});
            this.FromDate.CalendarTimeProperties.AccessibleDescription = resources.GetString("FromDate.CalendarTimeProperties.AccessibleDescription");
            this.FromDate.CalendarTimeProperties.AccessibleName = resources.GetString("FromDate.CalendarTimeProperties.AccessibleName");
            this.FromDate.CalendarTimeProperties.AutoHeight = ((bool)(resources.GetObject("FromDate.CalendarTimeProperties.AutoHeight")));
            this.FromDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("FromDate.CalendarTimeProperties.Buttons"))))});
            this.FromDate.CalendarTimeProperties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("FromDate.CalendarTimeProperties.Mask.AutoComplete")));
            this.FromDate.CalendarTimeProperties.Mask.BeepOnError = ((bool)(resources.GetObject("FromDate.CalendarTimeProperties.Mask.BeepOnError")));
            this.FromDate.CalendarTimeProperties.Mask.EditMask = resources.GetString("FromDate.CalendarTimeProperties.Mask.EditMask");
            this.FromDate.CalendarTimeProperties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("FromDate.CalendarTimeProperties.Mask.IgnoreMaskBlank")));
            this.FromDate.CalendarTimeProperties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("FromDate.CalendarTimeProperties.Mask.MaskType")));
            this.FromDate.CalendarTimeProperties.Mask.PlaceHolder = ((char)(resources.GetObject("FromDate.CalendarTimeProperties.Mask.PlaceHolder")));
            this.FromDate.CalendarTimeProperties.Mask.SaveLiteral = ((bool)(resources.GetObject("FromDate.CalendarTimeProperties.Mask.SaveLiteral")));
            this.FromDate.CalendarTimeProperties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("FromDate.CalendarTimeProperties.Mask.ShowPlaceHolders")));
            this.FromDate.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("FromDate.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat")));
            this.FromDate.CalendarTimeProperties.NullValuePrompt = resources.GetString("FromDate.CalendarTimeProperties.NullValuePrompt");
            this.FromDate.CalendarTimeProperties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("FromDate.CalendarTimeProperties.NullValuePromptShowForEmptyValue")));
            this.FromDate.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("FromDate.Mask.AutoComplete")));
            this.FromDate.Mask.BeepOnError = ((bool)(resources.GetObject("FromDate.Mask.BeepOnError")));
            this.FromDate.Mask.EditMask = resources.GetString("FromDate.Mask.EditMask");
            this.FromDate.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("FromDate.Mask.IgnoreMaskBlank")));
            this.FromDate.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("FromDate.Mask.MaskType")));
            this.FromDate.Mask.PlaceHolder = ((char)(resources.GetObject("FromDate.Mask.PlaceHolder")));
            this.FromDate.Mask.SaveLiteral = ((bool)(resources.GetObject("FromDate.Mask.SaveLiteral")));
            this.FromDate.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("FromDate.Mask.ShowPlaceHolders")));
            this.FromDate.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("FromDate.Mask.UseMaskAsDisplayFormat")));
            this.FromDate.Name = "FromDate";
            this.FromDate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // ToItem
            // 
            resources.ApplyResources(this.ToItem, "ToItem");
            this.ToItem.Edit = this.ToDate;
            this.ToItem.Id = 6;
            this.ToItem.Name = "ToItem";
            // 
            // ToDate
            // 
            resources.ApplyResources(this.ToDate, "ToDate");
            this.ToDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("ToDate.Buttons"))))});
            this.ToDate.CalendarTimeProperties.AccessibleDescription = resources.GetString("ToDate.CalendarTimeProperties.AccessibleDescription");
            this.ToDate.CalendarTimeProperties.AccessibleName = resources.GetString("ToDate.CalendarTimeProperties.AccessibleName");
            this.ToDate.CalendarTimeProperties.AutoHeight = ((bool)(resources.GetObject("ToDate.CalendarTimeProperties.AutoHeight")));
            this.ToDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("ToDate.CalendarTimeProperties.Buttons"))))});
            this.ToDate.CalendarTimeProperties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("ToDate.CalendarTimeProperties.Mask.AutoComplete")));
            this.ToDate.CalendarTimeProperties.Mask.BeepOnError = ((bool)(resources.GetObject("ToDate.CalendarTimeProperties.Mask.BeepOnError")));
            this.ToDate.CalendarTimeProperties.Mask.EditMask = resources.GetString("ToDate.CalendarTimeProperties.Mask.EditMask");
            this.ToDate.CalendarTimeProperties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("ToDate.CalendarTimeProperties.Mask.IgnoreMaskBlank")));
            this.ToDate.CalendarTimeProperties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("ToDate.CalendarTimeProperties.Mask.MaskType")));
            this.ToDate.CalendarTimeProperties.Mask.PlaceHolder = ((char)(resources.GetObject("ToDate.CalendarTimeProperties.Mask.PlaceHolder")));
            this.ToDate.CalendarTimeProperties.Mask.SaveLiteral = ((bool)(resources.GetObject("ToDate.CalendarTimeProperties.Mask.SaveLiteral")));
            this.ToDate.CalendarTimeProperties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("ToDate.CalendarTimeProperties.Mask.ShowPlaceHolders")));
            this.ToDate.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("ToDate.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat")));
            this.ToDate.CalendarTimeProperties.NullValuePrompt = resources.GetString("ToDate.CalendarTimeProperties.NullValuePrompt");
            this.ToDate.CalendarTimeProperties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("ToDate.CalendarTimeProperties.NullValuePromptShowForEmptyValue")));
            this.ToDate.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("ToDate.Mask.AutoComplete")));
            this.ToDate.Mask.BeepOnError = ((bool)(resources.GetObject("ToDate.Mask.BeepOnError")));
            this.ToDate.Mask.EditMask = resources.GetString("ToDate.Mask.EditMask");
            this.ToDate.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("ToDate.Mask.IgnoreMaskBlank")));
            this.ToDate.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("ToDate.Mask.MaskType")));
            this.ToDate.Mask.PlaceHolder = ((char)(resources.GetObject("ToDate.Mask.PlaceHolder")));
            this.ToDate.Mask.SaveLiteral = ((bool)(resources.GetObject("ToDate.Mask.SaveLiteral")));
            this.ToDate.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("ToDate.Mask.ShowPlaceHolders")));
            this.ToDate.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("ToDate.Mask.UseMaskAsDisplayFormat")));
            this.ToDate.Name = "ToDate";
            // 
            // btnDisplaySpecifiedSales
            // 
            resources.ApplyResources(this.btnDisplaySpecifiedSales, "btnDisplaySpecifiedSales");
            this.btnDisplaySpecifiedSales.Id = 7;
            this.btnDisplaySpecifiedSales.Name = "btnDisplaySpecifiedSales";
            this.btnDisplaySpecifiedSales.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDisplaySpecifiedSales_ItemClick);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.Glyph")));
            this.btnPrint.Id = 8;
            this.btnPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.LargeGlyph")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAllSalesInvoices);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCashSalesInvoices, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAccrualSalesInvoices, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.FromItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.ToItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDisplaySpecifiedSales);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnPrint);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            resources.ApplyResources(this.ribbonPageGroup5, "ribbonPageGroup5");
            // 
            // repositoryItemTextEdit1
            // 
            resources.ApplyResources(this.repositoryItemTextEdit1, "repositoryItemTextEdit1");
            this.repositoryItemTextEdit1.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("repositoryItemTextEdit1.Mask.AutoComplete")));
            this.repositoryItemTextEdit1.Mask.BeepOnError = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.BeepOnError")));
            this.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask");
            this.repositoryItemTextEdit1.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.IgnoreMaskBlank")));
            this.repositoryItemTextEdit1.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("repositoryItemTextEdit1.Mask.MaskType")));
            this.repositoryItemTextEdit1.Mask.PlaceHolder = ((char)(resources.GetObject("repositoryItemTextEdit1.Mask.PlaceHolder")));
            this.repositoryItemTextEdit1.Mask.SaveLiteral = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.SaveLiteral")));
            this.repositoryItemTextEdit1.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.ShowPlaceHolders")));
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat")));
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            resources.ApplyResources(this.repositoryItemSearchLookUpEdit1, "repositoryItemSearchLookUpEdit1");
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemSearchLookUpEdit1.Buttons"))))});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            resources.ApplyResources(this.repositoryItemSearchLookUpEdit1View, "repositoryItemSearchLookUpEdit1View");
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            // 
            // SalesGrid
            // 
            resources.ApplyResources(this.SalesGrid, "SalesGrid");
            this.SalesGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("SalesGrid.EmbeddedNavigator.AccessibleDescription");
            this.SalesGrid.EmbeddedNavigator.AccessibleName = resources.GetString("SalesGrid.EmbeddedNavigator.AccessibleName");
            this.SalesGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("SalesGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.SalesGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("SalesGrid.EmbeddedNavigator.Anchor")));
            this.SalesGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalesGrid.EmbeddedNavigator.BackgroundImage")));
            this.SalesGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("SalesGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.SalesGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("SalesGrid.EmbeddedNavigator.ImeMode")));
            this.SalesGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("SalesGrid.EmbeddedNavigator.MaximumSize")));
            this.SalesGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("SalesGrid.EmbeddedNavigator.TextLocation")));
            this.SalesGrid.EmbeddedNavigator.ToolTip = resources.GetString("SalesGrid.EmbeddedNavigator.ToolTip");
            this.SalesGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("SalesGrid.EmbeddedNavigator.ToolTipIconType")));
            this.SalesGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("SalesGrid.EmbeddedNavigator.ToolTipTitle");
            this.SalesGrid.MainView = this.SalesView;
            this.SalesGrid.MenuManager = this.ribbon;
            this.SalesGrid.Name = "SalesGrid";
            this.SalesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SalesView});
            // 
            // SalesView
            // 
            this.SalesView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("SalesView.Appearance.Row.FontSizeDelta")));
            this.SalesView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SalesView.Appearance.Row.FontStyleDelta")));
            this.SalesView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SalesView.Appearance.Row.GradientMode")));
            this.SalesView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("SalesView.Appearance.Row.Image")));
            this.SalesView.Appearance.Row.Options.UseTextOptions = true;
            this.SalesView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SalesView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SalesView.AppearancePrint.Row.FontSizeDelta = ((int)(resources.GetObject("SalesView.AppearancePrint.Row.FontSizeDelta")));
            this.SalesView.AppearancePrint.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SalesView.AppearancePrint.Row.FontStyleDelta")));
            this.SalesView.AppearancePrint.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SalesView.AppearancePrint.Row.GradientMode")));
            this.SalesView.AppearancePrint.Row.Image = ((System.Drawing.Image)(resources.GetObject("SalesView.AppearancePrint.Row.Image")));
            this.SalesView.AppearancePrint.Row.Options.UseTextOptions = true;
            this.SalesView.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SalesView.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.SalesView, "SalesView");
            this.SalesView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.SalesView.GridControl = this.SalesGrid;
            this.SalesView.Name = "SalesView";
            this.SalesView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.SalesView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.SalesView.OptionsBehavior.Editable = false;
            this.SalesView.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.SalesView.OptionsPrint.PrintDetails = true;
            this.SalesView.OptionsPrint.PrintPreview = true;
            this.SalesView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.SalesView.OptionsView.EnableAppearanceEvenRow = true;
            this.SalesView.OptionsView.EnableAppearanceOddRow = true;
            this.SalesView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.SalesView.OptionsView.ShowAutoFilterRow = true;
            // 
            // FRM_Sales
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SalesGrid);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "FRM_Sales";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnAllSalesInvoices;
        private DevExpress.XtraBars.BarButtonItem btnCashSalesInvoices;
        private DevExpress.XtraBars.BarButtonItem btnAccrualSalesInvoices;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarEditItem FromItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit FromDate;
        private DevExpress.XtraBars.BarEditItem ToItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ToDate;
        private DevExpress.XtraBars.BarButtonItem btnDisplaySpecifiedSales;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.GridControl SalesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView SalesView;
    }
}