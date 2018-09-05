namespace UILayer.Invoices
{
    partial class FRM_Vendor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Vendor));
            this.Group = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNotes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.City = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtMobile2 = new DevExpress.XtraEditors.TextEdit();
            this.txtMobile1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtVendorName = new DevExpress.XtraEditors.TextEdit();
            this.txtVendorCode = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.VendorView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VendorGrid = new DevExpress.XtraGrid.GridControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnModify = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.Group.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.City.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendorCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendorView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // Group
            // 
            resources.ApplyResources(this.Group, "Group");
            this.Group.Name = "Group";
            this.Group.Properties.AccessibleDescription = resources.GetString("Group.Properties.AccessibleDescription");
            this.Group.Properties.AccessibleName = resources.GetString("Group.Properties.AccessibleName");
            this.Group.Properties.AutoHeight = ((bool)(resources.GetObject("Group.Properties.AutoHeight")));
            this.Group.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("Group.Properties.Buttons"))))});
            this.Group.Properties.NullValuePrompt = resources.GetString("Group.Properties.NullValuePrompt");
            this.Group.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("Group.Properties.NullValuePromptShowForEmptyValue")));
            this.Group.Properties.View = this.gridView1;
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtNotes
            // 
            resources.ApplyResources(this.txtNotes, "txtNotes");
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Properties.AccessibleDescription = resources.GetString("txtNotes.Properties.AccessibleDescription");
            this.txtNotes.Properties.AccessibleName = resources.GetString("txtNotes.Properties.AccessibleName");
            this.txtNotes.Properties.AutoHeight = ((bool)(resources.GetObject("txtNotes.Properties.AutoHeight")));
            this.txtNotes.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtNotes.Properties.Mask.AutoComplete")));
            this.txtNotes.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtNotes.Properties.Mask.BeepOnError")));
            this.txtNotes.Properties.Mask.EditMask = resources.GetString("txtNotes.Properties.Mask.EditMask");
            this.txtNotes.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtNotes.Properties.Mask.IgnoreMaskBlank")));
            this.txtNotes.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtNotes.Properties.Mask.MaskType")));
            this.txtNotes.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtNotes.Properties.Mask.PlaceHolder")));
            this.txtNotes.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtNotes.Properties.Mask.SaveLiteral")));
            this.txtNotes.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtNotes.Properties.Mask.ShowPlaceHolders")));
            this.txtNotes.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtNotes.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtNotes.Properties.NullValuePrompt = resources.GetString("txtNotes.Properties.NullValuePrompt");
            this.txtNotes.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtNotes.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // labelControl11
            // 
            resources.ApplyResources(this.labelControl11, "labelControl11");
            this.labelControl11.Name = "labelControl11";
            // 
            // labelControl9
            // 
            resources.ApplyResources(this.labelControl9, "labelControl9");
            this.labelControl9.Name = "labelControl9";
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
            // labelControl5
            // 
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            // 
            // City
            // 
            resources.ApplyResources(this.City, "City");
            this.City.Name = "City";
            this.City.Properties.AccessibleDescription = resources.GetString("City.Properties.AccessibleDescription");
            this.City.Properties.AccessibleName = resources.GetString("City.Properties.AccessibleName");
            this.City.Properties.AutoHeight = ((bool)(resources.GetObject("City.Properties.AutoHeight")));
            this.City.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("City.Properties.Buttons"))))});
            this.City.Properties.NullValuePrompt = resources.GetString("City.Properties.NullValuePrompt");
            this.City.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("City.Properties.NullValuePromptShowForEmptyValue")));
            this.City.Properties.View = this.searchLookUpEdit1View;
            // 
            // searchLookUpEdit1View
            // 
            resources.ApplyResources(this.searchLookUpEdit1View, "searchLookUpEdit1View");
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.AccessibleDescription = resources.GetString("txtEmail.Properties.AccessibleDescription");
            this.txtEmail.Properties.AccessibleName = resources.GetString("txtEmail.Properties.AccessibleName");
            this.txtEmail.Properties.AutoHeight = ((bool)(resources.GetObject("txtEmail.Properties.AutoHeight")));
            this.txtEmail.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtEmail.Properties.Mask.AutoComplete")));
            this.txtEmail.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtEmail.Properties.Mask.BeepOnError")));
            this.txtEmail.Properties.Mask.EditMask = resources.GetString("txtEmail.Properties.Mask.EditMask");
            this.txtEmail.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtEmail.Properties.Mask.IgnoreMaskBlank")));
            this.txtEmail.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtEmail.Properties.Mask.MaskType")));
            this.txtEmail.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtEmail.Properties.Mask.PlaceHolder")));
            this.txtEmail.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtEmail.Properties.Mask.SaveLiteral")));
            this.txtEmail.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtEmail.Properties.Mask.ShowPlaceHolders")));
            this.txtEmail.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtEmail.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtEmail.Properties.NullValuePrompt = resources.GetString("txtEmail.Properties.NullValuePrompt");
            this.txtEmail.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtEmail.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtMobile2
            // 
            resources.ApplyResources(this.txtMobile2, "txtMobile2");
            this.txtMobile2.Name = "txtMobile2";
            this.txtMobile2.Properties.AccessibleDescription = resources.GetString("txtMobile2.Properties.AccessibleDescription");
            this.txtMobile2.Properties.AccessibleName = resources.GetString("txtMobile2.Properties.AccessibleName");
            this.txtMobile2.Properties.AutoHeight = ((bool)(resources.GetObject("txtMobile2.Properties.AutoHeight")));
            this.txtMobile2.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtMobile2.Properties.Mask.AutoComplete")));
            this.txtMobile2.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtMobile2.Properties.Mask.BeepOnError")));
            this.txtMobile2.Properties.Mask.EditMask = resources.GetString("txtMobile2.Properties.Mask.EditMask");
            this.txtMobile2.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtMobile2.Properties.Mask.IgnoreMaskBlank")));
            this.txtMobile2.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtMobile2.Properties.Mask.MaskType")));
            this.txtMobile2.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtMobile2.Properties.Mask.PlaceHolder")));
            this.txtMobile2.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtMobile2.Properties.Mask.SaveLiteral")));
            this.txtMobile2.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtMobile2.Properties.Mask.ShowPlaceHolders")));
            this.txtMobile2.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtMobile2.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtMobile2.Properties.NullValuePrompt = resources.GetString("txtMobile2.Properties.NullValuePrompt");
            this.txtMobile2.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtMobile2.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtMobile1
            // 
            resources.ApplyResources(this.txtMobile1, "txtMobile1");
            this.txtMobile1.Name = "txtMobile1";
            this.txtMobile1.Properties.AccessibleDescription = resources.GetString("txtMobile1.Properties.AccessibleDescription");
            this.txtMobile1.Properties.AccessibleName = resources.GetString("txtMobile1.Properties.AccessibleName");
            this.txtMobile1.Properties.AutoHeight = ((bool)(resources.GetObject("txtMobile1.Properties.AutoHeight")));
            this.txtMobile1.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtMobile1.Properties.Mask.AutoComplete")));
            this.txtMobile1.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtMobile1.Properties.Mask.BeepOnError")));
            this.txtMobile1.Properties.Mask.EditMask = resources.GetString("txtMobile1.Properties.Mask.EditMask");
            this.txtMobile1.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtMobile1.Properties.Mask.IgnoreMaskBlank")));
            this.txtMobile1.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtMobile1.Properties.Mask.MaskType")));
            this.txtMobile1.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtMobile1.Properties.Mask.PlaceHolder")));
            this.txtMobile1.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtMobile1.Properties.Mask.SaveLiteral")));
            this.txtMobile1.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtMobile1.Properties.Mask.ShowPlaceHolders")));
            this.txtMobile1.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtMobile1.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtMobile1.Properties.NullValuePrompt = resources.GetString("txtMobile1.Properties.NullValuePrompt");
            this.txtMobile1.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtMobile1.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.AccessibleDescription = resources.GetString("txtAddress.Properties.AccessibleDescription");
            this.txtAddress.Properties.AccessibleName = resources.GetString("txtAddress.Properties.AccessibleName");
            this.txtAddress.Properties.AutoHeight = ((bool)(resources.GetObject("txtAddress.Properties.AutoHeight")));
            this.txtAddress.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtAddress.Properties.Mask.AutoComplete")));
            this.txtAddress.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtAddress.Properties.Mask.BeepOnError")));
            this.txtAddress.Properties.Mask.EditMask = resources.GetString("txtAddress.Properties.Mask.EditMask");
            this.txtAddress.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtAddress.Properties.Mask.IgnoreMaskBlank")));
            this.txtAddress.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtAddress.Properties.Mask.MaskType")));
            this.txtAddress.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtAddress.Properties.Mask.PlaceHolder")));
            this.txtAddress.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtAddress.Properties.Mask.SaveLiteral")));
            this.txtAddress.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtAddress.Properties.Mask.ShowPlaceHolders")));
            this.txtAddress.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtAddress.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtAddress.Properties.NullValuePrompt = resources.GetString("txtAddress.Properties.NullValuePrompt");
            this.txtAddress.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtAddress.Properties.NullValuePromptShowForEmptyValue")));
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
            // txtVendorName
            // 
            resources.ApplyResources(this.txtVendorName, "txtVendorName");
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Properties.AccessibleDescription = resources.GetString("txtVendorName.Properties.AccessibleDescription");
            this.txtVendorName.Properties.AccessibleName = resources.GetString("txtVendorName.Properties.AccessibleName");
            this.txtVendorName.Properties.AutoHeight = ((bool)(resources.GetObject("txtVendorName.Properties.AutoHeight")));
            this.txtVendorName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtVendorName.Properties.Mask.AutoComplete")));
            this.txtVendorName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtVendorName.Properties.Mask.BeepOnError")));
            this.txtVendorName.Properties.Mask.EditMask = resources.GetString("txtVendorName.Properties.Mask.EditMask");
            this.txtVendorName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtVendorName.Properties.Mask.IgnoreMaskBlank")));
            this.txtVendorName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtVendorName.Properties.Mask.MaskType")));
            this.txtVendorName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtVendorName.Properties.Mask.PlaceHolder")));
            this.txtVendorName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtVendorName.Properties.Mask.SaveLiteral")));
            this.txtVendorName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtVendorName.Properties.Mask.ShowPlaceHolders")));
            this.txtVendorName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtVendorName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtVendorName.Properties.NullValuePrompt = resources.GetString("txtVendorName.Properties.NullValuePrompt");
            this.txtVendorName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtVendorName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtVendorCode
            // 
            resources.ApplyResources(this.txtVendorCode, "txtVendorCode");
            this.txtVendorCode.Name = "txtVendorCode";
            this.txtVendorCode.Properties.AccessibleDescription = resources.GetString("txtVendorCode.Properties.AccessibleDescription");
            this.txtVendorCode.Properties.AccessibleName = resources.GetString("txtVendorCode.Properties.AccessibleName");
            this.txtVendorCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtVendorCode.Properties.AutoHeight")));
            this.txtVendorCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtVendorCode.Properties.Mask.AutoComplete")));
            this.txtVendorCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtVendorCode.Properties.Mask.BeepOnError")));
            this.txtVendorCode.Properties.Mask.EditMask = resources.GetString("txtVendorCode.Properties.Mask.EditMask");
            this.txtVendorCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtVendorCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtVendorCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtVendorCode.Properties.Mask.MaskType")));
            this.txtVendorCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtVendorCode.Properties.Mask.PlaceHolder")));
            this.txtVendorCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtVendorCode.Properties.Mask.SaveLiteral")));
            this.txtVendorCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtVendorCode.Properties.Mask.ShowPlaceHolders")));
            this.txtVendorCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtVendorCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtVendorCode.Properties.NullValuePrompt = resources.GetString("txtVendorCode.Properties.NullValuePrompt");
            this.txtVendorCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtVendorCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.Group);
            this.panelControl2.Controls.Add(this.txtNotes);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.txtEmail);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.txtMobile2);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txtMobile1);
            this.panelControl2.Controls.Add(this.City);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.txtAddress);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtVendorName);
            this.panelControl2.Controls.Add(this.txtVendorCode);
            this.panelControl2.Name = "panelControl2";
            // 
            // VendorView
            // 
            this.VendorView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.VendorView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.VendorView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.ColumnFilterButton.GradientMode")));
            this.VendorView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.ColumnFilterButton.Image")));
            this.VendorView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.VendorView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.FocusedCell.FontSizeDelta")));
            this.VendorView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.FocusedCell.FontStyleDelta")));
            this.VendorView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.FocusedCell.GradientMode")));
            this.VendorView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.FocusedCell.Image")));
            this.VendorView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.VendorView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.FocusedRow.FontSizeDelta")));
            this.VendorView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.FocusedRow.FontStyleDelta")));
            this.VendorView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.FocusedRow.GradientMode")));
            this.VendorView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.FocusedRow.Image")));
            this.VendorView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.VendorView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.HeaderPanel.FontSizeDelta")));
            this.VendorView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.HeaderPanel.FontStyleDelta")));
            this.VendorView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.HeaderPanel.GradientMode")));
            this.VendorView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.HeaderPanel.Image")));
            this.VendorView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.VendorView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.HorzLine.FontSizeDelta")));
            this.VendorView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.HorzLine.FontStyleDelta")));
            this.VendorView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.HorzLine.GradientMode")));
            this.VendorView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.HorzLine.Image")));
            this.VendorView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.VendorView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.OddRow.FontSizeDelta")));
            this.VendorView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.OddRow.FontStyleDelta")));
            this.VendorView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.OddRow.GradientMode")));
            this.VendorView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.OddRow.Image")));
            this.VendorView.Appearance.OddRow.Options.UseTextOptions = true;
            this.VendorView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.Preview.FontSizeDelta")));
            this.VendorView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.Preview.FontStyleDelta")));
            this.VendorView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.Preview.GradientMode")));
            this.VendorView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.Preview.Image")));
            this.VendorView.Appearance.Preview.Options.UseTextOptions = true;
            this.VendorView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.Row.FontSizeDelta")));
            this.VendorView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.Row.FontStyleDelta")));
            this.VendorView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.Row.GradientMode")));
            this.VendorView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.Row.Image")));
            this.VendorView.Appearance.Row.Options.UseTextOptions = true;
            this.VendorView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.SelectedRow.FontSizeDelta")));
            this.VendorView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.SelectedRow.FontStyleDelta")));
            this.VendorView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.SelectedRow.GradientMode")));
            this.VendorView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.SelectedRow.Image")));
            this.VendorView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.VendorView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.TopNewRow.FontSizeDelta")));
            this.VendorView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.TopNewRow.FontStyleDelta")));
            this.VendorView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.TopNewRow.GradientMode")));
            this.VendorView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.TopNewRow.Image")));
            this.VendorView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.VendorView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.VertLine.FontSizeDelta")));
            this.VendorView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.VertLine.FontStyleDelta")));
            this.VendorView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.VertLine.GradientMode")));
            this.VendorView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.VertLine.Image")));
            this.VendorView.Appearance.VertLine.Options.UseTextOptions = true;
            this.VendorView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("VendorView.Appearance.ViewCaption.FontSizeDelta")));
            this.VendorView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("VendorView.Appearance.ViewCaption.FontStyleDelta")));
            this.VendorView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("VendorView.Appearance.ViewCaption.GradientMode")));
            this.VendorView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("VendorView.Appearance.ViewCaption.Image")));
            this.VendorView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.VendorView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VendorView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.VendorView, "VendorView");
            this.VendorView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.VendorView.GridControl = this.VendorGrid;
            this.VendorView.Name = "VendorView";
            this.VendorView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.VendorView.OptionsBehavior.Editable = false;
            this.VendorView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.VendorView.OptionsPrint.EnableAppearanceOddRow = true;
            this.VendorView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.VendorView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.VendorView.OptionsView.EnableAppearanceEvenRow = true;
            this.VendorView.OptionsView.EnableAppearanceOddRow = true;
            this.VendorView.OptionsView.RowAutoHeight = true;
            this.VendorView.OptionsView.ShowAutoFilterRow = true;
            this.VendorView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.VendorView.OptionsView.ShowGroupedColumns = true;
            this.VendorView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.VendorView_RowClick);
            this.VendorView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.VendorView_FocusedRowChanged);
            this.VendorView.RowCountChanged += new System.EventHandler(this.VendorView_RowCountChanged);
            // 
            // VendorGrid
            // 
            resources.ApplyResources(this.VendorGrid, "VendorGrid");
            this.VendorGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("VendorGrid.EmbeddedNavigator.AccessibleDescription");
            this.VendorGrid.EmbeddedNavigator.AccessibleName = resources.GetString("VendorGrid.EmbeddedNavigator.AccessibleName");
            this.VendorGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("VendorGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.VendorGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("VendorGrid.EmbeddedNavigator.Anchor")));
            this.VendorGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VendorGrid.EmbeddedNavigator.BackgroundImage")));
            this.VendorGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("VendorGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.VendorGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("VendorGrid.EmbeddedNavigator.ImeMode")));
            this.VendorGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("VendorGrid.EmbeddedNavigator.MaximumSize")));
            this.VendorGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("VendorGrid.EmbeddedNavigator.TextLocation")));
            this.VendorGrid.EmbeddedNavigator.ToolTip = resources.GetString("VendorGrid.EmbeddedNavigator.ToolTip");
            this.VendorGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("VendorGrid.EmbeddedNavigator.ToolTipIconType")));
            this.VendorGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("VendorGrid.EmbeddedNavigator.ToolTipTitle");
            this.VendorGrid.MainView = this.VendorView;
            this.VendorGrid.Name = "VendorGrid";
            this.VendorGrid.UseEmbeddedNavigator = true;
            this.VendorGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.VendorView});
            // 
            // panelControl3
            // 
            resources.ApplyResources(this.panelControl3, "panelControl3");
            this.panelControl3.Controls.Add(this.VendorGrid);
            this.panelControl3.Name = "panelControl3";
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Name = "panelControl1";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnModify);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
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
            this.btnModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModify_ItemClick);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Enabled = false;
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.Id = 4;
            this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
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
            // FRM_Vendor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_Vendor";
            this.Ribbon = this.ribbon;
            this.Load += new System.EventHandler(this.FRM_Vendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Group.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.City.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVendorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendorView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit Group;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtNotes;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit City;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtMobile2;
        private DevExpress.XtraEditors.TextEdit txtMobile1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtVendorName;
        private DevExpress.XtraEditors.TextEdit txtVendorCode;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView VendorView;
        private DevExpress.XtraGrid.GridControl VendorGrid;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnModify;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;

    }
}