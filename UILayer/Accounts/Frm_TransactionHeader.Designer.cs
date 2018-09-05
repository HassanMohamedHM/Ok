namespace UILayer.Accounts
{
    partial class Frm_TransactionHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TransactionHeader));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnLines = new DevExpress.XtraBars.BarButtonItem();
            this.btnValidate = new DevExpress.XtraBars.BarButtonItem();
            this.btnPost = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.OverViewPage = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscription = new DevExpress.XtraEditors.TextEdit();
            this.JournalsName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.HeaderGrid = new DevExpress.XtraGrid.GridControl();
            this.HeaderView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JournalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JournalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Posted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chkUserGeneralJournals = new DevExpress.XtraEditors.CheckEdit();
            this.CmbGetGeneralJournals = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.OverViewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalsName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkUserGeneralJournals.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbGetGeneralJournals.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.btnLines,
            this.btnValidate,
            this.btnPost,
            this.btnPrint});
            this.ribbon.MaxItemId = 8;
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
            this.btnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.Glyph")));
            this.btnPrint.Id = 6;
            this.btnPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.LargeGlyph")));
            this.btnPrint.Name = "btnPrint";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLines, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnValidate, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPost, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPrint, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Name = "panelControl1";
            // 
            // xtraTabControl1
            // 
            resources.ApplyResources(this.xtraTabControl1, "xtraTabControl1");
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.OverViewPage;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.OverViewPage});
            // 
            // OverViewPage
            // 
            resources.ApplyResources(this.OverViewPage, "OverViewPage");
            this.OverViewPage.Controls.Add(this.panelControl3);
            this.OverViewPage.Controls.Add(this.HeaderGrid);
            this.OverViewPage.Name = "OverViewPage";
            // 
            // panelControl3
            // 
            resources.ApplyResources(this.panelControl3, "panelControl3");
            this.panelControl3.Controls.Add(this.btnCancel);
            this.panelControl3.Controls.Add(this.btnSave);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.txtDiscription);
            this.panelControl3.Controls.Add(this.JournalsName);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Name = "panelControl3";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // txtDiscription
            // 
            resources.ApplyResources(this.txtDiscription, "txtDiscription");
            this.txtDiscription.MenuManager = this.ribbon;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Properties.AccessibleDescription = resources.GetString("txtDiscription.Properties.AccessibleDescription");
            this.txtDiscription.Properties.AccessibleName = resources.GetString("txtDiscription.Properties.AccessibleName");
            this.txtDiscription.Properties.AutoHeight = ((bool)(resources.GetObject("txtDiscription.Properties.AutoHeight")));
            this.txtDiscription.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtDiscription.Properties.Mask.AutoComplete")));
            this.txtDiscription.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtDiscription.Properties.Mask.BeepOnError")));
            this.txtDiscription.Properties.Mask.EditMask = resources.GetString("txtDiscription.Properties.Mask.EditMask");
            this.txtDiscription.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtDiscription.Properties.Mask.IgnoreMaskBlank")));
            this.txtDiscription.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtDiscription.Properties.Mask.MaskType")));
            this.txtDiscription.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtDiscription.Properties.Mask.PlaceHolder")));
            this.txtDiscription.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtDiscription.Properties.Mask.SaveLiteral")));
            this.txtDiscription.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtDiscription.Properties.Mask.ShowPlaceHolders")));
            this.txtDiscription.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtDiscription.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtDiscription.Properties.NullValuePrompt = resources.GetString("txtDiscription.Properties.NullValuePrompt");
            this.txtDiscription.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtDiscription.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // JournalsName
            // 
            resources.ApplyResources(this.JournalsName, "JournalsName");
            this.JournalsName.MenuManager = this.ribbon;
            this.JournalsName.Name = "JournalsName";
            this.JournalsName.Properties.AccessibleDescription = resources.GetString("JournalsName.Properties.AccessibleDescription");
            this.JournalsName.Properties.AccessibleName = resources.GetString("JournalsName.Properties.AccessibleName");
            this.JournalsName.Properties.AutoHeight = ((bool)(resources.GetObject("JournalsName.Properties.AutoHeight")));
            this.JournalsName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("JournalsName.Properties.Buttons"))))});
            this.JournalsName.Properties.NullText = resources.GetString("JournalsName.Properties.NullText");
            this.JournalsName.Properties.NullValuePrompt = resources.GetString("JournalsName.Properties.NullValuePrompt");
            this.JournalsName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("JournalsName.Properties.NullValuePromptShowForEmptyValue")));
            this.JournalsName.Properties.View = this.searchLookUpEdit1View;
            this.JournalsName.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.JournalsName_Closed);
            // 
            // searchLookUpEdit1View
            // 
            resources.ApplyResources(this.searchLookUpEdit1View, "searchLookUpEdit1View");
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
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
            this.HeaderGrid.UseEmbeddedNavigator = true;
            this.HeaderGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HeaderView});
            // 
            // HeaderView
            // 
            resources.ApplyResources(this.HeaderView, "HeaderView");
            this.HeaderView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Code,
            this.JournalCode,
            this.JournalName,
            this.Discription,
            this.Posted});
            this.HeaderView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.HeaderView.GridControl = this.HeaderGrid;
            this.HeaderView.Name = "HeaderView";
            this.HeaderView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.HeaderView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.HeaderView.OptionsBehavior.Editable = false;
            this.HeaderView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.HeaderView.OptionsPrint.EnableAppearanceOddRow = true;
            this.HeaderView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.HeaderView.OptionsView.EnableAppearanceEvenRow = true;
            this.HeaderView.OptionsView.EnableAppearanceOddRow = true;
            this.HeaderView.OptionsView.ShowAutoFilterRow = true;
            this.HeaderView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.HeaderView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.HeaderView_RowClick);
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
            // 
            // JournalCode
            // 
            this.JournalCode.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("JournalCode.AppearanceCell.FontSizeDelta")));
            this.JournalCode.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalCode.AppearanceCell.FontStyleDelta")));
            this.JournalCode.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalCode.AppearanceCell.GradientMode")));
            this.JournalCode.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("JournalCode.AppearanceCell.Image")));
            this.JournalCode.AppearanceCell.Options.UseTextOptions = true;
            this.JournalCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalCode.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("JournalCode.AppearanceHeader.FontSizeDelta")));
            this.JournalCode.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalCode.AppearanceHeader.FontStyleDelta")));
            this.JournalCode.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalCode.AppearanceHeader.GradientMode")));
            this.JournalCode.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("JournalCode.AppearanceHeader.Image")));
            this.JournalCode.AppearanceHeader.Options.UseTextOptions = true;
            this.JournalCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.JournalCode, "JournalCode");
            this.JournalCode.FieldName = "v2";
            this.JournalCode.Name = "JournalCode";
            // 
            // JournalName
            // 
            this.JournalName.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("JournalName.AppearanceCell.FontSizeDelta")));
            this.JournalName.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalName.AppearanceCell.FontStyleDelta")));
            this.JournalName.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalName.AppearanceCell.GradientMode")));
            this.JournalName.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("JournalName.AppearanceCell.Image")));
            this.JournalName.AppearanceCell.Options.UseTextOptions = true;
            this.JournalName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalName.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("JournalName.AppearanceHeader.FontSizeDelta")));
            this.JournalName.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalName.AppearanceHeader.FontStyleDelta")));
            this.JournalName.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalName.AppearanceHeader.GradientMode")));
            this.JournalName.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("JournalName.AppearanceHeader.Image")));
            this.JournalName.AppearanceHeader.Options.UseTextOptions = true;
            this.JournalName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.JournalName, "JournalName");
            this.JournalName.FieldName = "v3";
            this.JournalName.Name = "JournalName";
            // 
            // Discription
            // 
            this.Discription.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("Discription.AppearanceCell.FontSizeDelta")));
            this.Discription.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Discription.AppearanceCell.FontStyleDelta")));
            this.Discription.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Discription.AppearanceCell.GradientMode")));
            this.Discription.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("Discription.AppearanceCell.Image")));
            this.Discription.AppearanceCell.Options.UseTextOptions = true;
            this.Discription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Discription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Discription.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("Discription.AppearanceHeader.FontSizeDelta")));
            this.Discription.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Discription.AppearanceHeader.FontStyleDelta")));
            this.Discription.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("Discription.AppearanceHeader.GradientMode")));
            this.Discription.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("Discription.AppearanceHeader.Image")));
            this.Discription.AppearanceHeader.Options.UseTextOptions = true;
            this.Discription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Discription.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.Discription, "Discription");
            this.Discription.FieldName = "v4";
            this.Discription.Name = "Discription";
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
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.chkUserGeneralJournals);
            this.panelControl2.Controls.Add(this.CmbGetGeneralJournals);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Name = "panelControl2";
            // 
            // chkUserGeneralJournals
            // 
            resources.ApplyResources(this.chkUserGeneralJournals, "chkUserGeneralJournals");
            this.chkUserGeneralJournals.MenuManager = this.ribbon;
            this.chkUserGeneralJournals.Name = "chkUserGeneralJournals";
            this.chkUserGeneralJournals.Properties.AccessibleDescription = resources.GetString("chkUserGeneralJournals.Properties.AccessibleDescription");
            this.chkUserGeneralJournals.Properties.AccessibleName = resources.GetString("chkUserGeneralJournals.Properties.AccessibleName");
            this.chkUserGeneralJournals.Properties.AutoHeight = ((bool)(resources.GetObject("chkUserGeneralJournals.Properties.AutoHeight")));
            this.chkUserGeneralJournals.Properties.Caption = resources.GetString("chkUserGeneralJournals.Properties.Caption");
            this.chkUserGeneralJournals.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style10;
            this.chkUserGeneralJournals.Properties.DisplayValueChecked = resources.GetString("chkUserGeneralJournals.Properties.DisplayValueChecked");
            this.chkUserGeneralJournals.Properties.DisplayValueGrayed = resources.GetString("chkUserGeneralJournals.Properties.DisplayValueGrayed");
            this.chkUserGeneralJournals.Properties.DisplayValueUnchecked = resources.GetString("chkUserGeneralJournals.Properties.DisplayValueUnchecked");
            this.chkUserGeneralJournals.Properties.GlyphAlignment = ((DevExpress.Utils.HorzAlignment)(resources.GetObject("chkUserGeneralJournals.Properties.GlyphAlignment")));
            this.chkUserGeneralJournals.CheckStateChanged += new System.EventHandler(this.chkUserGeneralJournals_CheckStateChanged);
            // 
            // CmbGetGeneralJournals
            // 
            resources.ApplyResources(this.CmbGetGeneralJournals, "CmbGetGeneralJournals");
            this.CmbGetGeneralJournals.MenuManager = this.ribbon;
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
            this.CmbGetGeneralJournals.SelectedIndexChanged += new System.EventHandler(this.CmbGetGeneralJournals_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // Frm_TransactionHeader
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_TransactionHeader";
            this.Ribbon = this.ribbon;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Frm_TransactionHeader_Activated);
            this.Load += new System.EventHandler(this.Frm_TransactionHeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.OverViewPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalsName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkUserGeneralJournals.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbGetGeneralJournals.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnLines;
        private DevExpress.XtraBars.BarButtonItem btnValidate;
        private DevExpress.XtraBars.BarButtonItem btnPost;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit chkUserGeneralJournals;
        private DevExpress.XtraEditors.ComboBoxEdit CmbGetGeneralJournals;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage OverViewPage;
        private DevExpress.XtraGrid.GridControl HeaderGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HeaderView;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn JournalCode;
        private DevExpress.XtraGrid.Columns.GridColumn JournalName;
        private DevExpress.XtraGrid.Columns.GridColumn Discription;
        private DevExpress.XtraGrid.Columns.GridColumn Posted;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDiscription;
        private DevExpress.XtraEditors.SearchLookUpEdit JournalsName;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}