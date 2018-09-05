namespace UILayer.General
{
    partial class FRM_Job
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Job));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.JobGrid = new DevExpress.XtraGrid.GridControl();
            this.JobView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNote = new DevExpress.XtraEditors.TextEdit();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtJobName = new DevExpress.XtraEditors.TextEdit();
            this.txtJobCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobCode.Properties)).BeginInit();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.JobGrid);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtNote);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnPrev);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnFirst);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLast);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnNext);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnModify);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnAddNew);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtJobName);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtJobCode);
            this.splitContainerControl1.SplitterPosition = 781;
            // 
            // JobGrid
            // 
            resources.ApplyResources(this.JobGrid, "JobGrid");
            this.JobGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("JobGrid.EmbeddedNavigator.AccessibleDescription");
            this.JobGrid.EmbeddedNavigator.AccessibleName = resources.GetString("JobGrid.EmbeddedNavigator.AccessibleName");
            this.JobGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("JobGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.JobGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("JobGrid.EmbeddedNavigator.Anchor")));
            this.JobGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JobGrid.EmbeddedNavigator.BackgroundImage")));
            this.JobGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("JobGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.JobGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("JobGrid.EmbeddedNavigator.ImeMode")));
            this.JobGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("JobGrid.EmbeddedNavigator.MaximumSize")));
            this.JobGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("JobGrid.EmbeddedNavigator.TextLocation")));
            this.JobGrid.EmbeddedNavigator.ToolTip = resources.GetString("JobGrid.EmbeddedNavigator.ToolTip");
            this.JobGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("JobGrid.EmbeddedNavigator.ToolTipIconType")));
            this.JobGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("JobGrid.EmbeddedNavigator.ToolTipTitle");
            this.JobGrid.MainView = this.JobView;
            this.JobGrid.Name = "JobGrid";
            this.JobGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.JobView});
            // 
            // JobView
            // 
            this.JobView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.JobView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.JobView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.ColumnFilterButton.GradientMode")));
            this.JobView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.ColumnFilterButton.Image")));
            this.JobView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.JobView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.FocusedCell.FontSizeDelta")));
            this.JobView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.FocusedCell.FontStyleDelta")));
            this.JobView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.FocusedCell.GradientMode")));
            this.JobView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.FocusedCell.Image")));
            this.JobView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.JobView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.FocusedRow.FontSizeDelta")));
            this.JobView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.FocusedRow.FontStyleDelta")));
            this.JobView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.FocusedRow.GradientMode")));
            this.JobView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.FocusedRow.Image")));
            this.JobView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.JobView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.HeaderPanel.FontSizeDelta")));
            this.JobView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.HeaderPanel.FontStyleDelta")));
            this.JobView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.HeaderPanel.GradientMode")));
            this.JobView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.HeaderPanel.Image")));
            this.JobView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.JobView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.HorzLine.FontSizeDelta")));
            this.JobView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.HorzLine.FontStyleDelta")));
            this.JobView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.HorzLine.GradientMode")));
            this.JobView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.HorzLine.Image")));
            this.JobView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.JobView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.OddRow.FontSizeDelta")));
            this.JobView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.OddRow.FontStyleDelta")));
            this.JobView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.OddRow.GradientMode")));
            this.JobView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.OddRow.Image")));
            this.JobView.Appearance.OddRow.Options.UseTextOptions = true;
            this.JobView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.Preview.FontSizeDelta")));
            this.JobView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.Preview.FontStyleDelta")));
            this.JobView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.Preview.GradientMode")));
            this.JobView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.Preview.Image")));
            this.JobView.Appearance.Preview.Options.UseTextOptions = true;
            this.JobView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.Row.FontSizeDelta")));
            this.JobView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.Row.FontStyleDelta")));
            this.JobView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.Row.GradientMode")));
            this.JobView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.Row.Image")));
            this.JobView.Appearance.Row.Options.UseTextOptions = true;
            this.JobView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.SelectedRow.FontSizeDelta")));
            this.JobView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.SelectedRow.FontStyleDelta")));
            this.JobView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.SelectedRow.GradientMode")));
            this.JobView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.SelectedRow.Image")));
            this.JobView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.JobView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.TopNewRow.FontSizeDelta")));
            this.JobView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.TopNewRow.FontStyleDelta")));
            this.JobView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.TopNewRow.GradientMode")));
            this.JobView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.TopNewRow.Image")));
            this.JobView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.JobView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.VertLine.FontSizeDelta")));
            this.JobView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.VertLine.FontStyleDelta")));
            this.JobView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.VertLine.GradientMode")));
            this.JobView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.VertLine.Image")));
            this.JobView.Appearance.VertLine.Options.UseTextOptions = true;
            this.JobView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("JobView.Appearance.ViewCaption.FontSizeDelta")));
            this.JobView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("JobView.Appearance.ViewCaption.FontStyleDelta")));
            this.JobView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("JobView.Appearance.ViewCaption.GradientMode")));
            this.JobView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("JobView.Appearance.ViewCaption.Image")));
            this.JobView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.JobView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JobView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JobView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.JobView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.JobView, "JobView");
            this.JobView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.JobView.GridControl = this.JobGrid;
            this.JobView.Name = "JobView";
            this.JobView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.JobView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.JobView.OptionsBehavior.AllowIncrementalSearch = true;
            this.JobView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.JobView.OptionsBehavior.Editable = false;
            this.JobView.OptionsCustomization.AllowColumnMoving = false;
            this.JobView.OptionsCustomization.AllowColumnResizing = false;
            this.JobView.OptionsCustomization.AllowFilter = false;
            this.JobView.OptionsCustomization.AllowGroup = false;
            this.JobView.OptionsFind.AlwaysVisible = true;
            this.JobView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.JobView.OptionsPrint.EnableAppearanceOddRow = true;
            this.JobView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.JobView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.JobView.OptionsView.EnableAppearanceEvenRow = true;
            this.JobView.OptionsView.EnableAppearanceOddRow = true;
            this.JobView.OptionsView.RowAutoHeight = true;
            this.JobView.OptionsView.ShowGroupPanel = false;
            this.JobView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.JobView_RowClick);
            this.JobView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.JobView_FocusedRowChanged);
            this.JobView.RowCountChanged += new System.EventHandler(this.JobView_RowCountChanged);
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
            // txtNote
            // 
            resources.ApplyResources(this.txtNote, "txtNote");
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.AccessibleDescription = resources.GetString("txtNote.Properties.AccessibleDescription");
            this.txtNote.Properties.AccessibleName = resources.GetString("txtNote.Properties.AccessibleName");
            this.txtNote.Properties.AutoHeight = ((bool)(resources.GetObject("txtNote.Properties.AutoHeight")));
            this.txtNote.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtNote.Properties.Mask.AutoComplete")));
            this.txtNote.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtNote.Properties.Mask.BeepOnError")));
            this.txtNote.Properties.Mask.EditMask = resources.GetString("txtNote.Properties.Mask.EditMask");
            this.txtNote.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtNote.Properties.Mask.IgnoreMaskBlank")));
            this.txtNote.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtNote.Properties.Mask.MaskType")));
            this.txtNote.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtNote.Properties.Mask.PlaceHolder")));
            this.txtNote.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtNote.Properties.Mask.SaveLiteral")));
            this.txtNote.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtNote.Properties.Mask.ShowPlaceHolders")));
            this.txtNote.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtNote.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtNote.Properties.NullValuePrompt = resources.GetString("txtNote.Properties.NullValuePrompt");
            this.txtNote.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtNote.Properties.NullValuePromptShowForEmptyValue")));
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
            // txtJobName
            // 
            resources.ApplyResources(this.txtJobName, "txtJobName");
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Properties.AccessibleDescription = resources.GetString("txtJobName.Properties.AccessibleDescription");
            this.txtJobName.Properties.AccessibleName = resources.GetString("txtJobName.Properties.AccessibleName");
            this.txtJobName.Properties.AutoHeight = ((bool)(resources.GetObject("txtJobName.Properties.AutoHeight")));
            this.txtJobName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtJobName.Properties.Mask.AutoComplete")));
            this.txtJobName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtJobName.Properties.Mask.BeepOnError")));
            this.txtJobName.Properties.Mask.EditMask = resources.GetString("txtJobName.Properties.Mask.EditMask");
            this.txtJobName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtJobName.Properties.Mask.IgnoreMaskBlank")));
            this.txtJobName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtJobName.Properties.Mask.MaskType")));
            this.txtJobName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtJobName.Properties.Mask.PlaceHolder")));
            this.txtJobName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtJobName.Properties.Mask.SaveLiteral")));
            this.txtJobName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtJobName.Properties.Mask.ShowPlaceHolders")));
            this.txtJobName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtJobName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtJobName.Properties.NullValuePrompt = resources.GetString("txtJobName.Properties.NullValuePrompt");
            this.txtJobName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtJobName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtJobCode
            // 
            resources.ApplyResources(this.txtJobCode, "txtJobCode");
            this.txtJobCode.Name = "txtJobCode";
            this.txtJobCode.Properties.AccessibleDescription = resources.GetString("txtJobCode.Properties.AccessibleDescription");
            this.txtJobCode.Properties.AccessibleName = resources.GetString("txtJobCode.Properties.AccessibleName");
            this.txtJobCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtJobCode.Properties.AutoHeight")));
            this.txtJobCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtJobCode.Properties.Mask.AutoComplete")));
            this.txtJobCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtJobCode.Properties.Mask.BeepOnError")));
            this.txtJobCode.Properties.Mask.EditMask = resources.GetString("txtJobCode.Properties.Mask.EditMask");
            this.txtJobCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtJobCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtJobCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtJobCode.Properties.Mask.MaskType")));
            this.txtJobCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtJobCode.Properties.Mask.PlaceHolder")));
            this.txtJobCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtJobCode.Properties.Mask.SaveLiteral")));
            this.txtJobCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtJobCode.Properties.Mask.ShowPlaceHolders")));
            this.txtJobCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtJobCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtJobCode.Properties.NullValuePrompt = resources.GetString("txtJobCode.Properties.NullValuePrompt");
            this.txtJobCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtJobCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // FRM_Job
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_Job";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Job_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JobGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl JobGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView JobView;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.TextEdit txtJobName;
        private DevExpress.XtraEditors.TextEdit txtJobCode;
        private DevExpress.XtraEditors.TextEdit txtNote;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}