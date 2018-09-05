namespace UILayer.Accounts
{
    partial class FRM_TransactionLines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TransactionLines));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnPost = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.OverViewPage = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.OffsetAccount = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OffsetDeminsions = new DevExpress.XtraEditors.PanelControl();
            this.AccountDeminsions = new DevExpress.XtraEditors.PanelControl();
            this.cmbOffsetType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.spCreditAmount = new DevExpress.XtraEditors.SpinEdit();
            this.spDebitAmount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbAccountType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.deLineDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Account = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.LinesGrid = new DevExpress.XtraGrid.GridControl();
            this.LinesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LineCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TransCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LineDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DebitAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreditAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OffsetAccType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OffsetAccName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.OverViewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetDeminsions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDeminsions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffsetType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCreditAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDebitAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deLineDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deLineDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Account.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinesView)).BeginInit();
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
            this.btnDelete,
            this.btnPost});
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAddNew
            // 
            resources.ApplyResources(this.btnAddNew, "btnAddNew");
            this.btnAddNew.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Glyph")));
            this.btnAddNew.Id = 1;
            this.btnAddNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddNew.LargeGlyph")));
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNew_ItemClick);
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
            // btnPost
            // 
            resources.ApplyResources(this.btnPost, "btnPost");
            this.btnPost.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPost.Glyph")));
            this.btnPost.Id = 5;
            this.btnPost.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPost.LargeGlyph")));
            this.btnPost.Name = "btnPost";
            this.btnPost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPost_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPost, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // repositoryItemComboBox1
            // 
            resources.ApplyResources(this.repositoryItemComboBox1, "repositoryItemComboBox1");
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemComboBox1.Buttons"))))});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            resources.GetString("repositoryItemComboBox1.Items"),
            resources.GetString("repositoryItemComboBox1.Items1")});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
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
            this.OverViewPage.Controls.Add(this.panelControl1);
            this.OverViewPage.Controls.Add(this.LinesGrid);
            this.OverViewPage.Name = "OverViewPage";
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.OffsetAccount);
            this.panelControl1.Controls.Add(this.OffsetDeminsions);
            this.panelControl1.Controls.Add(this.AccountDeminsions);
            this.panelControl1.Controls.Add(this.cmbOffsetType);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.txtTransCode);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtDescription);
            this.panelControl1.Controls.Add(this.spCreditAmount);
            this.panelControl1.Controls.Add(this.spDebitAmount);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.cmbAccountType);
            this.panelControl1.Controls.Add(this.deLineDate);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.Account);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Name = "panelControl1";
            // 
            // OffsetAccount
            // 
            resources.ApplyResources(this.OffsetAccount, "OffsetAccount");
            this.OffsetAccount.MenuManager = this.ribbon;
            this.OffsetAccount.Name = "OffsetAccount";
            this.OffsetAccount.Properties.AccessibleDescription = resources.GetString("OffsetAccount.Properties.AccessibleDescription");
            this.OffsetAccount.Properties.AccessibleName = resources.GetString("OffsetAccount.Properties.AccessibleName");
            this.OffsetAccount.Properties.AutoHeight = ((bool)(resources.GetObject("OffsetAccount.Properties.AutoHeight")));
            this.OffsetAccount.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.OffsetAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("OffsetAccount.Properties.Buttons"))))});
            this.OffsetAccount.Properties.NullText = resources.GetString("OffsetAccount.Properties.NullText");
            this.OffsetAccount.Properties.NullValuePrompt = resources.GetString("OffsetAccount.Properties.NullValuePrompt");
            this.OffsetAccount.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("OffsetAccount.Properties.NullValuePromptShowForEmptyValue")));
            this.OffsetAccount.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always;
            this.OffsetAccount.Properties.View = this.gridView1;
            this.OffsetAccount.EditValueChanged += new System.EventHandler(this.OffsetAccount_EditValueChanged);
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // OffsetDeminsions
            // 
            resources.ApplyResources(this.OffsetDeminsions, "OffsetDeminsions");
            this.OffsetDeminsions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.OffsetDeminsions.Name = "OffsetDeminsions";
            // 
            // AccountDeminsions
            // 
            resources.ApplyResources(this.AccountDeminsions, "AccountDeminsions");
            this.AccountDeminsions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.AccountDeminsions.Name = "AccountDeminsions";
            // 
            // cmbOffsetType
            // 
            resources.ApplyResources(this.cmbOffsetType, "cmbOffsetType");
            this.cmbOffsetType.MenuManager = this.ribbon;
            this.cmbOffsetType.Name = "cmbOffsetType";
            this.cmbOffsetType.Properties.AccessibleDescription = resources.GetString("cmbOffsetType.Properties.AccessibleDescription");
            this.cmbOffsetType.Properties.AccessibleName = resources.GetString("cmbOffsetType.Properties.AccessibleName");
            this.cmbOffsetType.Properties.AutoHeight = ((bool)(resources.GetObject("cmbOffsetType.Properties.AutoHeight")));
            this.cmbOffsetType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cmbOffsetType.Properties.Buttons"))))});
            this.cmbOffsetType.Properties.NullValuePrompt = resources.GetString("cmbOffsetType.Properties.NullValuePrompt");
            this.cmbOffsetType.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("cmbOffsetType.Properties.NullValuePromptShowForEmptyValue")));
            this.cmbOffsetType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbOffsetType.SelectedIndexChanged += new System.EventHandler(this.cmbOffsetType_SelectedIndexChanged);
            // 
            // labelControl9
            // 
            resources.ApplyResources(this.labelControl9, "labelControl9");
            this.labelControl9.Name = "labelControl9";
            // 
            // txtTransCode
            // 
            resources.ApplyResources(this.txtTransCode, "txtTransCode");
            this.txtTransCode.MenuManager = this.ribbon;
            this.txtTransCode.Name = "txtTransCode";
            this.txtTransCode.Properties.AccessibleDescription = resources.GetString("txtTransCode.Properties.AccessibleDescription");
            this.txtTransCode.Properties.AccessibleName = resources.GetString("txtTransCode.Properties.AccessibleName");
            this.txtTransCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtTransCode.Properties.AutoHeight")));
            this.txtTransCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtTransCode.Properties.Mask.AutoComplete")));
            this.txtTransCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtTransCode.Properties.Mask.BeepOnError")));
            this.txtTransCode.Properties.Mask.EditMask = resources.GetString("txtTransCode.Properties.Mask.EditMask");
            this.txtTransCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtTransCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtTransCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtTransCode.Properties.Mask.MaskType")));
            this.txtTransCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtTransCode.Properties.Mask.PlaceHolder")));
            this.txtTransCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtTransCode.Properties.Mask.SaveLiteral")));
            this.txtTransCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtTransCode.Properties.Mask.ShowPlaceHolders")));
            this.txtTransCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtTransCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtTransCode.Properties.NullValuePrompt = resources.GetString("txtTransCode.Properties.NullValuePrompt");
            this.txtTransCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtTransCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // labelControl8
            // 
            resources.ApplyResources(this.labelControl8, "labelControl8");
            this.labelControl8.Name = "labelControl8";
            // 
            // labelControl7
            // 
            resources.ApplyResources(this.labelControl7, "labelControl7");
            this.labelControl7.Name = "labelControl7";
            // 
            // labelControl6
            // 
            resources.ApplyResources(this.labelControl6, "labelControl6");
            this.labelControl6.Name = "labelControl6";
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // labelControl5
            // 
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.MenuManager = this.ribbon;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.AccessibleDescription = resources.GetString("txtDescription.Properties.AccessibleDescription");
            this.txtDescription.Properties.AccessibleName = resources.GetString("txtDescription.Properties.AccessibleName");
            this.txtDescription.Properties.AutoHeight = ((bool)(resources.GetObject("txtDescription.Properties.AutoHeight")));
            this.txtDescription.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtDescription.Properties.Mask.AutoComplete")));
            this.txtDescription.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtDescription.Properties.Mask.BeepOnError")));
            this.txtDescription.Properties.Mask.EditMask = resources.GetString("txtDescription.Properties.Mask.EditMask");
            this.txtDescription.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtDescription.Properties.Mask.IgnoreMaskBlank")));
            this.txtDescription.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtDescription.Properties.Mask.MaskType")));
            this.txtDescription.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtDescription.Properties.Mask.PlaceHolder")));
            this.txtDescription.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtDescription.Properties.Mask.SaveLiteral")));
            this.txtDescription.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtDescription.Properties.Mask.ShowPlaceHolders")));
            this.txtDescription.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtDescription.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtDescription.Properties.NullValuePrompt = resources.GetString("txtDescription.Properties.NullValuePrompt");
            this.txtDescription.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtDescription.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // spCreditAmount
            // 
            resources.ApplyResources(this.spCreditAmount, "spCreditAmount");
            this.spCreditAmount.MenuManager = this.ribbon;
            this.spCreditAmount.Name = "spCreditAmount";
            this.spCreditAmount.Properties.AccessibleDescription = resources.GetString("spCreditAmount.Properties.AccessibleDescription");
            this.spCreditAmount.Properties.AccessibleName = resources.GetString("spCreditAmount.Properties.AccessibleName");
            this.spCreditAmount.Properties.AutoHeight = ((bool)(resources.GetObject("spCreditAmount.Properties.AutoHeight")));
            this.spCreditAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("spCreditAmount.Properties.Buttons"))))});
            this.spCreditAmount.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("spCreditAmount.Properties.Mask.AutoComplete")));
            this.spCreditAmount.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("spCreditAmount.Properties.Mask.BeepOnError")));
            this.spCreditAmount.Properties.Mask.EditMask = resources.GetString("spCreditAmount.Properties.Mask.EditMask");
            this.spCreditAmount.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("spCreditAmount.Properties.Mask.IgnoreMaskBlank")));
            this.spCreditAmount.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("spCreditAmount.Properties.Mask.MaskType")));
            this.spCreditAmount.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("spCreditAmount.Properties.Mask.PlaceHolder")));
            this.spCreditAmount.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("spCreditAmount.Properties.Mask.SaveLiteral")));
            this.spCreditAmount.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("spCreditAmount.Properties.Mask.ShowPlaceHolders")));
            this.spCreditAmount.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("spCreditAmount.Properties.Mask.UseMaskAsDisplayFormat")));
            this.spCreditAmount.Properties.NullValuePrompt = resources.GetString("spCreditAmount.Properties.NullValuePrompt");
            this.spCreditAmount.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("spCreditAmount.Properties.NullValuePromptShowForEmptyValue")));
            this.spCreditAmount.EditValueChanged += new System.EventHandler(this.spCreditAmount_EditValueChanged);
            // 
            // spDebitAmount
            // 
            resources.ApplyResources(this.spDebitAmount, "spDebitAmount");
            this.spDebitAmount.MenuManager = this.ribbon;
            this.spDebitAmount.Name = "spDebitAmount";
            this.spDebitAmount.Properties.AccessibleDescription = resources.GetString("spDebitAmount.Properties.AccessibleDescription");
            this.spDebitAmount.Properties.AccessibleName = resources.GetString("spDebitAmount.Properties.AccessibleName");
            this.spDebitAmount.Properties.AutoHeight = ((bool)(resources.GetObject("spDebitAmount.Properties.AutoHeight")));
            this.spDebitAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("spDebitAmount.Properties.Buttons"))))});
            this.spDebitAmount.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("spDebitAmount.Properties.Mask.AutoComplete")));
            this.spDebitAmount.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("spDebitAmount.Properties.Mask.BeepOnError")));
            this.spDebitAmount.Properties.Mask.EditMask = resources.GetString("spDebitAmount.Properties.Mask.EditMask");
            this.spDebitAmount.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("spDebitAmount.Properties.Mask.IgnoreMaskBlank")));
            this.spDebitAmount.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("spDebitAmount.Properties.Mask.MaskType")));
            this.spDebitAmount.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("spDebitAmount.Properties.Mask.PlaceHolder")));
            this.spDebitAmount.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("spDebitAmount.Properties.Mask.SaveLiteral")));
            this.spDebitAmount.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("spDebitAmount.Properties.Mask.ShowPlaceHolders")));
            this.spDebitAmount.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("spDebitAmount.Properties.Mask.UseMaskAsDisplayFormat")));
            this.spDebitAmount.Properties.NullValuePrompt = resources.GetString("spDebitAmount.Properties.NullValuePrompt");
            this.spDebitAmount.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("spDebitAmount.Properties.NullValuePromptShowForEmptyValue")));
            this.spDebitAmount.EditValueChanged += new System.EventHandler(this.spDebitAmount_EditValueChanged);
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // cmbAccountType
            // 
            resources.ApplyResources(this.cmbAccountType, "cmbAccountType");
            this.cmbAccountType.MenuManager = this.ribbon;
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Properties.AccessibleDescription = resources.GetString("cmbAccountType.Properties.AccessibleDescription");
            this.cmbAccountType.Properties.AccessibleName = resources.GetString("cmbAccountType.Properties.AccessibleName");
            this.cmbAccountType.Properties.AutoHeight = ((bool)(resources.GetObject("cmbAccountType.Properties.AutoHeight")));
            this.cmbAccountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cmbAccountType.Properties.Buttons"))))});
            this.cmbAccountType.Properties.NullValuePrompt = resources.GetString("cmbAccountType.Properties.NullValuePrompt");
            this.cmbAccountType.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("cmbAccountType.Properties.NullValuePromptShowForEmptyValue")));
            this.cmbAccountType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbAccountType.SelectedIndexChanged += new System.EventHandler(this.cmbAccountType_SelectedIndexChanged);
            // 
            // deLineDate
            // 
            resources.ApplyResources(this.deLineDate, "deLineDate");
            this.deLineDate.MenuManager = this.ribbon;
            this.deLineDate.Name = "deLineDate";
            this.deLineDate.Properties.AccessibleDescription = resources.GetString("deLineDate.Properties.AccessibleDescription");
            this.deLineDate.Properties.AccessibleName = resources.GetString("deLineDate.Properties.AccessibleName");
            this.deLineDate.Properties.AutoHeight = ((bool)(resources.GetObject("deLineDate.Properties.AutoHeight")));
            this.deLineDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("deLineDate.Properties.Buttons"))))});
            this.deLineDate.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("deLineDate.Properties.CalendarTimeProperties.AccessibleDescription");
            this.deLineDate.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("deLineDate.Properties.CalendarTimeProperties.AccessibleName");
            this.deLineDate.Properties.CalendarTimeProperties.AutoHeight = ((bool)(resources.GetObject("deLineDate.Properties.CalendarTimeProperties.AutoHeight")));
            this.deLineDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("deLineDate.Properties.CalendarTimeProperties.Buttons"))))});
            this.deLineDate.Properties.CalendarTimeProperties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("deLineDate.Properties.CalendarTimeProperties.Mask.AutoComplete")));
            this.deLineDate.Properties.CalendarTimeProperties.Mask.BeepOnError = ((bool)(resources.GetObject("deLineDate.Properties.CalendarTimeProperties.Mask.BeepOnError")));
            this.deLineDate.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("deLineDate.Properties.CalendarTimeProperties.Mask.EditMask");
            this.deLineDate.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("deLineDate.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank")));
            this.deLineDate.Properties.CalendarTimeProperties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("deLineDate.Properties.CalendarTimeProperties.Mask.MaskType")));
            this.deLineDate.Properties.CalendarTimeProperties.Mask.PlaceHolder = ((char)(resources.GetObject("deLineDate.Properties.CalendarTimeProperties.Mask.PlaceHolder")));
            this.deLineDate.Properties.CalendarTimeProperties.Mask.SaveLiteral = ((bool)(resources.GetObject("deLineDate.Properties.CalendarTimeProperties.Mask.SaveLiteral")));
            this.deLineDate.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("deLineDate.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders")));
            this.deLineDate.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("deLineDate.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat")));
            this.deLineDate.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("deLineDate.Properties.CalendarTimeProperties.NullValuePrompt");
            this.deLineDate.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("deLineDate.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue")));
            this.deLineDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.deLineDate.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("deLineDate.Properties.Mask.AutoComplete")));
            this.deLineDate.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("deLineDate.Properties.Mask.BeepOnError")));
            this.deLineDate.Properties.Mask.EditMask = resources.GetString("deLineDate.Properties.Mask.EditMask");
            this.deLineDate.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("deLineDate.Properties.Mask.IgnoreMaskBlank")));
            this.deLineDate.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("deLineDate.Properties.Mask.MaskType")));
            this.deLineDate.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("deLineDate.Properties.Mask.PlaceHolder")));
            this.deLineDate.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("deLineDate.Properties.Mask.SaveLiteral")));
            this.deLineDate.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("deLineDate.Properties.Mask.ShowPlaceHolders")));
            this.deLineDate.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("deLineDate.Properties.Mask.UseMaskAsDisplayFormat")));
            this.deLineDate.Properties.NullValuePrompt = resources.GetString("deLineDate.Properties.NullValuePrompt");
            this.deLineDate.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("deLineDate.Properties.NullValuePromptShowForEmptyValue")));
            this.deLineDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // Account
            // 
            resources.ApplyResources(this.Account, "Account");
            this.Account.MenuManager = this.ribbon;
            this.Account.Name = "Account";
            this.Account.Properties.AccessibleDescription = resources.GetString("Account.Properties.AccessibleDescription");
            this.Account.Properties.AccessibleName = resources.GetString("Account.Properties.AccessibleName");
            this.Account.Properties.AutoHeight = ((bool)(resources.GetObject("Account.Properties.AutoHeight")));
            this.Account.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.Account.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("Account.Properties.Buttons"))))});
            this.Account.Properties.NullText = resources.GetString("Account.Properties.NullText");
            this.Account.Properties.NullValuePrompt = resources.GetString("Account.Properties.NullValuePrompt");
            this.Account.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("Account.Properties.NullValuePromptShowForEmptyValue")));
            this.Account.Properties.View = this.searchLookUpEdit1View;
            this.Account.EditValueChanged += new System.EventHandler(this.Account_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            resources.ApplyResources(this.searchLookUpEdit1View, "searchLookUpEdit1View");
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.LinesGrid.UseEmbeddedNavigator = true;
            this.LinesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LinesView});
            // 
            // LinesView
            // 
            resources.ApplyResources(this.LinesView, "LinesView");
            this.LinesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LineCode,
            this.TransCode,
            this.LineDate,
            this.AccType,
            this.AccName,
            this.DebitAmount,
            this.CreditAmount,
            this.Description,
            this.OffsetAccType,
            this.OffsetAccName});
            this.LinesView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.LinesView.GridControl = this.LinesGrid;
            this.LinesView.Name = "LinesView";
            this.LinesView.OptionsBehavior.Editable = false;
            this.LinesView.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.LinesView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.LinesView.OptionsView.EnableAppearanceEvenRow = true;
            this.LinesView.OptionsView.EnableAppearanceOddRow = true;
            this.LinesView.OptionsView.ShowAutoFilterRow = true;
            this.LinesView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // LineCode
            // 
            this.LineCode.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("LineCode.AppearanceCell.FontSizeDelta")));
            this.LineCode.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("LineCode.AppearanceCell.FontStyleDelta")));
            this.LineCode.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("LineCode.AppearanceCell.GradientMode")));
            this.LineCode.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("LineCode.AppearanceCell.Image")));
            this.LineCode.AppearanceCell.Options.UseTextOptions = true;
            this.LineCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LineCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LineCode.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("LineCode.AppearanceHeader.FontSizeDelta")));
            this.LineCode.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("LineCode.AppearanceHeader.FontStyleDelta")));
            this.LineCode.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("LineCode.AppearanceHeader.GradientMode")));
            this.LineCode.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("LineCode.AppearanceHeader.Image")));
            this.LineCode.AppearanceHeader.Options.UseTextOptions = true;
            this.LineCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LineCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.LineCode, "LineCode");
            this.LineCode.FieldName = "v1";
            this.LineCode.Name = "LineCode";
            // 
            // TransCode
            // 
            this.TransCode.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("TransCode.AppearanceCell.FontSizeDelta")));
            this.TransCode.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("TransCode.AppearanceCell.FontStyleDelta")));
            this.TransCode.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("TransCode.AppearanceCell.GradientMode")));
            this.TransCode.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("TransCode.AppearanceCell.Image")));
            this.TransCode.AppearanceCell.Options.UseTextOptions = true;
            this.TransCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TransCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TransCode.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("TransCode.AppearanceHeader.FontSizeDelta")));
            this.TransCode.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("TransCode.AppearanceHeader.FontStyleDelta")));
            this.TransCode.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("TransCode.AppearanceHeader.GradientMode")));
            this.TransCode.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("TransCode.AppearanceHeader.Image")));
            this.TransCode.AppearanceHeader.Options.UseTextOptions = true;
            this.TransCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TransCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.TransCode, "TransCode");
            this.TransCode.FieldName = "v2";
            this.TransCode.Name = "TransCode";
            this.TransCode.OptionsColumn.AllowEdit = false;
            this.TransCode.OptionsColumn.FixedWidth = true;
            // 
            // LineDate
            // 
            this.LineDate.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("LineDate.AppearanceCell.FontSizeDelta")));
            this.LineDate.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("LineDate.AppearanceCell.FontStyleDelta")));
            this.LineDate.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("LineDate.AppearanceCell.GradientMode")));
            this.LineDate.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("LineDate.AppearanceCell.Image")));
            this.LineDate.AppearanceCell.Options.UseTextOptions = true;
            this.LineDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LineDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LineDate.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("LineDate.AppearanceHeader.FontSizeDelta")));
            this.LineDate.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("LineDate.AppearanceHeader.FontStyleDelta")));
            this.LineDate.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("LineDate.AppearanceHeader.GradientMode")));
            this.LineDate.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("LineDate.AppearanceHeader.Image")));
            this.LineDate.AppearanceHeader.Options.UseTextOptions = true;
            this.LineDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LineDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.LineDate, "LineDate");
            this.LineDate.FieldName = "v3";
            this.LineDate.Name = "LineDate";
            this.LineDate.OptionsColumn.FixedWidth = true;
            // 
            // AccType
            // 
            this.AccType.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("AccType.AppearanceCell.FontSizeDelta")));
            this.AccType.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccType.AppearanceCell.FontStyleDelta")));
            this.AccType.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccType.AppearanceCell.GradientMode")));
            this.AccType.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("AccType.AppearanceCell.Image")));
            this.AccType.AppearanceCell.Options.UseTextOptions = true;
            this.AccType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccType.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("AccType.AppearanceHeader.FontSizeDelta")));
            this.AccType.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccType.AppearanceHeader.FontStyleDelta")));
            this.AccType.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccType.AppearanceHeader.GradientMode")));
            this.AccType.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("AccType.AppearanceHeader.Image")));
            this.AccType.AppearanceHeader.Options.UseTextOptions = true;
            this.AccType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccType.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.AccType, "AccType");
            this.AccType.FieldName = "v4";
            this.AccType.Name = "AccType";
            this.AccType.OptionsColumn.FixedWidth = true;
            // 
            // AccName
            // 
            this.AccName.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("AccName.AppearanceCell.FontSizeDelta")));
            this.AccName.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccName.AppearanceCell.FontStyleDelta")));
            this.AccName.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccName.AppearanceCell.GradientMode")));
            this.AccName.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("AccName.AppearanceCell.Image")));
            this.AccName.AppearanceCell.Options.UseTextOptions = true;
            this.AccName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccName.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("AccName.AppearanceHeader.FontSizeDelta")));
            this.AccName.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("AccName.AppearanceHeader.FontStyleDelta")));
            this.AccName.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("AccName.AppearanceHeader.GradientMode")));
            this.AccName.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("AccName.AppearanceHeader.Image")));
            this.AccName.AppearanceHeader.Options.UseTextOptions = true;
            this.AccName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.AccName, "AccName");
            this.AccName.FieldName = "v5";
            this.AccName.Name = "AccName";
            this.AccName.OptionsColumn.FixedWidth = true;
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
            this.DebitAmount.FieldName = "v6";
            this.DebitAmount.Name = "DebitAmount";
            this.DebitAmount.OptionsColumn.FixedWidth = true;
            this.DebitAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
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
            this.CreditAmount.FieldName = "v7";
            this.CreditAmount.Name = "CreditAmount";
            this.CreditAmount.OptionsColumn.FixedWidth = true;
            this.CreditAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
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
            this.Description.FieldName = "v8";
            this.Description.Name = "Description";
            // 
            // OffsetAccType
            // 
            this.OffsetAccType.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("OffsetAccType.AppearanceCell.FontSizeDelta")));
            this.OffsetAccType.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("OffsetAccType.AppearanceCell.FontStyleDelta")));
            this.OffsetAccType.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("OffsetAccType.AppearanceCell.GradientMode")));
            this.OffsetAccType.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("OffsetAccType.AppearanceCell.Image")));
            this.OffsetAccType.AppearanceCell.Options.UseTextOptions = true;
            this.OffsetAccType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OffsetAccType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.OffsetAccType.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("OffsetAccType.AppearanceHeader.FontSizeDelta")));
            this.OffsetAccType.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("OffsetAccType.AppearanceHeader.FontStyleDelta")));
            this.OffsetAccType.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("OffsetAccType.AppearanceHeader.GradientMode")));
            this.OffsetAccType.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("OffsetAccType.AppearanceHeader.Image")));
            this.OffsetAccType.AppearanceHeader.Options.UseTextOptions = true;
            this.OffsetAccType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OffsetAccType.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.OffsetAccType, "OffsetAccType");
            this.OffsetAccType.FieldName = "v9";
            this.OffsetAccType.Name = "OffsetAccType";
            this.OffsetAccType.OptionsColumn.FixedWidth = true;
            // 
            // OffsetAccName
            // 
            this.OffsetAccName.AppearanceCell.FontSizeDelta = ((int)(resources.GetObject("OffsetAccName.AppearanceCell.FontSizeDelta")));
            this.OffsetAccName.AppearanceCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("OffsetAccName.AppearanceCell.FontStyleDelta")));
            this.OffsetAccName.AppearanceCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("OffsetAccName.AppearanceCell.GradientMode")));
            this.OffsetAccName.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("OffsetAccName.AppearanceCell.Image")));
            this.OffsetAccName.AppearanceCell.Options.UseTextOptions = true;
            this.OffsetAccName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OffsetAccName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.OffsetAccName.AppearanceHeader.FontSizeDelta = ((int)(resources.GetObject("OffsetAccName.AppearanceHeader.FontSizeDelta")));
            this.OffsetAccName.AppearanceHeader.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("OffsetAccName.AppearanceHeader.FontStyleDelta")));
            this.OffsetAccName.AppearanceHeader.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("OffsetAccName.AppearanceHeader.GradientMode")));
            this.OffsetAccName.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("OffsetAccName.AppearanceHeader.Image")));
            this.OffsetAccName.AppearanceHeader.Options.UseTextOptions = true;
            this.OffsetAccName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OffsetAccName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.OffsetAccName, "OffsetAccName");
            this.OffsetAccName.FieldName = "v10";
            this.OffsetAccName.Name = "OffsetAccName";
            this.OffsetAccName.OptionsColumn.FixedWidth = true;
            // 
            // FRM_TransactionLines
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.MaximizeBox = false;
            this.Name = "FRM_TransactionLines";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_TransactionLines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.OverViewPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetDeminsions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDeminsions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffsetType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCreditAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDebitAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deLineDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deLineDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Account.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage OverViewPage;
        private DevExpress.XtraGrid.GridControl LinesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView LinesView;
        private DevExpress.XtraGrid.Columns.GridColumn TransCode;
        private DevExpress.XtraGrid.Columns.GridColumn LineDate;
        private DevExpress.XtraGrid.Columns.GridColumn AccType;
        private DevExpress.XtraGrid.Columns.GridColumn AccName;
        private DevExpress.XtraGrid.Columns.GridColumn DebitAmount;
        private DevExpress.XtraGrid.Columns.GridColumn CreditAmount;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn OffsetAccType;
        private DevExpress.XtraGrid.Columns.GridColumn OffsetAccName;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn LineCode;
        private DevExpress.XtraBars.BarButtonItem btnPost;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit OffsetAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl OffsetDeminsions;
        private DevExpress.XtraEditors.PanelControl AccountDeminsions;
        private DevExpress.XtraEditors.ComboBoxEdit cmbOffsetType;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtTransCode;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.SpinEdit spCreditAmount;
        private DevExpress.XtraEditors.SpinEdit spDebitAmount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAccountType;
        private DevExpress.XtraEditors.DateEdit deLineDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit Account;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}