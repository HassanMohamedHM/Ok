namespace UILayer.Accounts
{
    partial class FRM_GeneralAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_GeneralAccounts));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnModify = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtAccCode = new DevExpress.XtraEditors.TextEdit();
            this.AccountType = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccName = new DevExpress.XtraEditors.TextEdit();
            this.txtAccLevel = new DevExpress.XtraEditors.TextEdit();
            this.txtMainAccountCode = new DevExpress.XtraEditors.TextEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.AccountTree = new System.Windows.Forms.TreeView();
            this.AllowManualEntry = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainAccountCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllowManualEntry.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnAddNew,
            this.btnModify,
            this.btnDelete,
            this.btnSave});
            resources.ApplyResources(this.ribbon, "ribbon");
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
            this.btnAddNew.Enabled = false;
            this.btnAddNew.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Glyph")));
            this.btnAddNew.Id = 1;
            this.btnAddNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddNew.LargeGlyph")));
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNew_ItemClick);
            // 
            // btnModify
            // 
            resources.ApplyResources(this.btnModify, "btnModify");
            this.btnModify.Enabled = false;
            this.btnModify.Glyph = ((System.Drawing.Image)(resources.GetObject("btnModify.Glyph")));
            this.btnModify.Id = 2;
            this.btnModify.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnModify.LargeGlyph")));
            this.btnModify.Name = "btnModify";
            this.btnModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModify_ItemClick);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Enabled = false;
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.Id = 3;
            this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Enabled = false;
            this.btnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSave.Glyph")));
            this.btnSave.Id = 4;
            this.btnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSave.LargeGlyph")));
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnModify, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.panelControl4);
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Name = "panelControl2";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.AllowManualEntry);
            this.panelControl3.Controls.Add(this.txtAccCode);
            this.panelControl3.Controls.Add(this.AccountType);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.txtAccName);
            this.panelControl3.Controls.Add(this.txtAccLevel);
            this.panelControl3.Controls.Add(this.txtMainAccountCode);
            resources.ApplyResources(this.panelControl3, "panelControl3");
            this.panelControl3.Name = "panelControl3";
            // 
            // txtAccCode
            // 
            resources.ApplyResources(this.txtAccCode, "txtAccCode");
            this.txtAccCode.Name = "txtAccCode";
            // 
            // AccountType
            // 
            resources.ApplyResources(this.AccountType, "AccountType");
            this.AccountType.Name = "AccountType";
            this.AccountType.Properties.Appearance.Options.UseTextOptions = true;
            this.AccountType.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountType.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountType.Properties.AppearanceDropDown.Options.UseTextOptions = true;
            this.AccountType.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccountType.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AccountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("AccountType.Properties.Buttons"))))});
            this.AccountType.Properties.View = this.searchLookUpEdit1View;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // labelControl5
            // 
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
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
            // txtAccName
            // 
            resources.ApplyResources(this.txtAccName, "txtAccName");
            this.txtAccName.Name = "txtAccName";
            // 
            // txtAccLevel
            // 
            resources.ApplyResources(this.txtAccLevel, "txtAccLevel");
            this.txtAccLevel.Name = "txtAccLevel";
            // 
            // txtMainAccountCode
            // 
            resources.ApplyResources(this.txtMainAccountCode, "txtMainAccountCode");
            this.txtMainAccountCode.Name = "txtMainAccountCode";
            // 
            // panelControl4
            // 
            resources.ApplyResources(this.panelControl4, "panelControl4");
            this.panelControl4.Controls.Add(this.AccountTree);
            this.panelControl4.Name = "panelControl4";
            // 
            // AccountTree
            // 
            resources.ApplyResources(this.AccountTree, "AccountTree");
            this.AccountTree.Name = "AccountTree";
            this.AccountTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AccountTree_AfterSelect);
            // 
            // AllowManualEntry
            // 
            resources.ApplyResources(this.AllowManualEntry, "AllowManualEntry");
            this.AllowManualEntry.MenuManager = this.ribbon;
            this.AllowManualEntry.Name = "AllowManualEntry";
            this.AllowManualEntry.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.AllowManualEntry.Properties.Caption = resources.GetString("checkEdit1.Properties.Caption");
            this.AllowManualEntry.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style10;
            this.AllowManualEntry.Properties.FullFocusRect = true;
            this.AllowManualEntry.Properties.GlyphAlignment = ((DevExpress.Utils.HorzAlignment)(resources.GetObject("checkEdit1.Properties.GlyphAlignment")));
            // 
            // FRM_GeneralAccounts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_GeneralAccounts";
            this.Ribbon = this.ribbon;
            this.Load += new System.EventHandler(this.FRM_GeneralAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainAccountCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllowManualEntry.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnModify;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit txtAccCode;
        private DevExpress.XtraEditors.SearchLookUpEdit AccountType;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAccName;
        private DevExpress.XtraEditors.TextEdit txtAccLevel;
        private DevExpress.XtraEditors.TextEdit txtMainAccountCode;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.TreeView AccountTree;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraEditors.CheckEdit AllowManualEntry;
    }
}