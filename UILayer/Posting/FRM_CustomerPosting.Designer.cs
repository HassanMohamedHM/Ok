namespace UILayer.Posting
{
    partial class FRM_CustomerPosting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CustomerPosting));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.CashAccount = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CustomerAccount = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.CustomerGroupsGrid = new DevExpress.XtraGrid.GridControl();
            this.CustomerGroupsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGroupsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGroupsView)).BeginInit();
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
            this.panelControl3.Controls.Add(this.CustomerAccount);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Name = "panelControl3";
            // 
            // CashAccount
            // 
            resources.ApplyResources(this.CashAccount, "CashAccount");
            this.CashAccount.MenuManager = this.ribbon;
            this.CashAccount.Name = "CashAccount";
            this.CashAccount.Properties.AccessibleDescription = resources.GetString("searchLookUpEdit2.Properties.AccessibleDescription");
            this.CashAccount.Properties.AccessibleName = resources.GetString("searchLookUpEdit2.Properties.AccessibleName");
            this.CashAccount.Properties.AutoHeight = ((bool)(resources.GetObject("searchLookUpEdit2.Properties.AutoHeight")));
            this.CashAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("searchLookUpEdit2.Properties.Buttons"))))});
            this.CashAccount.Properties.NullValuePrompt = resources.GetString("searchLookUpEdit2.Properties.NullValuePrompt");
            this.CashAccount.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("searchLookUpEdit2.Properties.NullValuePromptShowForEmptyValue")));
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
            // CustomerAccount
            // 
            resources.ApplyResources(this.CustomerAccount, "CustomerAccount");
            this.CustomerAccount.MenuManager = this.ribbon;
            this.CustomerAccount.Name = "CustomerAccount";
            this.CustomerAccount.Properties.AccessibleDescription = resources.GetString("searchLookUpEdit1.Properties.AccessibleDescription");
            this.CustomerAccount.Properties.AccessibleName = resources.GetString("searchLookUpEdit1.Properties.AccessibleName");
            this.CustomerAccount.Properties.AutoHeight = ((bool)(resources.GetObject("searchLookUpEdit1.Properties.AutoHeight")));
            this.CustomerAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("searchLookUpEdit1.Properties.Buttons"))))});
            this.CustomerAccount.Properties.NullValuePrompt = resources.GetString("searchLookUpEdit1.Properties.NullValuePrompt");
            this.CustomerAccount.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("searchLookUpEdit1.Properties.NullValuePromptShowForEmptyValue")));
            this.CustomerAccount.Properties.View = this.searchLookUpEdit1View;
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
            this.panelControl2.Controls.Add(this.CustomerGroupsGrid);
            this.panelControl2.Name = "panelControl2";
            // 
            // CustomerGroupsGrid
            // 
            resources.ApplyResources(this.CustomerGroupsGrid, "CustomerGroupsGrid");
            this.CustomerGroupsGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("CustomerGroupsGrid.EmbeddedNavigator.AccessibleDescription");
            this.CustomerGroupsGrid.EmbeddedNavigator.AccessibleName = resources.GetString("CustomerGroupsGrid.EmbeddedNavigator.AccessibleName");
            this.CustomerGroupsGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("CustomerGroupsGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.CustomerGroupsGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("CustomerGroupsGrid.EmbeddedNavigator.Anchor")));
            this.CustomerGroupsGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomerGroupsGrid.EmbeddedNavigator.BackgroundImage")));
            this.CustomerGroupsGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("CustomerGroupsGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.CustomerGroupsGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("CustomerGroupsGrid.EmbeddedNavigator.ImeMode")));
            this.CustomerGroupsGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("CustomerGroupsGrid.EmbeddedNavigator.MaximumSize")));
            this.CustomerGroupsGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("CustomerGroupsGrid.EmbeddedNavigator.TextLocation")));
            this.CustomerGroupsGrid.EmbeddedNavigator.ToolTip = resources.GetString("CustomerGroupsGrid.EmbeddedNavigator.ToolTip");
            this.CustomerGroupsGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("CustomerGroupsGrid.EmbeddedNavigator.ToolTipIconType")));
            this.CustomerGroupsGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("CustomerGroupsGrid.EmbeddedNavigator.ToolTipTitle");
            this.CustomerGroupsGrid.MainView = this.CustomerGroupsView;
            this.CustomerGroupsGrid.MenuManager = this.ribbon;
            this.CustomerGroupsGrid.Name = "CustomerGroupsGrid";
            this.CustomerGroupsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CustomerGroupsView});
            // 
            // CustomerGroupsView
            // 
            resources.ApplyResources(this.CustomerGroupsView, "CustomerGroupsView");
            this.CustomerGroupsView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.CustomerGroupsView.GridControl = this.CustomerGroupsGrid;
            this.CustomerGroupsView.Name = "CustomerGroupsView";
            this.CustomerGroupsView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.CustomerGroupsView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.CustomerGroupsView.OptionsBehavior.Editable = false;
            this.CustomerGroupsView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.CustomerGroupsView.OptionsView.EnableAppearanceEvenRow = true;
            this.CustomerGroupsView.OptionsView.EnableAppearanceOddRow = true;
            this.CustomerGroupsView.OptionsView.ShowAutoFilterRow = true;
            this.CustomerGroupsView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.CustomerGroupsView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.CustomerGroupsView_RowClick);
            // 
            // FRM_CustomerPosting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FRM_CustomerPosting";
            this.Ribbon = this.ribbon;
            this.Load += new System.EventHandler(this.FRM_CustomerPosting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGroupsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGroupsView)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl CustomerGroupsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView CustomerGroupsView;
        private DevExpress.XtraEditors.SearchLookUpEdit CashAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit CustomerAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}