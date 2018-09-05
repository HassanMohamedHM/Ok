namespace UILayer.Accounts
{
    partial class FRM_Journal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Journal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnModify = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.JournalGrid = new DevExpress.XtraGrid.GridControl();
            this.JournalView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtJournalCode = new DevExpress.XtraEditors.TextEdit();
            this.txtJournalName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JournalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJournalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJournalName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            resources.ApplyResources(this.ribbon, "ribbon");
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
            // btnAddNew
            // 
            resources.ApplyResources(this.btnAddNew, "btnAddNew");
            this.btnAddNew.Id = 1;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNew_ItemClick);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Id = 2;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnModify
            // 
            resources.ApplyResources(this.btnModify, "btnModify");
            this.btnModify.Id = 3;
            this.btnModify.Name = "btnModify";
            this.btnModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModify_ItemClick);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Id = 4;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
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
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Name = "panelControl1";
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.JournalGrid);
            this.panelControl2.Name = "panelControl2";
            // 
            // JournalGrid
            // 
            resources.ApplyResources(this.JournalGrid, "JournalGrid");
            this.JournalGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("JournalGrid.EmbeddedNavigator.AccessibleDescription");
            this.JournalGrid.EmbeddedNavigator.AccessibleName = resources.GetString("JournalGrid.EmbeddedNavigator.AccessibleName");
            this.JournalGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("JournalGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.JournalGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("JournalGrid.EmbeddedNavigator.Anchor")));
            this.JournalGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JournalGrid.EmbeddedNavigator.BackgroundImage")));
            this.JournalGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("JournalGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.JournalGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("JournalGrid.EmbeddedNavigator.ImeMode")));
            this.JournalGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("JournalGrid.EmbeddedNavigator.MaximumSize")));
            this.JournalGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("JournalGrid.EmbeddedNavigator.TextLocation")));
            this.JournalGrid.EmbeddedNavigator.ToolTip = resources.GetString("JournalGrid.EmbeddedNavigator.ToolTip");
            this.JournalGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("JournalGrid.EmbeddedNavigator.ToolTipIconType")));
            this.JournalGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("JournalGrid.EmbeddedNavigator.ToolTipTitle");
            this.JournalGrid.MainView = this.JournalView;
            this.JournalGrid.Name = "JournalGrid";
            this.JournalGrid.UseEmbeddedNavigator = true;
            this.JournalGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.JournalView});
            // 
            // JournalView
            // 
            this.JournalView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.JournalView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.JournalView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.ColumnFilterButton.GradientMode")));
            this.JournalView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.ColumnFilterButton.Image")));
            this.JournalView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.JournalView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.FocusedCell.FontSizeDelta")));
            this.JournalView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.FocusedCell.FontStyleDelta")));
            this.JournalView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.FocusedCell.GradientMode")));
            this.JournalView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.FocusedCell.Image")));
            this.JournalView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.JournalView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.FocusedRow.FontSizeDelta")));
            this.JournalView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.FocusedRow.FontStyleDelta")));
            this.JournalView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.FocusedRow.GradientMode")));
            this.JournalView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.FocusedRow.Image")));
            this.JournalView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.JournalView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.HeaderPanel.FontSizeDelta")));
            this.JournalView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.HeaderPanel.FontStyleDelta")));
            this.JournalView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.HeaderPanel.GradientMode")));
            this.JournalView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.HeaderPanel.Image")));
            this.JournalView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.JournalView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.HorzLine.FontSizeDelta")));
            this.JournalView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.HorzLine.FontStyleDelta")));
            this.JournalView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.HorzLine.GradientMode")));
            this.JournalView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.HorzLine.Image")));
            this.JournalView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.JournalView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.OddRow.FontSizeDelta")));
            this.JournalView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.OddRow.FontStyleDelta")));
            this.JournalView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.OddRow.GradientMode")));
            this.JournalView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.OddRow.Image")));
            this.JournalView.Appearance.OddRow.Options.UseTextOptions = true;
            this.JournalView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.Preview.FontSizeDelta")));
            this.JournalView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.Preview.FontStyleDelta")));
            this.JournalView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.Preview.GradientMode")));
            this.JournalView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.Preview.Image")));
            this.JournalView.Appearance.Preview.Options.UseTextOptions = true;
            this.JournalView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.Row.FontSizeDelta")));
            this.JournalView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.Row.FontStyleDelta")));
            this.JournalView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.Row.GradientMode")));
            this.JournalView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.Row.Image")));
            this.JournalView.Appearance.Row.Options.UseTextOptions = true;
            this.JournalView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.SelectedRow.FontSizeDelta")));
            this.JournalView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.SelectedRow.FontStyleDelta")));
            this.JournalView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.SelectedRow.GradientMode")));
            this.JournalView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.SelectedRow.Image")));
            this.JournalView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.JournalView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.TopNewRow.FontSizeDelta")));
            this.JournalView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.TopNewRow.FontStyleDelta")));
            this.JournalView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.TopNewRow.GradientMode")));
            this.JournalView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.TopNewRow.Image")));
            this.JournalView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.JournalView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.VertLine.FontSizeDelta")));
            this.JournalView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.VertLine.FontStyleDelta")));
            this.JournalView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.VertLine.GradientMode")));
            this.JournalView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.VertLine.Image")));
            this.JournalView.Appearance.VertLine.Options.UseTextOptions = true;
            this.JournalView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("JournalView.Appearance.ViewCaption.FontSizeDelta")));
            this.JournalView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JournalView.Appearance.ViewCaption.FontStyleDelta")));
            this.JournalView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JournalView.Appearance.ViewCaption.GradientMode")));
            this.JournalView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("JournalView.Appearance.ViewCaption.Image")));
            this.JournalView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.JournalView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JournalView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JournalView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JournalView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.JournalView, "JournalView");
            this.JournalView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.JournalView.GridControl = this.JournalGrid;
            this.JournalView.Name = "JournalView";
            this.JournalView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.JournalView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.JournalView.OptionsBehavior.AllowIncrementalSearch = true;
            this.JournalView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.JournalView.OptionsBehavior.Editable = false;
            this.JournalView.OptionsBehavior.SmartVertScrollBar = false;
            this.JournalView.OptionsCustomization.AllowColumnMoving = false;
            this.JournalView.OptionsCustomization.AllowColumnResizing = false;
            this.JournalView.OptionsCustomization.AllowFilter = false;
            this.JournalView.OptionsCustomization.AllowGroup = false;
            this.JournalView.OptionsFind.AlwaysVisible = true;
            this.JournalView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.JournalView.OptionsPrint.EnableAppearanceOddRow = true;
            this.JournalView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.JournalView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.JournalView.OptionsView.EnableAppearanceEvenRow = true;
            this.JournalView.OptionsView.EnableAppearanceOddRow = true;
            this.JournalView.OptionsView.RowAutoHeight = true;
            this.JournalView.OptionsView.ShowGroupPanel = false;
            this.JournalView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.JournalView_RowClick);
            this.JournalView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.JournalView_FocusedRowChanged);
            this.JournalView.RowCountChanged += new System.EventHandler(this.JournalView_RowCountChanged);
            // 
            // panelControl3
            // 
            resources.ApplyResources(this.panelControl3, "panelControl3");
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.txtJournalCode);
            this.panelControl3.Controls.Add(this.txtJournalName);
            this.panelControl3.Name = "panelControl3";
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
            // txtJournalCode
            // 
            resources.ApplyResources(this.txtJournalCode, "txtJournalCode");
            this.txtJournalCode.Name = "txtJournalCode";
            this.txtJournalCode.Properties.AccessibleDescription = resources.GetString("txtJournalCode.Properties.AccessibleDescription");
            this.txtJournalCode.Properties.AccessibleName = resources.GetString("txtJournalCode.Properties.AccessibleName");
            this.txtJournalCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtJournalCode.Properties.AutoHeight")));
            this.txtJournalCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtJournalCode.Properties.Mask.AutoComplete")));
            this.txtJournalCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtJournalCode.Properties.Mask.BeepOnError")));
            this.txtJournalCode.Properties.Mask.EditMask = resources.GetString("txtJournalCode.Properties.Mask.EditMask");
            this.txtJournalCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtJournalCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtJournalCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtJournalCode.Properties.Mask.MaskType")));
            this.txtJournalCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtJournalCode.Properties.Mask.PlaceHolder")));
            this.txtJournalCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtJournalCode.Properties.Mask.SaveLiteral")));
            this.txtJournalCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtJournalCode.Properties.Mask.ShowPlaceHolders")));
            this.txtJournalCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtJournalCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtJournalCode.Properties.NullValuePrompt = resources.GetString("txtJournalCode.Properties.NullValuePrompt");
            this.txtJournalCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtJournalCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtJournalName
            // 
            resources.ApplyResources(this.txtJournalName, "txtJournalName");
            this.txtJournalName.Name = "txtJournalName";
            this.txtJournalName.Properties.AccessibleDescription = resources.GetString("txtJournalName.Properties.AccessibleDescription");
            this.txtJournalName.Properties.AccessibleName = resources.GetString("txtJournalName.Properties.AccessibleName");
            this.txtJournalName.Properties.AutoHeight = ((bool)(resources.GetObject("txtJournalName.Properties.AutoHeight")));
            this.txtJournalName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtJournalName.Properties.Mask.AutoComplete")));
            this.txtJournalName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtJournalName.Properties.Mask.BeepOnError")));
            this.txtJournalName.Properties.Mask.EditMask = resources.GetString("txtJournalName.Properties.Mask.EditMask");
            this.txtJournalName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtJournalName.Properties.Mask.IgnoreMaskBlank")));
            this.txtJournalName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtJournalName.Properties.Mask.MaskType")));
            this.txtJournalName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtJournalName.Properties.Mask.PlaceHolder")));
            this.txtJournalName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtJournalName.Properties.Mask.SaveLiteral")));
            this.txtJournalName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtJournalName.Properties.Mask.ShowPlaceHolders")));
            this.txtJournalName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtJournalName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtJournalName.Properties.NullValuePrompt = resources.GetString("txtJournalName.Properties.NullValuePrompt");
            this.txtJournalName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtJournalName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // FRM_Journal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_Journal";
            this.Ribbon = this.ribbon;
            this.Load += new System.EventHandler(this.FRM_Journal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JournalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJournalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJournalName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnModify;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl JournalGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView JournalView;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtJournalCode;
        private DevExpress.XtraEditors.TextEdit txtJournalName;
    }
}