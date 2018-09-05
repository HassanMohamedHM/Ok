namespace UILayer.WareHouses
{
    partial class Frm_WareHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_WareHouse));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.WareHouseGrid = new DevExpress.XtraGrid.GridControl();
            this.WareHouseView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.cmbManager = new System.Windows.Forms.ComboBox();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtNotes = new DevExpress.XtraEditors.TextEdit();
            this.txtWareHouseName = new DevExpress.XtraEditors.TextEdit();
            this.txtWareHouseCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WareHouseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WareHouseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareHouseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareHouseCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            resources.ApplyResources(this.splitContainerControl1, "splitContainerControl1");
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Name = "splitContainerControl1";
            resources.ApplyResources(this.splitContainerControl1.Panel1, "splitContainerControl1.Panel1");
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel1.Controls.Add(this.WareHouseGrid);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl7);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl6);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.cmbType);
            this.splitContainerControl1.Panel2.Controls.Add(this.cmbSite);
            this.splitContainerControl1.Panel2.Controls.Add(this.cmbManager);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnPrev);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnFirst);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLast);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnNext);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnModify);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnAddNew);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtNotes);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtWareHouseName);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtWareHouseCode);
            this.splitContainerControl1.SplitterPosition = 790;
            // 
            // WareHouseGrid
            // 
            resources.ApplyResources(this.WareHouseGrid, "WareHouseGrid");
            this.WareHouseGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("WareHouseGrid.EmbeddedNavigator.AccessibleDescription");
            this.WareHouseGrid.EmbeddedNavigator.AccessibleName = resources.GetString("WareHouseGrid.EmbeddedNavigator.AccessibleName");
            this.WareHouseGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("WareHouseGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.WareHouseGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("WareHouseGrid.EmbeddedNavigator.Anchor")));
            this.WareHouseGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WareHouseGrid.EmbeddedNavigator.BackgroundImage")));
            this.WareHouseGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("WareHouseGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.WareHouseGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("WareHouseGrid.EmbeddedNavigator.ImeMode")));
            this.WareHouseGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("WareHouseGrid.EmbeddedNavigator.MaximumSize")));
            this.WareHouseGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("WareHouseGrid.EmbeddedNavigator.TextLocation")));
            this.WareHouseGrid.EmbeddedNavigator.ToolTip = resources.GetString("WareHouseGrid.EmbeddedNavigator.ToolTip");
            this.WareHouseGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("WareHouseGrid.EmbeddedNavigator.ToolTipIconType")));
            this.WareHouseGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("WareHouseGrid.EmbeddedNavigator.ToolTipTitle");
            this.WareHouseGrid.MainView = this.WareHouseView;
            this.WareHouseGrid.Name = "WareHouseGrid";
            this.WareHouseGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.WareHouseView});
            // 
            // WareHouseView
            // 
            this.WareHouseView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.WareHouseView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.WareHouseView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.ColumnFilterButton.GradientMode")));
            this.WareHouseView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.ColumnFilterButton.Image")));
            this.WareHouseView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.FocusedCell.FontSizeDelta")));
            this.WareHouseView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.FocusedCell.FontStyleDelta")));
            this.WareHouseView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.FocusedCell.GradientMode")));
            this.WareHouseView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.FocusedCell.Image")));
            this.WareHouseView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.FocusedRow.FontSizeDelta")));
            this.WareHouseView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.FocusedRow.FontStyleDelta")));
            this.WareHouseView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.FocusedRow.GradientMode")));
            this.WareHouseView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.FocusedRow.Image")));
            this.WareHouseView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.HeaderPanel.FontSizeDelta")));
            this.WareHouseView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.HeaderPanel.FontStyleDelta")));
            this.WareHouseView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.HeaderPanel.GradientMode")));
            this.WareHouseView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.HeaderPanel.Image")));
            this.WareHouseView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.HorzLine.FontSizeDelta")));
            this.WareHouseView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.HorzLine.FontStyleDelta")));
            this.WareHouseView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.HorzLine.GradientMode")));
            this.WareHouseView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.HorzLine.Image")));
            this.WareHouseView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.OddRow.FontSizeDelta")));
            this.WareHouseView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.OddRow.FontStyleDelta")));
            this.WareHouseView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.OddRow.GradientMode")));
            this.WareHouseView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.OddRow.Image")));
            this.WareHouseView.Appearance.OddRow.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.Preview.FontSizeDelta")));
            this.WareHouseView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.Preview.FontStyleDelta")));
            this.WareHouseView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.Preview.GradientMode")));
            this.WareHouseView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.Preview.Image")));
            this.WareHouseView.Appearance.Preview.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.Row.FontSizeDelta")));
            this.WareHouseView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.Row.FontStyleDelta")));
            this.WareHouseView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.Row.GradientMode")));
            this.WareHouseView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.Row.Image")));
            this.WareHouseView.Appearance.Row.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.SelectedRow.FontSizeDelta")));
            this.WareHouseView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.SelectedRow.FontStyleDelta")));
            this.WareHouseView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.SelectedRow.GradientMode")));
            this.WareHouseView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.SelectedRow.Image")));
            this.WareHouseView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.TopNewRow.FontSizeDelta")));
            this.WareHouseView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.TopNewRow.FontStyleDelta")));
            this.WareHouseView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.TopNewRow.GradientMode")));
            this.WareHouseView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.TopNewRow.Image")));
            this.WareHouseView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.VertLine.FontSizeDelta")));
            this.WareHouseView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.VertLine.FontStyleDelta")));
            this.WareHouseView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.VertLine.GradientMode")));
            this.WareHouseView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.VertLine.Image")));
            this.WareHouseView.Appearance.VertLine.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("WareHouseView.Appearance.ViewCaption.FontSizeDelta")));
            this.WareHouseView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("WareHouseView.Appearance.ViewCaption.FontStyleDelta")));
            this.WareHouseView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("WareHouseView.Appearance.ViewCaption.GradientMode")));
            this.WareHouseView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("WareHouseView.Appearance.ViewCaption.Image")));
            this.WareHouseView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.WareHouseView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WareHouseView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WareHouseView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WareHouseView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.WareHouseView, "WareHouseView");
            this.WareHouseView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.WareHouseView.GridControl = this.WareHouseGrid;
            this.WareHouseView.Name = "WareHouseView";
            this.WareHouseView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.WareHouseView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.WareHouseView.OptionsBehavior.AllowIncrementalSearch = true;
            this.WareHouseView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.WareHouseView.OptionsBehavior.Editable = false;
            this.WareHouseView.OptionsCustomization.AllowColumnMoving = false;
            this.WareHouseView.OptionsCustomization.AllowColumnResizing = false;
            this.WareHouseView.OptionsCustomization.AllowFilter = false;
            this.WareHouseView.OptionsCustomization.AllowGroup = false;
            this.WareHouseView.OptionsFind.AlwaysVisible = true;
            this.WareHouseView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.WareHouseView.OptionsPrint.EnableAppearanceOddRow = true;
            this.WareHouseView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.WareHouseView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.WareHouseView.OptionsView.EnableAppearanceEvenRow = true;
            this.WareHouseView.OptionsView.EnableAppearanceOddRow = true;
            this.WareHouseView.OptionsView.RowAutoHeight = true;
            this.WareHouseView.OptionsView.ShowGroupPanel = false;
            this.WareHouseView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.WareHouseView_RowClick);
            this.WareHouseView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.WareHouseView_FocusedRowChanged);
            this.WareHouseView.RowCountChanged += new System.EventHandler(this.WareHouseView_RowCountChanged);
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
            // cmbType
            // 
            resources.ApplyResources(this.cmbType, "cmbType");
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Name = "cmbType";
            // 
            // cmbSite
            // 
            resources.ApplyResources(this.cmbSite, "cmbSite");
            this.cmbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Name = "cmbSite";
            // 
            // cmbManager
            // 
            resources.ApplyResources(this.cmbManager, "cmbManager");
            this.cmbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManager.FormattingEnabled = true;
            this.cmbManager.Name = "cmbManager";
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
            // txtWareHouseName
            // 
            resources.ApplyResources(this.txtWareHouseName, "txtWareHouseName");
            this.txtWareHouseName.Name = "txtWareHouseName";
            this.txtWareHouseName.Properties.AccessibleDescription = resources.GetString("txtWareHouseName.Properties.AccessibleDescription");
            this.txtWareHouseName.Properties.AccessibleName = resources.GetString("txtWareHouseName.Properties.AccessibleName");
            this.txtWareHouseName.Properties.AutoHeight = ((bool)(resources.GetObject("txtWareHouseName.Properties.AutoHeight")));
            this.txtWareHouseName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtWareHouseName.Properties.Mask.AutoComplete")));
            this.txtWareHouseName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtWareHouseName.Properties.Mask.BeepOnError")));
            this.txtWareHouseName.Properties.Mask.EditMask = resources.GetString("txtWareHouseName.Properties.Mask.EditMask");
            this.txtWareHouseName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtWareHouseName.Properties.Mask.IgnoreMaskBlank")));
            this.txtWareHouseName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtWareHouseName.Properties.Mask.MaskType")));
            this.txtWareHouseName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtWareHouseName.Properties.Mask.PlaceHolder")));
            this.txtWareHouseName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtWareHouseName.Properties.Mask.SaveLiteral")));
            this.txtWareHouseName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtWareHouseName.Properties.Mask.ShowPlaceHolders")));
            this.txtWareHouseName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtWareHouseName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtWareHouseName.Properties.NullValuePrompt = resources.GetString("txtWareHouseName.Properties.NullValuePrompt");
            this.txtWareHouseName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtWareHouseName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtWareHouseCode
            // 
            resources.ApplyResources(this.txtWareHouseCode, "txtWareHouseCode");
            this.txtWareHouseCode.Name = "txtWareHouseCode";
            this.txtWareHouseCode.Properties.AccessibleDescription = resources.GetString("txtWareHouseCode.Properties.AccessibleDescription");
            this.txtWareHouseCode.Properties.AccessibleName = resources.GetString("txtWareHouseCode.Properties.AccessibleName");
            this.txtWareHouseCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtWareHouseCode.Properties.AutoHeight")));
            this.txtWareHouseCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtWareHouseCode.Properties.Mask.AutoComplete")));
            this.txtWareHouseCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtWareHouseCode.Properties.Mask.BeepOnError")));
            this.txtWareHouseCode.Properties.Mask.EditMask = resources.GetString("txtWareHouseCode.Properties.Mask.EditMask");
            this.txtWareHouseCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtWareHouseCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtWareHouseCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtWareHouseCode.Properties.Mask.MaskType")));
            this.txtWareHouseCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtWareHouseCode.Properties.Mask.PlaceHolder")));
            this.txtWareHouseCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtWareHouseCode.Properties.Mask.SaveLiteral")));
            this.txtWareHouseCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtWareHouseCode.Properties.Mask.ShowPlaceHolders")));
            this.txtWareHouseCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtWareHouseCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtWareHouseCode.Properties.NullValuePrompt = resources.GetString("txtWareHouseCode.Properties.NullValuePrompt");
            this.txtWareHouseCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtWareHouseCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // Frm_WareHouse
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_WareHouse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_WareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WareHouseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WareHouseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareHouseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareHouseCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.ComboBox cmbManager;
        private DevExpress.XtraEditors.TextEdit txtNotes;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.TextEdit txtWareHouseName;
        private DevExpress.XtraEditors.TextEdit txtWareHouseCode;
        private DevExpress.XtraGrid.GridControl WareHouseGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView WareHouseView;
        private System.Windows.Forms.ComboBox cmbType;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}