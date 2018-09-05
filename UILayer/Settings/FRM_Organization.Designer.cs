namespace UILayer.Settings
{
    partial class FRM_Organization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Organization));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.SearchCity = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnChooseImgae = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteImage = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnSave});
            this.ribbon.MaxItemId = 2;
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
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSave.Glyph")));
            this.btnSave.Id = 1;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.MenuManager = this.ribbon;
            this.txtName.Name = "txtName";
            this.txtName.Properties.AccessibleDescription = resources.GetString("txtName.Properties.AccessibleDescription");
            this.txtName.Properties.AccessibleName = resources.GetString("txtName.Properties.AccessibleName");
            this.txtName.Properties.AutoHeight = ((bool)(resources.GetObject("txtName.Properties.AutoHeight")));
            this.txtName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtName.Properties.Mask.AutoComplete")));
            this.txtName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtName.Properties.Mask.BeepOnError")));
            this.txtName.Properties.Mask.EditMask = resources.GetString("txtName.Properties.Mask.EditMask");
            this.txtName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtName.Properties.Mask.IgnoreMaskBlank")));
            this.txtName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtName.Properties.Mask.MaskType")));
            this.txtName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtName.Properties.Mask.PlaceHolder")));
            this.txtName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtName.Properties.Mask.SaveLiteral")));
            this.txtName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtName.Properties.Mask.ShowPlaceHolders")));
            this.txtName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtName.Properties.NullValuePrompt = resources.GetString("txtName.Properties.NullValuePrompt");
            this.txtName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.MenuManager = this.ribbon;
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
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // SearchCity
            // 
            resources.ApplyResources(this.SearchCity, "SearchCity");
            this.SearchCity.MenuManager = this.ribbon;
            this.SearchCity.Name = "SearchCity";
            this.SearchCity.Properties.AccessibleDescription = resources.GetString("SearchCity.Properties.AccessibleDescription");
            this.SearchCity.Properties.AccessibleName = resources.GetString("SearchCity.Properties.AccessibleName");
            this.SearchCity.Properties.AutoHeight = ((bool)(resources.GetObject("SearchCity.Properties.AutoHeight")));
            this.SearchCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("SearchCity.Properties.Buttons"))))});
            this.SearchCity.Properties.NullText = resources.GetString("SearchCity.Properties.NullText");
            this.SearchCity.Properties.NullValuePrompt = resources.GetString("SearchCity.Properties.NullValuePrompt");
            this.SearchCity.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("SearchCity.Properties.NullValuePromptShowForEmptyValue")));
            this.SearchCity.Properties.View = this.searchLookUpEdit1View;
            // 
            // searchLookUpEdit1View
            // 
            resources.ApplyResources(this.searchLookUpEdit1View, "searchLookUpEdit1View");
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.searchLookUpEdit1View.OptionsView.EnableAppearanceOddRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // picLogo
            // 
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.MenuManager = this.ribbon;
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.AccessibleDescription = resources.GetString("picLogo.Properties.AccessibleDescription");
            this.picLogo.Properties.AccessibleName = resources.GetString("picLogo.Properties.AccessibleName");
            this.picLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picLogo.Click += new System.EventHandler(this.btnChooseImgae_Click);
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.MenuManager = this.ribbon;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.AccessibleDescription = resources.GetString("txtPhone.Properties.AccessibleDescription");
            this.txtPhone.Properties.AccessibleName = resources.GetString("txtPhone.Properties.AccessibleName");
            this.txtPhone.Properties.AutoHeight = ((bool)(resources.GetObject("txtPhone.Properties.AutoHeight")));
            this.txtPhone.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtPhone.Properties.Mask.AutoComplete")));
            this.txtPhone.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtPhone.Properties.Mask.BeepOnError")));
            this.txtPhone.Properties.Mask.EditMask = resources.GetString("txtPhone.Properties.Mask.EditMask");
            this.txtPhone.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtPhone.Properties.Mask.IgnoreMaskBlank")));
            this.txtPhone.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtPhone.Properties.Mask.MaskType")));
            this.txtPhone.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtPhone.Properties.Mask.PlaceHolder")));
            this.txtPhone.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtPhone.Properties.Mask.SaveLiteral")));
            this.txtPhone.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtPhone.Properties.Mask.ShowPlaceHolders")));
            this.txtPhone.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtPhone.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtPhone.Properties.NullValuePrompt = resources.GetString("txtPhone.Properties.NullValuePrompt");
            this.txtPhone.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtPhone.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // txtMobile
            // 
            resources.ApplyResources(this.txtMobile, "txtMobile");
            this.txtMobile.MenuManager = this.ribbon;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Properties.AccessibleDescription = resources.GetString("txtMobile.Properties.AccessibleDescription");
            this.txtMobile.Properties.AccessibleName = resources.GetString("txtMobile.Properties.AccessibleName");
            this.txtMobile.Properties.AutoHeight = ((bool)(resources.GetObject("txtMobile.Properties.AutoHeight")));
            this.txtMobile.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtMobile.Properties.Mask.AutoComplete")));
            this.txtMobile.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtMobile.Properties.Mask.BeepOnError")));
            this.txtMobile.Properties.Mask.EditMask = resources.GetString("txtMobile.Properties.Mask.EditMask");
            this.txtMobile.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtMobile.Properties.Mask.IgnoreMaskBlank")));
            this.txtMobile.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtMobile.Properties.Mask.MaskType")));
            this.txtMobile.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtMobile.Properties.Mask.PlaceHolder")));
            this.txtMobile.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtMobile.Properties.Mask.SaveLiteral")));
            this.txtMobile.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtMobile.Properties.Mask.ShowPlaceHolders")));
            this.txtMobile.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtMobile.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtMobile.Properties.NullValuePrompt = resources.GetString("txtMobile.Properties.NullValuePrompt");
            this.txtMobile.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtMobile.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // labelControl5
            // 
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            // 
            // txtFax
            // 
            resources.ApplyResources(this.txtFax, "txtFax");
            this.txtFax.MenuManager = this.ribbon;
            this.txtFax.Name = "txtFax";
            this.txtFax.Properties.AccessibleDescription = resources.GetString("txtFax.Properties.AccessibleDescription");
            this.txtFax.Properties.AccessibleName = resources.GetString("txtFax.Properties.AccessibleName");
            this.txtFax.Properties.AutoHeight = ((bool)(resources.GetObject("txtFax.Properties.AutoHeight")));
            this.txtFax.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtFax.Properties.Mask.AutoComplete")));
            this.txtFax.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtFax.Properties.Mask.BeepOnError")));
            this.txtFax.Properties.Mask.EditMask = resources.GetString("txtFax.Properties.Mask.EditMask");
            this.txtFax.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtFax.Properties.Mask.IgnoreMaskBlank")));
            this.txtFax.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtFax.Properties.Mask.MaskType")));
            this.txtFax.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtFax.Properties.Mask.PlaceHolder")));
            this.txtFax.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtFax.Properties.Mask.SaveLiteral")));
            this.txtFax.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtFax.Properties.Mask.ShowPlaceHolders")));
            this.txtFax.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtFax.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtFax.Properties.NullValuePrompt = resources.GetString("txtFax.Properties.NullValuePrompt");
            this.txtFax.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtFax.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // labelControl6
            // 
            resources.ApplyResources(this.labelControl6, "labelControl6");
            this.labelControl6.Name = "labelControl6";
            // 
            // txtWebsite
            // 
            resources.ApplyResources(this.txtWebsite, "txtWebsite");
            this.txtWebsite.MenuManager = this.ribbon;
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Properties.AccessibleDescription = resources.GetString("txtWebsite.Properties.AccessibleDescription");
            this.txtWebsite.Properties.AccessibleName = resources.GetString("txtWebsite.Properties.AccessibleName");
            this.txtWebsite.Properties.AutoHeight = ((bool)(resources.GetObject("txtWebsite.Properties.AutoHeight")));
            this.txtWebsite.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtWebsite.Properties.Mask.AutoComplete")));
            this.txtWebsite.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtWebsite.Properties.Mask.BeepOnError")));
            this.txtWebsite.Properties.Mask.EditMask = resources.GetString("txtWebsite.Properties.Mask.EditMask");
            this.txtWebsite.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtWebsite.Properties.Mask.IgnoreMaskBlank")));
            this.txtWebsite.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtWebsite.Properties.Mask.MaskType")));
            this.txtWebsite.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtWebsite.Properties.Mask.PlaceHolder")));
            this.txtWebsite.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtWebsite.Properties.Mask.SaveLiteral")));
            this.txtWebsite.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtWebsite.Properties.Mask.ShowPlaceHolders")));
            this.txtWebsite.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtWebsite.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtWebsite.Properties.NullValuePrompt = resources.GetString("txtWebsite.Properties.NullValuePrompt");
            this.txtWebsite.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtWebsite.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // labelControl7
            // 
            resources.ApplyResources(this.labelControl7, "labelControl7");
            this.labelControl7.Name = "labelControl7";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.MenuManager = this.ribbon;
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
            // labelControl8
            // 
            resources.ApplyResources(this.labelControl8, "labelControl8");
            this.labelControl8.Name = "labelControl8";
            // 
            // btnChooseImgae
            // 
            resources.ApplyResources(this.btnChooseImgae, "btnChooseImgae");
            this.btnChooseImgae.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseImgae.Image")));
            this.btnChooseImgae.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnChooseImgae.Name = "btnChooseImgae";
            this.btnChooseImgae.Click += new System.EventHandler(this.btnChooseImgae_Click);
            // 
            // btnDeleteImage
            // 
            resources.ApplyResources(this.btnDeleteImage, "btnDeleteImage");
            this.btnDeleteImage.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteImage.Image")));
            this.btnDeleteImage.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // FRM_Organization
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.btnChooseImgae);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.SearchCity);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Organization";
            this.Ribbon = this.ribbon;
            this.Load += new System.EventHandler(this.FRM_Organization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit SearchCity;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.PictureEdit picLogo;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMobile;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtWebsite;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnChooseImgae;
        private DevExpress.XtraEditors.SimpleButton btnDeleteImage;
    }
}