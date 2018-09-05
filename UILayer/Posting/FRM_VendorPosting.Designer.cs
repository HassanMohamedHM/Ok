namespace UILayer.Posting
{
    partial class FRM_VendorPosting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_VendorPosting));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.CashAccount = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.VendorAccount = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.VendorGroupsGrid = new DevExpress.XtraGrid.GridControl();
            this.VendorGroupsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendorGroupsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorGroupsView)).BeginInit();
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Name = "panelControl1";
            // 
            // panelControl3
            // 
            resources.ApplyResources(this.panelControl3, "panelControl3");
            this.panelControl3.Controls.Add(this.CashAccount);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.VendorAccount);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Name = "panelControl3";
            // 
            // CashAccount
            // 
            resources.ApplyResources(this.CashAccount, "CashAccount");
            this.CashAccount.MenuManager = this.ribbon;
            this.CashAccount.Name = "CashAccount";
            this.CashAccount.Properties.AccessibleDescription = resources.GetString("CashAccount.Properties.AccessibleDescription");
            this.CashAccount.Properties.AccessibleName = resources.GetString("CashAccount.Properties.AccessibleName");
            this.CashAccount.Properties.AutoHeight = ((bool)(resources.GetObject("CashAccount.Properties.AutoHeight")));
            this.CashAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("CashAccount.Properties.Buttons"))))});
            this.CashAccount.Properties.NullValuePrompt = resources.GetString("CashAccount.Properties.NullValuePrompt");
            this.CashAccount.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("CashAccount.Properties.NullValuePromptShowForEmptyValue")));
            this.CashAccount.Properties.View = this.gridView1;
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // VendorAccount
            // 
            resources.ApplyResources(this.VendorAccount, "VendorAccount");
            this.VendorAccount.MenuManager = this.ribbon;
            this.VendorAccount.Name = "VendorAccount";
            this.VendorAccount.Properties.AccessibleDescription = resources.GetString("VendorAccount.Properties.AccessibleDescription");
            this.VendorAccount.Properties.AccessibleName = resources.GetString("VendorAccount.Properties.AccessibleName");
            this.VendorAccount.Properties.AutoHeight = ((bool)(resources.GetObject("VendorAccount.Properties.AutoHeight")));
            this.VendorAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("VendorAccount.Properties.Buttons"))))});
            this.VendorAccount.Properties.NullValuePrompt = resources.GetString("VendorAccount.Properties.NullValuePrompt");
            this.VendorAccount.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("VendorAccount.Properties.NullValuePromptShowForEmptyValue")));
            this.VendorAccount.Properties.View = this.searchLookUpEdit1View;
            // 
            // searchLookUpEdit1View
            // 
            resources.ApplyResources(this.searchLookUpEdit1View, "searchLookUpEdit1View");
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
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.VendorGroupsGrid);
            this.panelControl2.Name = "panelControl2";
            // 
            // VendorGroupsGrid
            // 
            resources.ApplyResources(this.VendorGroupsGrid, "VendorGroupsGrid");
            this.VendorGroupsGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("VendorGroupsGrid.EmbeddedNavigator.AccessibleDescription");
            this.VendorGroupsGrid.EmbeddedNavigator.AccessibleName = resources.GetString("VendorGroupsGrid.EmbeddedNavigator.AccessibleName");
            this.VendorGroupsGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("VendorGroupsGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.VendorGroupsGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("VendorGroupsGrid.EmbeddedNavigator.Anchor")));
            this.VendorGroupsGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VendorGroupsGrid.EmbeddedNavigator.BackgroundImage")));
            this.VendorGroupsGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("VendorGroupsGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.VendorGroupsGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("VendorGroupsGrid.EmbeddedNavigator.ImeMode")));
            this.VendorGroupsGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("VendorGroupsGrid.EmbeddedNavigator.MaximumSize")));
            this.VendorGroupsGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("VendorGroupsGrid.EmbeddedNavigator.TextLocation")));
            this.VendorGroupsGrid.EmbeddedNavigator.ToolTip = resources.GetString("VendorGroupsGrid.EmbeddedNavigator.ToolTip");
            this.VendorGroupsGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("VendorGroupsGrid.EmbeddedNavigator.ToolTipIconType")));
            this.VendorGroupsGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("VendorGroupsGrid.EmbeddedNavigator.ToolTipTitle");
            this.VendorGroupsGrid.MainView = this.VendorGroupsView;
            this.VendorGroupsGrid.MenuManager = this.ribbon;
            this.VendorGroupsGrid.Name = "VendorGroupsGrid";
            this.VendorGroupsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.VendorGroupsView});
            // 
            // VendorGroupsView
            // 
            resources.ApplyResources(this.VendorGroupsView, "VendorGroupsView");
            this.VendorGroupsView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.VendorGroupsView.GridControl = this.VendorGroupsGrid;
            this.VendorGroupsView.Name = "VendorGroupsView";
            this.VendorGroupsView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.VendorGroupsView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.VendorGroupsView.OptionsBehavior.Editable = false;
            this.VendorGroupsView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.VendorGroupsView.OptionsView.EnableAppearanceEvenRow = true;
            this.VendorGroupsView.OptionsView.EnableAppearanceOddRow = true;
            this.VendorGroupsView.OptionsView.ShowAutoFilterRow = true;
            this.VendorGroupsView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.VendorGroupsView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.VendorGroupsView_RowClick);
            // 
            // FRM_VendorPosting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FRM_VendorPosting";
            this.Ribbon = this.ribbon;
            this.Load += new System.EventHandler(this.FRM_VendorPosting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VendorGroupsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorGroupsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl VendorGroupsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView VendorGroupsView;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit CashAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit VendorAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}