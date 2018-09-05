namespace UILayer.General
{
    partial class FRM_MaritalStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MaritalStatus));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.MaritalStatusGrid = new DevExpress.XtraGrid.GridControl();
            this.MaritalStatusView = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.txtMaritalStatusName = new DevExpress.XtraEditors.TextEdit();
            this.txtMaritalStatusCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaritalStatusGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaritalStatusView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaritalStatusName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaritalStatusCode.Properties)).BeginInit();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.MaritalStatusGrid);
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
            this.splitContainerControl1.Panel2.Controls.Add(this.txtMaritalStatusName);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtMaritalStatusCode);
            this.splitContainerControl1.SplitterPosition = 781;
            // 
            // MaritalStatusGrid
            // 
            resources.ApplyResources(this.MaritalStatusGrid, "MaritalStatusGrid");
            this.MaritalStatusGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("MaritalStatusGrid.EmbeddedNavigator.AccessibleDescription");
            this.MaritalStatusGrid.EmbeddedNavigator.AccessibleName = resources.GetString("MaritalStatusGrid.EmbeddedNavigator.AccessibleName");
            this.MaritalStatusGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("MaritalStatusGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.MaritalStatusGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("MaritalStatusGrid.EmbeddedNavigator.Anchor")));
            this.MaritalStatusGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaritalStatusGrid.EmbeddedNavigator.BackgroundImage")));
            this.MaritalStatusGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("MaritalStatusGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.MaritalStatusGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("MaritalStatusGrid.EmbeddedNavigator.ImeMode")));
            this.MaritalStatusGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("MaritalStatusGrid.EmbeddedNavigator.MaximumSize")));
            this.MaritalStatusGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("MaritalStatusGrid.EmbeddedNavigator.TextLocation")));
            this.MaritalStatusGrid.EmbeddedNavigator.ToolTip = resources.GetString("MaritalStatusGrid.EmbeddedNavigator.ToolTip");
            this.MaritalStatusGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("MaritalStatusGrid.EmbeddedNavigator.ToolTipIconType")));
            this.MaritalStatusGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("MaritalStatusGrid.EmbeddedNavigator.ToolTipTitle");
            this.MaritalStatusGrid.MainView = this.MaritalStatusView;
            this.MaritalStatusGrid.Name = "MaritalStatusGrid";
            this.MaritalStatusGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MaritalStatusView});
            // 
            // MaritalStatusView
            // 
            this.MaritalStatusView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.MaritalStatusView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.MaritalStatusView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.ColumnFilterButton.GradientMode")));
            this.MaritalStatusView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.ColumnFilterButton.Image")));
            this.MaritalStatusView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.FocusedCell.FontSizeDelta")));
            this.MaritalStatusView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.FocusedCell.FontStyleDelta")));
            this.MaritalStatusView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.FocusedCell.GradientMode")));
            this.MaritalStatusView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.FocusedCell.Image")));
            this.MaritalStatusView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.FocusedRow.FontSizeDelta")));
            this.MaritalStatusView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.FocusedRow.FontStyleDelta")));
            this.MaritalStatusView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.FocusedRow.GradientMode")));
            this.MaritalStatusView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.FocusedRow.Image")));
            this.MaritalStatusView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.HeaderPanel.FontSizeDelta")));
            this.MaritalStatusView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.HeaderPanel.FontStyleDelta")));
            this.MaritalStatusView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.HeaderPanel.GradientMode")));
            this.MaritalStatusView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.HeaderPanel.Image")));
            this.MaritalStatusView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.HorzLine.FontSizeDelta")));
            this.MaritalStatusView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.HorzLine.FontStyleDelta")));
            this.MaritalStatusView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.HorzLine.GradientMode")));
            this.MaritalStatusView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.HorzLine.Image")));
            this.MaritalStatusView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.OddRow.FontSizeDelta")));
            this.MaritalStatusView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.OddRow.FontStyleDelta")));
            this.MaritalStatusView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.OddRow.GradientMode")));
            this.MaritalStatusView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.OddRow.Image")));
            this.MaritalStatusView.Appearance.OddRow.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.Preview.FontSizeDelta")));
            this.MaritalStatusView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.Preview.FontStyleDelta")));
            this.MaritalStatusView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.Preview.GradientMode")));
            this.MaritalStatusView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.Preview.Image")));
            this.MaritalStatusView.Appearance.Preview.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.Row.FontSizeDelta")));
            this.MaritalStatusView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.Row.FontStyleDelta")));
            this.MaritalStatusView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.Row.GradientMode")));
            this.MaritalStatusView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.Row.Image")));
            this.MaritalStatusView.Appearance.Row.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.SelectedRow.FontSizeDelta")));
            this.MaritalStatusView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.SelectedRow.FontStyleDelta")));
            this.MaritalStatusView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.SelectedRow.GradientMode")));
            this.MaritalStatusView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.SelectedRow.Image")));
            this.MaritalStatusView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.TopNewRow.FontSizeDelta")));
            this.MaritalStatusView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.TopNewRow.FontStyleDelta")));
            this.MaritalStatusView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.TopNewRow.GradientMode")));
            this.MaritalStatusView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.TopNewRow.Image")));
            this.MaritalStatusView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.VertLine.FontSizeDelta")));
            this.MaritalStatusView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.VertLine.FontStyleDelta")));
            this.MaritalStatusView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.VertLine.GradientMode")));
            this.MaritalStatusView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.VertLine.Image")));
            this.MaritalStatusView.Appearance.VertLine.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("MaritalStatusView.Appearance.ViewCaption.FontSizeDelta")));
            this.MaritalStatusView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("MaritalStatusView.Appearance.ViewCaption.FontStyleDelta")));
            this.MaritalStatusView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("MaritalStatusView.Appearance.ViewCaption.GradientMode")));
            this.MaritalStatusView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("MaritalStatusView.Appearance.ViewCaption.Image")));
            this.MaritalStatusView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.MaritalStatusView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaritalStatusView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaritalStatusView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.MaritalStatusView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.MaritalStatusView, "MaritalStatusView");
            this.MaritalStatusView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.MaritalStatusView.GridControl = this.MaritalStatusGrid;
            this.MaritalStatusView.Name = "MaritalStatusView";
            this.MaritalStatusView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.MaritalStatusView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.MaritalStatusView.OptionsBehavior.AllowIncrementalSearch = true;
            this.MaritalStatusView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.MaritalStatusView.OptionsBehavior.Editable = false;
            this.MaritalStatusView.OptionsCustomization.AllowColumnMoving = false;
            this.MaritalStatusView.OptionsCustomization.AllowColumnResizing = false;
            this.MaritalStatusView.OptionsCustomization.AllowFilter = false;
            this.MaritalStatusView.OptionsCustomization.AllowGroup = false;
            this.MaritalStatusView.OptionsFind.AlwaysVisible = true;
            this.MaritalStatusView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.MaritalStatusView.OptionsPrint.EnableAppearanceOddRow = true;
            this.MaritalStatusView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.MaritalStatusView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.MaritalStatusView.OptionsView.EnableAppearanceEvenRow = true;
            this.MaritalStatusView.OptionsView.EnableAppearanceOddRow = true;
            this.MaritalStatusView.OptionsView.RowAutoHeight = true;
            this.MaritalStatusView.OptionsView.ShowGroupPanel = false;
            this.MaritalStatusView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.MaritalStatusView_RowClick);
            this.MaritalStatusView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.MaritalStatusView_FocusedRowChanged);
            this.MaritalStatusView.RowCountChanged += new System.EventHandler(this.MaritalStatusView_RowCountChanged);
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
            // txtMaritalStatusName
            // 
            resources.ApplyResources(this.txtMaritalStatusName, "txtMaritalStatusName");
            this.txtMaritalStatusName.Name = "txtMaritalStatusName";
            this.txtMaritalStatusName.Properties.AccessibleDescription = resources.GetString("txtMaritalStatusName.Properties.AccessibleDescription");
            this.txtMaritalStatusName.Properties.AccessibleName = resources.GetString("txtMaritalStatusName.Properties.AccessibleName");
            this.txtMaritalStatusName.Properties.AutoHeight = ((bool)(resources.GetObject("txtMaritalStatusName.Properties.AutoHeight")));
            this.txtMaritalStatusName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtMaritalStatusName.Properties.Mask.AutoComplete")));
            this.txtMaritalStatusName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtMaritalStatusName.Properties.Mask.BeepOnError")));
            this.txtMaritalStatusName.Properties.Mask.EditMask = resources.GetString("txtMaritalStatusName.Properties.Mask.EditMask");
            this.txtMaritalStatusName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtMaritalStatusName.Properties.Mask.IgnoreMaskBlank")));
            this.txtMaritalStatusName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtMaritalStatusName.Properties.Mask.MaskType")));
            this.txtMaritalStatusName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtMaritalStatusName.Properties.Mask.PlaceHolder")));
            this.txtMaritalStatusName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtMaritalStatusName.Properties.Mask.SaveLiteral")));
            this.txtMaritalStatusName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtMaritalStatusName.Properties.Mask.ShowPlaceHolders")));
            this.txtMaritalStatusName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtMaritalStatusName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtMaritalStatusName.Properties.NullValuePrompt = resources.GetString("txtMaritalStatusName.Properties.NullValuePrompt");
            this.txtMaritalStatusName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtMaritalStatusName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtMaritalStatusCode
            // 
            resources.ApplyResources(this.txtMaritalStatusCode, "txtMaritalStatusCode");
            this.txtMaritalStatusCode.Name = "txtMaritalStatusCode";
            this.txtMaritalStatusCode.Properties.AccessibleDescription = resources.GetString("txtMaritalStatusCode.Properties.AccessibleDescription");
            this.txtMaritalStatusCode.Properties.AccessibleName = resources.GetString("txtMaritalStatusCode.Properties.AccessibleName");
            this.txtMaritalStatusCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtMaritalStatusCode.Properties.AutoHeight")));
            this.txtMaritalStatusCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtMaritalStatusCode.Properties.Mask.AutoComplete")));
            this.txtMaritalStatusCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtMaritalStatusCode.Properties.Mask.BeepOnError")));
            this.txtMaritalStatusCode.Properties.Mask.EditMask = resources.GetString("txtMaritalStatusCode.Properties.Mask.EditMask");
            this.txtMaritalStatusCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtMaritalStatusCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtMaritalStatusCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtMaritalStatusCode.Properties.Mask.MaskType")));
            this.txtMaritalStatusCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtMaritalStatusCode.Properties.Mask.PlaceHolder")));
            this.txtMaritalStatusCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtMaritalStatusCode.Properties.Mask.SaveLiteral")));
            this.txtMaritalStatusCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtMaritalStatusCode.Properties.Mask.ShowPlaceHolders")));
            this.txtMaritalStatusCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtMaritalStatusCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtMaritalStatusCode.Properties.NullValuePrompt = resources.GetString("txtMaritalStatusCode.Properties.NullValuePrompt");
            this.txtMaritalStatusCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtMaritalStatusCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // FRM_MaritalStatus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_MaritalStatus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_MaritalStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaritalStatusGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaritalStatusView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaritalStatusName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaritalStatusCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl MaritalStatusGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView MaritalStatusView;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.TextEdit txtMaritalStatusName;
        private DevExpress.XtraEditors.TextEdit txtMaritalStatusCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}