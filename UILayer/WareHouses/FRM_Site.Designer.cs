namespace UILayer.WareHouses
{
    partial class FRM_Site
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Site));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.SiteGrid = new DevExpress.XtraGrid.GridControl();
            this.SiteView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtNotes = new DevExpress.XtraEditors.TextEdit();
            this.txtSiteAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtSiteName = new DevExpress.XtraEditors.TextEdit();
            this.txtSiteCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SiteGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiteView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteCode.Properties)).BeginInit();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.SiteGrid);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl7);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl6);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.cmbCountry);
            this.splitContainerControl1.Panel2.Controls.Add(this.cmbType);
            this.splitContainerControl1.Panel2.Controls.Add(this.cmbCity);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnPrev);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnFirst);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLast);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnNext);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnModify);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnAddNew);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtNotes);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtSiteAddress);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtSiteName);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtSiteCode);
            this.splitContainerControl1.SplitterPosition = 787;
            // 
            // SiteGrid
            // 
            resources.ApplyResources(this.SiteGrid, "SiteGrid");
            this.SiteGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("SiteGrid.EmbeddedNavigator.AccessibleDescription");
            this.SiteGrid.EmbeddedNavigator.AccessibleName = resources.GetString("SiteGrid.EmbeddedNavigator.AccessibleName");
            this.SiteGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("SiteGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.SiteGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("SiteGrid.EmbeddedNavigator.Anchor")));
            this.SiteGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SiteGrid.EmbeddedNavigator.BackgroundImage")));
            this.SiteGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("SiteGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.SiteGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("SiteGrid.EmbeddedNavigator.ImeMode")));
            this.SiteGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("SiteGrid.EmbeddedNavigator.MaximumSize")));
            this.SiteGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("SiteGrid.EmbeddedNavigator.TextLocation")));
            this.SiteGrid.EmbeddedNavigator.ToolTip = resources.GetString("SiteGrid.EmbeddedNavigator.ToolTip");
            this.SiteGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("SiteGrid.EmbeddedNavigator.ToolTipIconType")));
            this.SiteGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("SiteGrid.EmbeddedNavigator.ToolTipTitle");
            this.SiteGrid.MainView = this.SiteView;
            this.SiteGrid.Name = "SiteGrid";
            this.SiteGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SiteView});
            // 
            // SiteView
            // 
            this.SiteView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.SiteView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.SiteView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.ColumnFilterButton.GradientMode")));
            this.SiteView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.ColumnFilterButton.Image")));
            this.SiteView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.SiteView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.FocusedCell.FontSizeDelta")));
            this.SiteView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.FocusedCell.FontStyleDelta")));
            this.SiteView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.FocusedCell.GradientMode")));
            this.SiteView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.FocusedCell.Image")));
            this.SiteView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.SiteView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.FocusedRow.FontSizeDelta")));
            this.SiteView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.FocusedRow.FontStyleDelta")));
            this.SiteView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.FocusedRow.GradientMode")));
            this.SiteView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.FocusedRow.Image")));
            this.SiteView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.SiteView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.HeaderPanel.FontSizeDelta")));
            this.SiteView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.HeaderPanel.FontStyleDelta")));
            this.SiteView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.HeaderPanel.GradientMode")));
            this.SiteView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.HeaderPanel.Image")));
            this.SiteView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.SiteView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.HorzLine.FontSizeDelta")));
            this.SiteView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.HorzLine.FontStyleDelta")));
            this.SiteView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.HorzLine.GradientMode")));
            this.SiteView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.HorzLine.Image")));
            this.SiteView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.SiteView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.OddRow.FontSizeDelta")));
            this.SiteView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.OddRow.FontStyleDelta")));
            this.SiteView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.OddRow.GradientMode")));
            this.SiteView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.OddRow.Image")));
            this.SiteView.Appearance.OddRow.Options.UseTextOptions = true;
            this.SiteView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.Preview.FontSizeDelta")));
            this.SiteView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.Preview.FontStyleDelta")));
            this.SiteView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.Preview.GradientMode")));
            this.SiteView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.Preview.Image")));
            this.SiteView.Appearance.Preview.Options.UseTextOptions = true;
            this.SiteView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.Row.FontSizeDelta")));
            this.SiteView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.Row.FontStyleDelta")));
            this.SiteView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.Row.GradientMode")));
            this.SiteView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.Row.Image")));
            this.SiteView.Appearance.Row.Options.UseTextOptions = true;
            this.SiteView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.SelectedRow.FontSizeDelta")));
            this.SiteView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.SelectedRow.FontStyleDelta")));
            this.SiteView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.SelectedRow.GradientMode")));
            this.SiteView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.SelectedRow.Image")));
            this.SiteView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.SiteView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.TopNewRow.FontSizeDelta")));
            this.SiteView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.TopNewRow.FontStyleDelta")));
            this.SiteView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.TopNewRow.GradientMode")));
            this.SiteView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.TopNewRow.Image")));
            this.SiteView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.SiteView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.VertLine.FontSizeDelta")));
            this.SiteView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.VertLine.FontStyleDelta")));
            this.SiteView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.VertLine.GradientMode")));
            this.SiteView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.VertLine.Image")));
            this.SiteView.Appearance.VertLine.Options.UseTextOptions = true;
            this.SiteView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("SiteView.Appearance.ViewCaption.FontSizeDelta")));
            this.SiteView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("SiteView.Appearance.ViewCaption.FontStyleDelta")));
            this.SiteView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("SiteView.Appearance.ViewCaption.GradientMode")));
            this.SiteView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("SiteView.Appearance.ViewCaption.Image")));
            this.SiteView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.SiteView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiteView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SiteView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SiteView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.SiteView, "SiteView");
            this.SiteView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.SiteView.GridControl = this.SiteGrid;
            this.SiteView.Name = "SiteView";
            this.SiteView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.SiteView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.SiteView.OptionsBehavior.AllowIncrementalSearch = true;
            this.SiteView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.SiteView.OptionsBehavior.Editable = false;
            this.SiteView.OptionsCustomization.AllowColumnMoving = false;
            this.SiteView.OptionsCustomization.AllowColumnResizing = false;
            this.SiteView.OptionsCustomization.AllowFilter = false;
            this.SiteView.OptionsCustomization.AllowGroup = false;
            this.SiteView.OptionsFind.AlwaysVisible = true;
            this.SiteView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.SiteView.OptionsPrint.EnableAppearanceOddRow = true;
            this.SiteView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.SiteView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.SiteView.OptionsView.EnableAppearanceEvenRow = true;
            this.SiteView.OptionsView.EnableAppearanceOddRow = true;
            this.SiteView.OptionsView.RowAutoHeight = true;
            this.SiteView.OptionsView.ShowGroupPanel = false;
            this.SiteView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.SiteView_RowClick);
            this.SiteView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.SiteView_FocusedRowChanged);
            this.SiteView.RowCountChanged += new System.EventHandler(this.SiteView_RowCountChanged);
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
            // labelControl5
            // 
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
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
            // cmbCountry
            // 
            resources.ApplyResources(this.cmbCountry, "cmbCountry");
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.SelectionChangeCommitted += new System.EventHandler(this.cmbCountry_SelectionChangeCommitted);
            // 
            // cmbType
            // 
            resources.ApplyResources(this.cmbType, "cmbType");
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Name = "cmbType";
            // 
            // cmbCity
            // 
            resources.ApplyResources(this.cmbCity, "cmbCity");
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Name = "cmbCity";
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
            // txtSiteAddress
            // 
            resources.ApplyResources(this.txtSiteAddress, "txtSiteAddress");
            this.txtSiteAddress.Name = "txtSiteAddress";
            this.txtSiteAddress.Properties.AccessibleDescription = resources.GetString("txtSiteAddress.Properties.AccessibleDescription");
            this.txtSiteAddress.Properties.AccessibleName = resources.GetString("txtSiteAddress.Properties.AccessibleName");
            this.txtSiteAddress.Properties.AutoHeight = ((bool)(resources.GetObject("txtSiteAddress.Properties.AutoHeight")));
            this.txtSiteAddress.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtSiteAddress.Properties.Mask.AutoComplete")));
            this.txtSiteAddress.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtSiteAddress.Properties.Mask.BeepOnError")));
            this.txtSiteAddress.Properties.Mask.EditMask = resources.GetString("txtSiteAddress.Properties.Mask.EditMask");
            this.txtSiteAddress.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtSiteAddress.Properties.Mask.IgnoreMaskBlank")));
            this.txtSiteAddress.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtSiteAddress.Properties.Mask.MaskType")));
            this.txtSiteAddress.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtSiteAddress.Properties.Mask.PlaceHolder")));
            this.txtSiteAddress.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtSiteAddress.Properties.Mask.SaveLiteral")));
            this.txtSiteAddress.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtSiteAddress.Properties.Mask.ShowPlaceHolders")));
            this.txtSiteAddress.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtSiteAddress.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtSiteAddress.Properties.NullValuePrompt = resources.GetString("txtSiteAddress.Properties.NullValuePrompt");
            this.txtSiteAddress.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtSiteAddress.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtSiteName
            // 
            resources.ApplyResources(this.txtSiteName, "txtSiteName");
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Properties.AccessibleDescription = resources.GetString("txtSiteName.Properties.AccessibleDescription");
            this.txtSiteName.Properties.AccessibleName = resources.GetString("txtSiteName.Properties.AccessibleName");
            this.txtSiteName.Properties.AutoHeight = ((bool)(resources.GetObject("txtSiteName.Properties.AutoHeight")));
            this.txtSiteName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtSiteName.Properties.Mask.AutoComplete")));
            this.txtSiteName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtSiteName.Properties.Mask.BeepOnError")));
            this.txtSiteName.Properties.Mask.EditMask = resources.GetString("txtSiteName.Properties.Mask.EditMask");
            this.txtSiteName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtSiteName.Properties.Mask.IgnoreMaskBlank")));
            this.txtSiteName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtSiteName.Properties.Mask.MaskType")));
            this.txtSiteName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtSiteName.Properties.Mask.PlaceHolder")));
            this.txtSiteName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtSiteName.Properties.Mask.SaveLiteral")));
            this.txtSiteName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtSiteName.Properties.Mask.ShowPlaceHolders")));
            this.txtSiteName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtSiteName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtSiteName.Properties.NullValuePrompt = resources.GetString("txtSiteName.Properties.NullValuePrompt");
            this.txtSiteName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtSiteName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtSiteCode
            // 
            resources.ApplyResources(this.txtSiteCode, "txtSiteCode");
            this.txtSiteCode.Name = "txtSiteCode";
            this.txtSiteCode.Properties.AccessibleDescription = resources.GetString("txtSiteCode.Properties.AccessibleDescription");
            this.txtSiteCode.Properties.AccessibleName = resources.GetString("txtSiteCode.Properties.AccessibleName");
            this.txtSiteCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtSiteCode.Properties.AutoHeight")));
            this.txtSiteCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtSiteCode.Properties.Mask.AutoComplete")));
            this.txtSiteCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtSiteCode.Properties.Mask.BeepOnError")));
            this.txtSiteCode.Properties.Mask.EditMask = resources.GetString("txtSiteCode.Properties.Mask.EditMask");
            this.txtSiteCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtSiteCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtSiteCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtSiteCode.Properties.Mask.MaskType")));
            this.txtSiteCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtSiteCode.Properties.Mask.PlaceHolder")));
            this.txtSiteCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtSiteCode.Properties.Mask.SaveLiteral")));
            this.txtSiteCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtSiteCode.Properties.Mask.ShowPlaceHolders")));
            this.txtSiteCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtSiteCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtSiteCode.Properties.NullValuePrompt = resources.GetString("txtSiteCode.Properties.NullValuePrompt");
            this.txtSiteCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtSiteCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // FRM_Site
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_Site";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Site_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SiteGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiteView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.TextEdit txtSiteName;
        private DevExpress.XtraEditors.TextEdit txtSiteCode;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl SiteGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView SiteView;
        private System.Windows.Forms.ComboBox cmbCity;
        private DevExpress.XtraEditors.TextEdit txtNotes;
        private DevExpress.XtraEditors.TextEdit txtSiteAddress;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ComboBox cmbType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}