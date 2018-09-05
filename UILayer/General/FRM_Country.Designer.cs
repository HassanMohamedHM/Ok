namespace UILayer.General
{
    partial class FRM_Country
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Country));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.CountryGrid = new DevExpress.XtraGrid.GridControl();
            this.CountryView = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.txtCountryName = new DevExpress.XtraEditors.TextEdit();
            this.txtCountryCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryCode.Properties)).BeginInit();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.CountryGrid);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnPrev);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnFirst);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLast);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnNext);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnModify);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnAddNew);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtCountryName);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtCountryCode);
            this.splitContainerControl1.SplitterPosition = 781;
            // 
            // CountryGrid
            // 
            resources.ApplyResources(this.CountryGrid, "CountryGrid");
            this.CountryGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("CountryGrid.EmbeddedNavigator.AccessibleDescription");
            this.CountryGrid.EmbeddedNavigator.AccessibleName = resources.GetString("CountryGrid.EmbeddedNavigator.AccessibleName");
            this.CountryGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("CountryGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.CountryGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("CountryGrid.EmbeddedNavigator.Anchor")));
            this.CountryGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CountryGrid.EmbeddedNavigator.BackgroundImage")));
            this.CountryGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("CountryGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.CountryGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("CountryGrid.EmbeddedNavigator.ImeMode")));
            this.CountryGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("CountryGrid.EmbeddedNavigator.MaximumSize")));
            this.CountryGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("CountryGrid.EmbeddedNavigator.TextLocation")));
            this.CountryGrid.EmbeddedNavigator.ToolTip = resources.GetString("CountryGrid.EmbeddedNavigator.ToolTip");
            this.CountryGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("CountryGrid.EmbeddedNavigator.ToolTipIconType")));
            this.CountryGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("CountryGrid.EmbeddedNavigator.ToolTipTitle");
            this.CountryGrid.MainView = this.CountryView;
            this.CountryGrid.Name = "CountryGrid";
            this.CountryGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CountryView});
            // 
            // CountryView
            // 
            this.CountryView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.CountryView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.CountryView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.ColumnFilterButton.GradientMode")));
            this.CountryView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.ColumnFilterButton.Image")));
            this.CountryView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.CountryView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.FocusedCell.FontSizeDelta")));
            this.CountryView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.FocusedCell.FontStyleDelta")));
            this.CountryView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.FocusedCell.GradientMode")));
            this.CountryView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.FocusedCell.Image")));
            this.CountryView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.CountryView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.FocusedRow.FontSizeDelta")));
            this.CountryView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.FocusedRow.FontStyleDelta")));
            this.CountryView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.FocusedRow.GradientMode")));
            this.CountryView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.FocusedRow.Image")));
            this.CountryView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.CountryView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.HeaderPanel.FontSizeDelta")));
            this.CountryView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.HeaderPanel.FontStyleDelta")));
            this.CountryView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.HeaderPanel.GradientMode")));
            this.CountryView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.HeaderPanel.Image")));
            this.CountryView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.CountryView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.HorzLine.FontSizeDelta")));
            this.CountryView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.HorzLine.FontStyleDelta")));
            this.CountryView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.HorzLine.GradientMode")));
            this.CountryView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.HorzLine.Image")));
            this.CountryView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.CountryView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.OddRow.FontSizeDelta")));
            this.CountryView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.OddRow.FontStyleDelta")));
            this.CountryView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.OddRow.GradientMode")));
            this.CountryView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.OddRow.Image")));
            this.CountryView.Appearance.OddRow.Options.UseTextOptions = true;
            this.CountryView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.Preview.FontSizeDelta")));
            this.CountryView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.Preview.FontStyleDelta")));
            this.CountryView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.Preview.GradientMode")));
            this.CountryView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.Preview.Image")));
            this.CountryView.Appearance.Preview.Options.UseTextOptions = true;
            this.CountryView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.Row.FontSizeDelta")));
            this.CountryView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.Row.FontStyleDelta")));
            this.CountryView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.Row.GradientMode")));
            this.CountryView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.Row.Image")));
            this.CountryView.Appearance.Row.Options.UseTextOptions = true;
            this.CountryView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.SelectedRow.FontSizeDelta")));
            this.CountryView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.SelectedRow.FontStyleDelta")));
            this.CountryView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.SelectedRow.GradientMode")));
            this.CountryView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.SelectedRow.Image")));
            this.CountryView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.CountryView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.TopNewRow.FontSizeDelta")));
            this.CountryView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.TopNewRow.FontStyleDelta")));
            this.CountryView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.TopNewRow.GradientMode")));
            this.CountryView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.TopNewRow.Image")));
            this.CountryView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.CountryView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.VertLine.FontSizeDelta")));
            this.CountryView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.VertLine.FontStyleDelta")));
            this.CountryView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.VertLine.GradientMode")));
            this.CountryView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.VertLine.Image")));
            this.CountryView.Appearance.VertLine.Options.UseTextOptions = true;
            this.CountryView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("CountryView.Appearance.ViewCaption.FontSizeDelta")));
            this.CountryView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("CountryView.Appearance.ViewCaption.FontStyleDelta")));
            this.CountryView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("CountryView.Appearance.ViewCaption.GradientMode")));
            this.CountryView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("CountryView.Appearance.ViewCaption.Image")));
            this.CountryView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.CountryView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CountryView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CountryView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CountryView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.CountryView, "CountryView");
            this.CountryView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.CountryView.GridControl = this.CountryGrid;
            this.CountryView.Name = "CountryView";
            this.CountryView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.CountryView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.CountryView.OptionsBehavior.AllowIncrementalSearch = true;
            this.CountryView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.CountryView.OptionsBehavior.Editable = false;
            this.CountryView.OptionsCustomization.AllowColumnMoving = false;
            this.CountryView.OptionsCustomization.AllowColumnResizing = false;
            this.CountryView.OptionsCustomization.AllowFilter = false;
            this.CountryView.OptionsCustomization.AllowGroup = false;
            this.CountryView.OptionsFind.AlwaysVisible = true;
            this.CountryView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.CountryView.OptionsPrint.EnableAppearanceOddRow = true;
            this.CountryView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.CountryView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.CountryView.OptionsView.EnableAppearanceEvenRow = true;
            this.CountryView.OptionsView.EnableAppearanceOddRow = true;
            this.CountryView.OptionsView.RowAutoHeight = true;
            this.CountryView.OptionsView.ShowGroupPanel = false;
            this.CountryView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.CountryView_RowClick);
            this.CountryView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.CountryView_FocusedRowChanged);
            this.CountryView.RowCountChanged += new System.EventHandler(this.CountryView_RowCountChanged);
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
            // txtCountryName
            // 
            resources.ApplyResources(this.txtCountryName, "txtCountryName");
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Properties.AccessibleDescription = resources.GetString("txtCountryName.Properties.AccessibleDescription");
            this.txtCountryName.Properties.AccessibleName = resources.GetString("txtCountryName.Properties.AccessibleName");
            this.txtCountryName.Properties.AutoHeight = ((bool)(resources.GetObject("txtCountryName.Properties.AutoHeight")));
            this.txtCountryName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtCountryName.Properties.Mask.AutoComplete")));
            this.txtCountryName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtCountryName.Properties.Mask.BeepOnError")));
            this.txtCountryName.Properties.Mask.EditMask = resources.GetString("txtCountryName.Properties.Mask.EditMask");
            this.txtCountryName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtCountryName.Properties.Mask.IgnoreMaskBlank")));
            this.txtCountryName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtCountryName.Properties.Mask.MaskType")));
            this.txtCountryName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtCountryName.Properties.Mask.PlaceHolder")));
            this.txtCountryName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtCountryName.Properties.Mask.SaveLiteral")));
            this.txtCountryName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtCountryName.Properties.Mask.ShowPlaceHolders")));
            this.txtCountryName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtCountryName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtCountryName.Properties.NullValuePrompt = resources.GetString("txtCountryName.Properties.NullValuePrompt");
            this.txtCountryName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtCountryName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtCountryCode
            // 
            resources.ApplyResources(this.txtCountryCode, "txtCountryCode");
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Properties.AccessibleDescription = resources.GetString("txtCountryCode.Properties.AccessibleDescription");
            this.txtCountryCode.Properties.AccessibleName = resources.GetString("txtCountryCode.Properties.AccessibleName");
            this.txtCountryCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtCountryCode.Properties.AutoHeight")));
            this.txtCountryCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtCountryCode.Properties.Mask.AutoComplete")));
            this.txtCountryCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtCountryCode.Properties.Mask.BeepOnError")));
            this.txtCountryCode.Properties.Mask.EditMask = resources.GetString("txtCountryCode.Properties.Mask.EditMask");
            this.txtCountryCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtCountryCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtCountryCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtCountryCode.Properties.Mask.MaskType")));
            this.txtCountryCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtCountryCode.Properties.Mask.PlaceHolder")));
            this.txtCountryCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtCountryCode.Properties.Mask.SaveLiteral")));
            this.txtCountryCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtCountryCode.Properties.Mask.ShowPlaceHolders")));
            this.txtCountryCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtCountryCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtCountryCode.Properties.NullValuePrompt = resources.GetString("txtCountryCode.Properties.NullValuePrompt");
            this.txtCountryCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtCountryCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // FRM_Country
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_Country";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Country_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CountryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl CountryGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView CountryView;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.TextEdit txtCountryName;
        private DevExpress.XtraEditors.TextEdit txtCountryCode;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}