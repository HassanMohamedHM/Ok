namespace UILayer.General
{
    partial class FRM_City
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_City));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.CityGrid = new DevExpress.XtraGrid.GridControl();
            this.CityView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtCityName = new DevExpress.XtraEditors.TextEdit();
            this.txtCityCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityCode.Properties)).BeginInit();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.CityGrid);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.cmbCountry);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnPrev);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnFirst);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLast);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnNext);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnModify);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnAddNew);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtCityName);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtCityCode);
            this.splitContainerControl1.SplitterPosition = 784;
            // 
            // CityGrid
            // 
            resources.ApplyResources(this.CityGrid, "CityGrid");
            this.CityGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("CityGrid.EmbeddedNavigator.AccessibleDescription");
            this.CityGrid.EmbeddedNavigator.AccessibleName = resources.GetString("CityGrid.EmbeddedNavigator.AccessibleName");
            this.CityGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("CityGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.CityGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("CityGrid.EmbeddedNavigator.Anchor")));
            this.CityGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CityGrid.EmbeddedNavigator.BackgroundImage")));
            this.CityGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("CityGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.CityGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("CityGrid.EmbeddedNavigator.ImeMode")));
            this.CityGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("CityGrid.EmbeddedNavigator.MaximumSize")));
            this.CityGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("CityGrid.EmbeddedNavigator.TextLocation")));
            this.CityGrid.EmbeddedNavigator.ToolTip = resources.GetString("CityGrid.EmbeddedNavigator.ToolTip");
            this.CityGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("CityGrid.EmbeddedNavigator.ToolTipIconType")));
            this.CityGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("CityGrid.EmbeddedNavigator.ToolTipTitle");
            this.CityGrid.MainView = this.CityView;
            this.CityGrid.Name = "CityGrid";
            this.CityGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CityView});
            // 
            // CityView
            // 
            this.CityView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.CityView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.CityView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.ColumnFilterButton.GradientMode")));
            this.CityView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.ColumnFilterButton.Image")));
            this.CityView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.CityView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.FocusedCell.FontSizeDelta")));
            this.CityView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.FocusedCell.FontStyleDelta")));
            this.CityView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.FocusedCell.GradientMode")));
            this.CityView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.FocusedCell.Image")));
            this.CityView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.CityView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.FocusedRow.FontSizeDelta")));
            this.CityView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.FocusedRow.FontStyleDelta")));
            this.CityView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.FocusedRow.GradientMode")));
            this.CityView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.FocusedRow.Image")));
            this.CityView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.CityView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.HeaderPanel.FontSizeDelta")));
            this.CityView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.HeaderPanel.FontStyleDelta")));
            this.CityView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.HeaderPanel.GradientMode")));
            this.CityView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.HeaderPanel.Image")));
            this.CityView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.CityView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.HorzLine.FontSizeDelta")));
            this.CityView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.HorzLine.FontStyleDelta")));
            this.CityView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.HorzLine.GradientMode")));
            this.CityView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.HorzLine.Image")));
            this.CityView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.CityView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.OddRow.FontSizeDelta")));
            this.CityView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.OddRow.FontStyleDelta")));
            this.CityView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.OddRow.GradientMode")));
            this.CityView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.OddRow.Image")));
            this.CityView.Appearance.OddRow.Options.UseTextOptions = true;
            this.CityView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.Preview.FontSizeDelta")));
            this.CityView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.Preview.FontStyleDelta")));
            this.CityView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.Preview.GradientMode")));
            this.CityView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.Preview.Image")));
            this.CityView.Appearance.Preview.Options.UseTextOptions = true;
            this.CityView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.Row.FontSizeDelta")));
            this.CityView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.Row.FontStyleDelta")));
            this.CityView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.Row.GradientMode")));
            this.CityView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.Row.Image")));
            this.CityView.Appearance.Row.Options.UseTextOptions = true;
            this.CityView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.SelectedRow.FontSizeDelta")));
            this.CityView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.SelectedRow.FontStyleDelta")));
            this.CityView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.SelectedRow.GradientMode")));
            this.CityView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.SelectedRow.Image")));
            this.CityView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.CityView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.TopNewRow.FontSizeDelta")));
            this.CityView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.TopNewRow.FontStyleDelta")));
            this.CityView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.TopNewRow.GradientMode")));
            this.CityView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.TopNewRow.Image")));
            this.CityView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.CityView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.VertLine.FontSizeDelta")));
            this.CityView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.VertLine.FontStyleDelta")));
            this.CityView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.VertLine.GradientMode")));
            this.CityView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.VertLine.Image")));
            this.CityView.Appearance.VertLine.Options.UseTextOptions = true;
            this.CityView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("CityView.Appearance.ViewCaption.FontSizeDelta")));
            this.CityView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CityView.Appearance.ViewCaption.FontStyleDelta")));
            this.CityView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CityView.Appearance.ViewCaption.GradientMode")));
            this.CityView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("CityView.Appearance.ViewCaption.Image")));
            this.CityView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.CityView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CityView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CityView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CityView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.CityView, "CityView");
            this.CityView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.CityView.GridControl = this.CityGrid;
            this.CityView.Name = "CityView";
            this.CityView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.CityView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.CityView.OptionsBehavior.AllowIncrementalSearch = true;
            this.CityView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.CityView.OptionsBehavior.Editable = false;
            this.CityView.OptionsCustomization.AllowColumnMoving = false;
            this.CityView.OptionsCustomization.AllowColumnResizing = false;
            this.CityView.OptionsCustomization.AllowFilter = false;
            this.CityView.OptionsCustomization.AllowGroup = false;
            this.CityView.OptionsFind.AlwaysVisible = true;
            this.CityView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.CityView.OptionsPrint.EnableAppearanceOddRow = true;
            this.CityView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.CityView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.CityView.OptionsView.EnableAppearanceEvenRow = true;
            this.CityView.OptionsView.EnableAppearanceOddRow = true;
            this.CityView.OptionsView.RowAutoHeight = true;
            this.CityView.OptionsView.ShowGroupPanel = false;
            this.CityView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.CityView_RowClick);
            this.CityView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.CityView_FocusedRowChanged);
            this.CityView.RowCountChanged += new System.EventHandler(this.CityView_RowCountChanged);
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
            // cmbCountry
            // 
            resources.ApplyResources(this.cmbCountry, "cmbCountry");
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Name = "cmbCountry";
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
            // txtCityName
            // 
            resources.ApplyResources(this.txtCityName, "txtCityName");
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Properties.AccessibleDescription = resources.GetString("txtCityName.Properties.AccessibleDescription");
            this.txtCityName.Properties.AccessibleName = resources.GetString("txtCityName.Properties.AccessibleName");
            this.txtCityName.Properties.AutoHeight = ((bool)(resources.GetObject("txtCityName.Properties.AutoHeight")));
            this.txtCityName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtCityName.Properties.Mask.AutoComplete")));
            this.txtCityName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtCityName.Properties.Mask.BeepOnError")));
            this.txtCityName.Properties.Mask.EditMask = resources.GetString("txtCityName.Properties.Mask.EditMask");
            this.txtCityName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtCityName.Properties.Mask.IgnoreMaskBlank")));
            this.txtCityName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtCityName.Properties.Mask.MaskType")));
            this.txtCityName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtCityName.Properties.Mask.PlaceHolder")));
            this.txtCityName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtCityName.Properties.Mask.SaveLiteral")));
            this.txtCityName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtCityName.Properties.Mask.ShowPlaceHolders")));
            this.txtCityName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtCityName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtCityName.Properties.NullValuePrompt = resources.GetString("txtCityName.Properties.NullValuePrompt");
            this.txtCityName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtCityName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtCityCode
            // 
            resources.ApplyResources(this.txtCityCode, "txtCityCode");
            this.txtCityCode.Name = "txtCityCode";
            this.txtCityCode.Properties.AccessibleDescription = resources.GetString("txtCityCode.Properties.AccessibleDescription");
            this.txtCityCode.Properties.AccessibleName = resources.GetString("txtCityCode.Properties.AccessibleName");
            this.txtCityCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtCityCode.Properties.AutoHeight")));
            this.txtCityCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtCityCode.Properties.Mask.AutoComplete")));
            this.txtCityCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtCityCode.Properties.Mask.BeepOnError")));
            this.txtCityCode.Properties.Mask.EditMask = resources.GetString("txtCityCode.Properties.Mask.EditMask");
            this.txtCityCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtCityCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtCityCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtCityCode.Properties.Mask.MaskType")));
            this.txtCityCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtCityCode.Properties.Mask.PlaceHolder")));
            this.txtCityCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtCityCode.Properties.Mask.SaveLiteral")));
            this.txtCityCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtCityCode.Properties.Mask.ShowPlaceHolders")));
            this.txtCityCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtCityCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtCityCode.Properties.NullValuePrompt = resources.GetString("txtCityCode.Properties.NullValuePrompt");
            this.txtCityCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtCityCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // FRM_City
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_City";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_City_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CityGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl CityGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView CityView;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.TextEdit txtCityName;
        private DevExpress.XtraEditors.TextEdit txtCityCode;
        private System.Windows.Forms.ComboBox cmbCountry;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}