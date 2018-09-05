namespace UILayer.Products
{
    partial class FRM_Unit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Unit));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.UnitGrid = new DevExpress.XtraGrid.GridControl();
            this.UnitView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.CategorySearch = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtUnitName = new DevExpress.XtraEditors.TextEdit();
            this.txtUnitCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategorySearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.UnitGrid);
            this.panelControl1.Name = "panelControl1";
            // 
            // UnitGrid
            // 
            resources.ApplyResources(this.UnitGrid, "UnitGrid");
            this.UnitGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("UnitGrid.EmbeddedNavigator.AccessibleDescription");
            this.UnitGrid.EmbeddedNavigator.AccessibleName = resources.GetString("UnitGrid.EmbeddedNavigator.AccessibleName");
            this.UnitGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("UnitGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.UnitGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("UnitGrid.EmbeddedNavigator.Anchor")));
            this.UnitGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UnitGrid.EmbeddedNavigator.BackgroundImage")));
            this.UnitGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("UnitGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.UnitGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("UnitGrid.EmbeddedNavigator.ImeMode")));
            this.UnitGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("UnitGrid.EmbeddedNavigator.MaximumSize")));
            this.UnitGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("UnitGrid.EmbeddedNavigator.TextLocation")));
            this.UnitGrid.EmbeddedNavigator.ToolTip = resources.GetString("UnitGrid.EmbeddedNavigator.ToolTip");
            this.UnitGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("UnitGrid.EmbeddedNavigator.ToolTipIconType")));
            this.UnitGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("UnitGrid.EmbeddedNavigator.ToolTipTitle");
            this.UnitGrid.MainView = this.UnitView;
            this.UnitGrid.Name = "UnitGrid";
            this.UnitGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UnitView});
            // 
            // UnitView
            // 
            this.UnitView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.UnitView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.UnitView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.ColumnFilterButton.GradientMode")));
            this.UnitView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.ColumnFilterButton.Image")));
            this.UnitView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.UnitView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.FocusedCell.FontSizeDelta")));
            this.UnitView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.FocusedCell.FontStyleDelta")));
            this.UnitView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.FocusedCell.GradientMode")));
            this.UnitView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.FocusedCell.Image")));
            this.UnitView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.UnitView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.FocusedRow.FontSizeDelta")));
            this.UnitView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.FocusedRow.FontStyleDelta")));
            this.UnitView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.FocusedRow.GradientMode")));
            this.UnitView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.FocusedRow.Image")));
            this.UnitView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.UnitView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.HeaderPanel.FontSizeDelta")));
            this.UnitView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.HeaderPanel.FontStyleDelta")));
            this.UnitView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.HeaderPanel.GradientMode")));
            this.UnitView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.HeaderPanel.Image")));
            this.UnitView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.UnitView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.HorzLine.FontSizeDelta")));
            this.UnitView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.HorzLine.FontStyleDelta")));
            this.UnitView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.HorzLine.GradientMode")));
            this.UnitView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.HorzLine.Image")));
            this.UnitView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.UnitView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.OddRow.FontSizeDelta")));
            this.UnitView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.OddRow.FontStyleDelta")));
            this.UnitView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.OddRow.GradientMode")));
            this.UnitView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.OddRow.Image")));
            this.UnitView.Appearance.OddRow.Options.UseTextOptions = true;
            this.UnitView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.Preview.FontSizeDelta")));
            this.UnitView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.Preview.FontStyleDelta")));
            this.UnitView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.Preview.GradientMode")));
            this.UnitView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.Preview.Image")));
            this.UnitView.Appearance.Preview.Options.UseTextOptions = true;
            this.UnitView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.Row.FontSizeDelta")));
            this.UnitView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.Row.FontStyleDelta")));
            this.UnitView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.Row.GradientMode")));
            this.UnitView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.Row.Image")));
            this.UnitView.Appearance.Row.Options.UseTextOptions = true;
            this.UnitView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.SelectedRow.FontSizeDelta")));
            this.UnitView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.SelectedRow.FontStyleDelta")));
            this.UnitView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.SelectedRow.GradientMode")));
            this.UnitView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.SelectedRow.Image")));
            this.UnitView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.UnitView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.TopNewRow.FontSizeDelta")));
            this.UnitView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.TopNewRow.FontStyleDelta")));
            this.UnitView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.TopNewRow.GradientMode")));
            this.UnitView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.TopNewRow.Image")));
            this.UnitView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.UnitView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.VertLine.FontSizeDelta")));
            this.UnitView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.VertLine.FontStyleDelta")));
            this.UnitView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.VertLine.GradientMode")));
            this.UnitView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.VertLine.Image")));
            this.UnitView.Appearance.VertLine.Options.UseTextOptions = true;
            this.UnitView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("UnitView.Appearance.ViewCaption.FontSizeDelta")));
            this.UnitView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UnitView.Appearance.ViewCaption.FontStyleDelta")));
            this.UnitView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UnitView.Appearance.ViewCaption.GradientMode")));
            this.UnitView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("UnitView.Appearance.ViewCaption.Image")));
            this.UnitView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.UnitView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UnitView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.UnitView, "UnitView");
            this.UnitView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.UnitView.GridControl = this.UnitGrid;
            this.UnitView.Name = "UnitView";
            this.UnitView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.UnitView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.UnitView.OptionsBehavior.AllowIncrementalSearch = true;
            this.UnitView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.UnitView.OptionsBehavior.Editable = false;
            this.UnitView.OptionsCustomization.AllowColumnMoving = false;
            this.UnitView.OptionsCustomization.AllowColumnResizing = false;
            this.UnitView.OptionsCustomization.AllowFilter = false;
            this.UnitView.OptionsCustomization.AllowGroup = false;
            this.UnitView.OptionsFind.AlwaysVisible = true;
            this.UnitView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.UnitView.OptionsPrint.EnableAppearanceOddRow = true;
            this.UnitView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.UnitView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.UnitView.OptionsView.EnableAppearanceEvenRow = true;
            this.UnitView.OptionsView.EnableAppearanceOddRow = true;
            this.UnitView.OptionsView.RowAutoHeight = true;
            this.UnitView.OptionsView.ShowGroupPanel = false;
            this.UnitView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.UnitView_RowClick);
            this.UnitView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UnitView_FocusedRowChanged);
            this.UnitView.RowCountChanged += new System.EventHandler(this.UnitView_RowCountChanged);
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.CategorySearch);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btnPrev);
            this.panelControl2.Controls.Add(this.btnFirst);
            this.panelControl2.Controls.Add(this.btnLast);
            this.panelControl2.Controls.Add(this.btnNext);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.btnModify);
            this.panelControl2.Controls.Add(this.btnAddNew);
            this.panelControl2.Controls.Add(this.txtUnitName);
            this.panelControl2.Controls.Add(this.txtUnitCode);
            this.panelControl2.Name = "panelControl2";
            // 
            // CategorySearch
            // 
            resources.ApplyResources(this.CategorySearch, "CategorySearch");
            this.CategorySearch.Name = "CategorySearch";
            this.CategorySearch.Properties.AccessibleDescription = resources.GetString("CategorySearch.Properties.AccessibleDescription");
            this.CategorySearch.Properties.AccessibleName = resources.GetString("CategorySearch.Properties.AccessibleName");
            this.CategorySearch.Properties.AutoHeight = ((bool)(resources.GetObject("CategorySearch.Properties.AutoHeight")));
            this.CategorySearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("CategorySearch.Properties.Buttons"))))});
            this.CategorySearch.Properties.NullValuePrompt = resources.GetString("CategorySearch.Properties.NullValuePrompt");
            this.CategorySearch.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("CategorySearch.Properties.NullValuePromptShowForEmptyValue")));
            this.CategorySearch.Properties.View = this.searchLookUpEdit1View;
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
            // btnPrev
            // 
            resources.ApplyResources(this.btnPrev, "btnPrev");
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            resources.ApplyResources(this.btnFirst, "btnFirst");
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            resources.ApplyResources(this.btnLast, "btnLast");
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLast.Name = "btnLast";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.Name = "btnNext";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            resources.ApplyResources(this.btnModify, "btnModify");
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Name = "btnModify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAddNew
            // 
            resources.ApplyResources(this.btnAddNew, "btnAddNew");
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtUnitName
            // 
            resources.ApplyResources(this.txtUnitName, "txtUnitName");
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Properties.AccessibleDescription = resources.GetString("txtUnitName.Properties.AccessibleDescription");
            this.txtUnitName.Properties.AccessibleName = resources.GetString("txtUnitName.Properties.AccessibleName");
            this.txtUnitName.Properties.AutoHeight = ((bool)(resources.GetObject("txtUnitName.Properties.AutoHeight")));
            this.txtUnitName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtUnitName.Properties.Mask.AutoComplete")));
            this.txtUnitName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtUnitName.Properties.Mask.BeepOnError")));
            this.txtUnitName.Properties.Mask.EditMask = resources.GetString("txtUnitName.Properties.Mask.EditMask");
            this.txtUnitName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtUnitName.Properties.Mask.IgnoreMaskBlank")));
            this.txtUnitName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtUnitName.Properties.Mask.MaskType")));
            this.txtUnitName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtUnitName.Properties.Mask.PlaceHolder")));
            this.txtUnitName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtUnitName.Properties.Mask.SaveLiteral")));
            this.txtUnitName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtUnitName.Properties.Mask.ShowPlaceHolders")));
            this.txtUnitName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtUnitName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtUnitName.Properties.NullValuePrompt = resources.GetString("txtUnitName.Properties.NullValuePrompt");
            this.txtUnitName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtUnitName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtUnitCode
            // 
            resources.ApplyResources(this.txtUnitCode, "txtUnitCode");
            this.txtUnitCode.Name = "txtUnitCode";
            this.txtUnitCode.Properties.AccessibleDescription = resources.GetString("txtUnitCode.Properties.AccessibleDescription");
            this.txtUnitCode.Properties.AccessibleName = resources.GetString("txtUnitCode.Properties.AccessibleName");
            this.txtUnitCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtUnitCode.Properties.AutoHeight")));
            this.txtUnitCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtUnitCode.Properties.Mask.AutoComplete")));
            this.txtUnitCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtUnitCode.Properties.Mask.BeepOnError")));
            this.txtUnitCode.Properties.Mask.EditMask = resources.GetString("txtUnitCode.Properties.Mask.EditMask");
            this.txtUnitCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtUnitCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtUnitCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtUnitCode.Properties.Mask.MaskType")));
            this.txtUnitCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtUnitCode.Properties.Mask.PlaceHolder")));
            this.txtUnitCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtUnitCode.Properties.Mask.SaveLiteral")));
            this.txtUnitCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtUnitCode.Properties.Mask.ShowPlaceHolders")));
            this.txtUnitCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtUnitCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtUnitCode.Properties.NullValuePrompt = resources.GetString("txtUnitCode.Properties.NullValuePrompt");
            this.txtUnitCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtUnitCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // FRM_Unit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_Unit";
            this.Load += new System.EventHandler(this.FRM_Unit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnitGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategorySearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl UnitGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView UnitView;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.TextEdit txtUnitName;
        private DevExpress.XtraEditors.TextEdit txtUnitCode;
        private DevExpress.XtraEditors.SearchLookUpEdit CategorySearch;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;

    }
}