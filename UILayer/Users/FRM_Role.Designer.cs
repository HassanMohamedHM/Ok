namespace UILayer.Users
{
    partial class FRM_Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Role));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.RoleGrid = new DevExpress.XtraGrid.GridControl();
            this.RoleView = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.txtRoleName = new DevExpress.XtraEditors.TextEdit();
            this.txtRoleCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            resources.ApplyResources(this.splitContainerControl1, "splitContainerControl1");
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Name = "splitContainerControl1";
            resources.ApplyResources(this.splitContainerControl1.Panel1, "splitContainerControl1.Panel1");
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel1.Controls.Add(this.RoleGrid);
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
            this.splitContainerControl1.Panel2.Controls.Add(this.txtRoleName);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtRoleCode);
            this.splitContainerControl1.SplitterPosition = 425;
            // 
            // RoleGrid
            // 
            resources.ApplyResources(this.RoleGrid, "RoleGrid");
            this.RoleGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("RoleGrid.EmbeddedNavigator.AccessibleDescription");
            this.RoleGrid.EmbeddedNavigator.AccessibleName = resources.GetString("RoleGrid.EmbeddedNavigator.AccessibleName");
            this.RoleGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("RoleGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.RoleGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("RoleGrid.EmbeddedNavigator.Anchor")));
            this.RoleGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RoleGrid.EmbeddedNavigator.BackgroundImage")));
            this.RoleGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("RoleGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.RoleGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("RoleGrid.EmbeddedNavigator.ImeMode")));
            this.RoleGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("RoleGrid.EmbeddedNavigator.MaximumSize")));
            this.RoleGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("RoleGrid.EmbeddedNavigator.TextLocation")));
            this.RoleGrid.EmbeddedNavigator.ToolTip = resources.GetString("RoleGrid.EmbeddedNavigator.ToolTip");
            this.RoleGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("RoleGrid.EmbeddedNavigator.ToolTipIconType")));
            this.RoleGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("RoleGrid.EmbeddedNavigator.ToolTipTitle");
            this.RoleGrid.MainView = this.RoleView;
            this.RoleGrid.Name = "RoleGrid";
            this.RoleGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.RoleView});
            // 
            // RoleView
            // 
            this.RoleView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.RoleView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.RoleView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.ColumnFilterButton.GradientMode")));
            this.RoleView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.ColumnFilterButton.Image")));
            this.RoleView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.RoleView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.FocusedCell.FontSizeDelta")));
            this.RoleView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.FocusedCell.FontStyleDelta")));
            this.RoleView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.FocusedCell.GradientMode")));
            this.RoleView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.FocusedCell.Image")));
            this.RoleView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.RoleView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.FocusedRow.FontSizeDelta")));
            this.RoleView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.FocusedRow.FontStyleDelta")));
            this.RoleView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.FocusedRow.GradientMode")));
            this.RoleView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.FocusedRow.Image")));
            this.RoleView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.RoleView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.HeaderPanel.FontSizeDelta")));
            this.RoleView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.HeaderPanel.FontStyleDelta")));
            this.RoleView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.HeaderPanel.GradientMode")));
            this.RoleView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.HeaderPanel.Image")));
            this.RoleView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.RoleView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.HorzLine.FontSizeDelta")));
            this.RoleView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.HorzLine.FontStyleDelta")));
            this.RoleView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.HorzLine.GradientMode")));
            this.RoleView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.HorzLine.Image")));
            this.RoleView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.RoleView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.OddRow.FontSizeDelta")));
            this.RoleView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.OddRow.FontStyleDelta")));
            this.RoleView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.OddRow.GradientMode")));
            this.RoleView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.OddRow.Image")));
            this.RoleView.Appearance.OddRow.Options.UseTextOptions = true;
            this.RoleView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.Preview.FontSizeDelta")));
            this.RoleView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.Preview.FontStyleDelta")));
            this.RoleView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.Preview.GradientMode")));
            this.RoleView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.Preview.Image")));
            this.RoleView.Appearance.Preview.Options.UseTextOptions = true;
            this.RoleView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.Row.FontSizeDelta")));
            this.RoleView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.Row.FontStyleDelta")));
            this.RoleView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.Row.GradientMode")));
            this.RoleView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.Row.Image")));
            this.RoleView.Appearance.Row.Options.UseTextOptions = true;
            this.RoleView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.SelectedRow.FontSizeDelta")));
            this.RoleView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.SelectedRow.FontStyleDelta")));
            this.RoleView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.SelectedRow.GradientMode")));
            this.RoleView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.SelectedRow.Image")));
            this.RoleView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.RoleView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.TopNewRow.FontSizeDelta")));
            this.RoleView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.TopNewRow.FontStyleDelta")));
            this.RoleView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.TopNewRow.GradientMode")));
            this.RoleView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.TopNewRow.Image")));
            this.RoleView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.RoleView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.VertLine.FontSizeDelta")));
            this.RoleView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.VertLine.FontStyleDelta")));
            this.RoleView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.VertLine.GradientMode")));
            this.RoleView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.VertLine.Image")));
            this.RoleView.Appearance.VertLine.Options.UseTextOptions = true;
            this.RoleView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("RoleView.Appearance.ViewCaption.FontSizeDelta")));
            this.RoleView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("RoleView.Appearance.ViewCaption.FontStyleDelta")));
            this.RoleView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("RoleView.Appearance.ViewCaption.GradientMode")));
            this.RoleView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("RoleView.Appearance.ViewCaption.Image")));
            this.RoleView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.RoleView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RoleView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.RoleView, "RoleView");
            this.RoleView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.RoleView.GridControl = this.RoleGrid;
            this.RoleView.Name = "RoleView";
            this.RoleView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.RoleView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.RoleView.OptionsBehavior.AllowIncrementalSearch = true;
            this.RoleView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.RoleView.OptionsBehavior.Editable = false;
            this.RoleView.OptionsCustomization.AllowColumnMoving = false;
            this.RoleView.OptionsCustomization.AllowColumnResizing = false;
            this.RoleView.OptionsCustomization.AllowFilter = false;
            this.RoleView.OptionsCustomization.AllowGroup = false;
            this.RoleView.OptionsFind.AlwaysVisible = true;
            this.RoleView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.RoleView.OptionsPrint.EnableAppearanceOddRow = true;
            this.RoleView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.RoleView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.RoleView.OptionsView.EnableAppearanceEvenRow = true;
            this.RoleView.OptionsView.EnableAppearanceOddRow = true;
            this.RoleView.OptionsView.RowAutoHeight = true;
            this.RoleView.OptionsView.ShowGroupPanel = false;
            this.RoleView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.RoleView_RowClick);
            this.RoleView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.RoleView_FocusedRowChanged);
            this.RoleView.RowCountChanged += new System.EventHandler(this.RoleView_RowCountChanged);
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
            // txtRoleName
            // 
            resources.ApplyResources(this.txtRoleName, "txtRoleName");
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Properties.AccessibleDescription = resources.GetString("txtRoleName.Properties.AccessibleDescription");
            this.txtRoleName.Properties.AccessibleName = resources.GetString("txtRoleName.Properties.AccessibleName");
            this.txtRoleName.Properties.AutoHeight = ((bool)(resources.GetObject("txtRoleName.Properties.AutoHeight")));
            this.txtRoleName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtRoleName.Properties.Mask.AutoComplete")));
            this.txtRoleName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtRoleName.Properties.Mask.BeepOnError")));
            this.txtRoleName.Properties.Mask.EditMask = resources.GetString("txtRoleName.Properties.Mask.EditMask");
            this.txtRoleName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtRoleName.Properties.Mask.IgnoreMaskBlank")));
            this.txtRoleName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtRoleName.Properties.Mask.MaskType")));
            this.txtRoleName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtRoleName.Properties.Mask.PlaceHolder")));
            this.txtRoleName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtRoleName.Properties.Mask.SaveLiteral")));
            this.txtRoleName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtRoleName.Properties.Mask.ShowPlaceHolders")));
            this.txtRoleName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtRoleName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtRoleName.Properties.NullValuePrompt = resources.GetString("txtRoleName.Properties.NullValuePrompt");
            this.txtRoleName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtRoleName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtRoleCode
            // 
            resources.ApplyResources(this.txtRoleCode, "txtRoleCode");
            this.txtRoleCode.Name = "txtRoleCode";
            this.txtRoleCode.Properties.AccessibleDescription = resources.GetString("txtRoleCode.Properties.AccessibleDescription");
            this.txtRoleCode.Properties.AccessibleName = resources.GetString("txtRoleCode.Properties.AccessibleName");
            this.txtRoleCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtRoleCode.Properties.AutoHeight")));
            this.txtRoleCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtRoleCode.Properties.Mask.AutoComplete")));
            this.txtRoleCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtRoleCode.Properties.Mask.BeepOnError")));
            this.txtRoleCode.Properties.Mask.EditMask = resources.GetString("txtRoleCode.Properties.Mask.EditMask");
            this.txtRoleCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtRoleCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtRoleCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtRoleCode.Properties.Mask.MaskType")));
            this.txtRoleCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtRoleCode.Properties.Mask.PlaceHolder")));
            this.txtRoleCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtRoleCode.Properties.Mask.SaveLiteral")));
            this.txtRoleCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtRoleCode.Properties.Mask.ShowPlaceHolders")));
            this.txtRoleCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtRoleCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtRoleCode.Properties.NullValuePrompt = resources.GetString("txtRoleCode.Properties.NullValuePrompt");
            this.txtRoleCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtRoleCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // FRM_Role
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_Role";
            this.Load += new System.EventHandler(this.FRM_Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl RoleGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView RoleView;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.TextEdit txtRoleName;
        private DevExpress.XtraEditors.TextEdit txtRoleCode;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}