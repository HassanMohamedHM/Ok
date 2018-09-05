namespace UILayer.Users
{
    partial class FRM_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_User));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.UserGrid = new DevExpress.XtraGrid.GridControl();
            this.UserView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtUserCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserCode.Properties)).BeginInit();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.UserGrid);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnModify);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnAddNew);
            this.splitContainerControl1.Panel2.Controls.Add(this.cmbEmployee);
            this.splitContainerControl1.Panel2.Controls.Add(this.cmbRole);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnPrev);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnFirst);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLast);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnNext);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtPassword);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtUserName);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtUserCode);
            this.splitContainerControl1.SplitterPosition = 602;
            // 
            // UserGrid
            // 
            resources.ApplyResources(this.UserGrid, "UserGrid");
            this.UserGrid.EmbeddedNavigator.AccessibleDescription = resources.GetString("UserGrid.EmbeddedNavigator.AccessibleDescription");
            this.UserGrid.EmbeddedNavigator.AccessibleName = resources.GetString("UserGrid.EmbeddedNavigator.AccessibleName");
            this.UserGrid.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("UserGrid.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.UserGrid.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("UserGrid.EmbeddedNavigator.Anchor")));
            this.UserGrid.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserGrid.EmbeddedNavigator.BackgroundImage")));
            this.UserGrid.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("UserGrid.EmbeddedNavigator.BackgroundImageLayout")));
            this.UserGrid.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("UserGrid.EmbeddedNavigator.ImeMode")));
            this.UserGrid.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("UserGrid.EmbeddedNavigator.MaximumSize")));
            this.UserGrid.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("UserGrid.EmbeddedNavigator.TextLocation")));
            this.UserGrid.EmbeddedNavigator.ToolTip = resources.GetString("UserGrid.EmbeddedNavigator.ToolTip");
            this.UserGrid.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("UserGrid.EmbeddedNavigator.ToolTipIconType")));
            this.UserGrid.EmbeddedNavigator.ToolTipTitle = resources.GetString("UserGrid.EmbeddedNavigator.ToolTipTitle");
            this.UserGrid.MainView = this.UserView;
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UserView});
            // 
            // UserView
            // 
            this.UserView.Appearance.ColumnFilterButton.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.ColumnFilterButton.FontSizeDelta")));
            this.UserView.Appearance.ColumnFilterButton.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.ColumnFilterButton.FontStyleDelta")));
            this.UserView.Appearance.ColumnFilterButton.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.ColumnFilterButton.GradientMode")));
            this.UserView.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.ColumnFilterButton.Image")));
            this.UserView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.UserView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.Appearance.FocusedCell.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.FocusedCell.FontSizeDelta")));
            this.UserView.Appearance.FocusedCell.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.FocusedCell.FontStyleDelta")));
            this.UserView.Appearance.FocusedCell.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.FocusedCell.GradientMode")));
            this.UserView.Appearance.FocusedCell.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.FocusedCell.Image")));
            this.UserView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.UserView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.Appearance.FocusedRow.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.FocusedRow.FontSizeDelta")));
            this.UserView.Appearance.FocusedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.FocusedRow.FontStyleDelta")));
            this.UserView.Appearance.FocusedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.FocusedRow.GradientMode")));
            this.UserView.Appearance.FocusedRow.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.FocusedRow.Image")));
            this.UserView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.UserView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.Appearance.HeaderPanel.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.HeaderPanel.FontSizeDelta")));
            this.UserView.Appearance.HeaderPanel.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.HeaderPanel.FontStyleDelta")));
            this.UserView.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.HeaderPanel.GradientMode")));
            this.UserView.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.HeaderPanel.Image")));
            this.UserView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.UserView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.Appearance.HorzLine.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.HorzLine.FontSizeDelta")));
            this.UserView.Appearance.HorzLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.HorzLine.FontStyleDelta")));
            this.UserView.Appearance.HorzLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.HorzLine.GradientMode")));
            this.UserView.Appearance.HorzLine.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.HorzLine.Image")));
            this.UserView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.UserView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.Appearance.OddRow.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.OddRow.FontSizeDelta")));
            this.UserView.Appearance.OddRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.OddRow.FontStyleDelta")));
            this.UserView.Appearance.OddRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.OddRow.GradientMode")));
            this.UserView.Appearance.OddRow.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.OddRow.Image")));
            this.UserView.Appearance.OddRow.Options.UseTextOptions = true;
            this.UserView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.Appearance.Preview.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.Preview.FontSizeDelta")));
            this.UserView.Appearance.Preview.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.Preview.FontStyleDelta")));
            this.UserView.Appearance.Preview.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.Preview.GradientMode")));
            this.UserView.Appearance.Preview.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.Preview.Image")));
            this.UserView.Appearance.Preview.Options.UseTextOptions = true;
            this.UserView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.Row.FontSizeDelta")));
            this.UserView.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.Row.FontStyleDelta")));
            this.UserView.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.Row.GradientMode")));
            this.UserView.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.Row.Image")));
            this.UserView.Appearance.Row.Options.UseTextOptions = true;
            this.UserView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.Appearance.SelectedRow.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.SelectedRow.FontSizeDelta")));
            this.UserView.Appearance.SelectedRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.SelectedRow.FontStyleDelta")));
            this.UserView.Appearance.SelectedRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.SelectedRow.GradientMode")));
            this.UserView.Appearance.SelectedRow.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.SelectedRow.Image")));
            this.UserView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.UserView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.Appearance.TopNewRow.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.TopNewRow.FontSizeDelta")));
            this.UserView.Appearance.TopNewRow.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.TopNewRow.FontStyleDelta")));
            this.UserView.Appearance.TopNewRow.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.TopNewRow.GradientMode")));
            this.UserView.Appearance.TopNewRow.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.TopNewRow.Image")));
            this.UserView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.UserView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.Appearance.VertLine.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.VertLine.FontSizeDelta")));
            this.UserView.Appearance.VertLine.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.VertLine.FontStyleDelta")));
            this.UserView.Appearance.VertLine.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.VertLine.GradientMode")));
            this.UserView.Appearance.VertLine.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.VertLine.Image")));
            this.UserView.Appearance.VertLine.Options.UseTextOptions = true;
            this.UserView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.Appearance.ViewCaption.FontSizeDelta = ((int)(resources.GetObject("UserView.Appearance.ViewCaption.FontSizeDelta")));
            this.UserView.Appearance.ViewCaption.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("UserView.Appearance.ViewCaption.FontStyleDelta")));
            this.UserView.Appearance.ViewCaption.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("UserView.Appearance.ViewCaption.GradientMode")));
            this.UserView.Appearance.ViewCaption.Image = ((System.Drawing.Image)(resources.GetObject("UserView.Appearance.ViewCaption.Image")));
            this.UserView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.UserView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UserView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            resources.ApplyResources(this.UserView, "UserView");
            this.UserView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.UserView.GridControl = this.UserGrid;
            this.UserView.Name = "UserView";
            this.UserView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.UserView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.UserView.OptionsBehavior.AllowIncrementalSearch = true;
            this.UserView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.UserView.OptionsBehavior.Editable = false;
            this.UserView.OptionsCustomization.AllowColumnMoving = false;
            this.UserView.OptionsCustomization.AllowColumnResizing = false;
            this.UserView.OptionsCustomization.AllowFilter = false;
            this.UserView.OptionsCustomization.AllowGroup = false;
            this.UserView.OptionsFind.AlwaysVisible = true;
            this.UserView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.UserView.OptionsPrint.EnableAppearanceOddRow = true;
            this.UserView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.UserView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.UserView.OptionsView.EnableAppearanceEvenRow = true;
            this.UserView.OptionsView.EnableAppearanceOddRow = true;
            this.UserView.OptionsView.RowAutoHeight = true;
            this.UserView.OptionsView.ShowGroupPanel = false;
            this.UserView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.UserView_RowClick);
            this.UserView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UserView_FocusedRowChanged);
            this.UserView.RowCountChanged += new System.EventHandler(this.UserView_RowCountChanged);
            // 
            // labelControl5
            // 
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
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
            // cmbEmployee
            // 
            resources.ApplyResources(this.cmbEmployee, "cmbEmployee");
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Name = "cmbEmployee";
            // 
            // cmbRole
            // 
            resources.ApplyResources(this.cmbRole, "cmbRole");
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Name = "cmbRole";
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
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.AccessibleDescription = resources.GetString("txtPassword.Properties.AccessibleDescription");
            this.txtPassword.Properties.AccessibleName = resources.GetString("txtPassword.Properties.AccessibleName");
            this.txtPassword.Properties.AutoHeight = ((bool)(resources.GetObject("txtPassword.Properties.AutoHeight")));
            this.txtPassword.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtPassword.Properties.Mask.AutoComplete")));
            this.txtPassword.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtPassword.Properties.Mask.BeepOnError")));
            this.txtPassword.Properties.Mask.EditMask = resources.GetString("txtPassword.Properties.Mask.EditMask");
            this.txtPassword.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtPassword.Properties.Mask.IgnoreMaskBlank")));
            this.txtPassword.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtPassword.Properties.Mask.MaskType")));
            this.txtPassword.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtPassword.Properties.Mask.PlaceHolder")));
            this.txtPassword.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtPassword.Properties.Mask.SaveLiteral")));
            this.txtPassword.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtPassword.Properties.Mask.ShowPlaceHolders")));
            this.txtPassword.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtPassword.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtPassword.Properties.NullValuePrompt = resources.GetString("txtPassword.Properties.NullValuePrompt");
            this.txtPassword.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtPassword.Properties.NullValuePromptShowForEmptyValue")));
            this.txtPassword.Properties.PasswordChar = '*';
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.AccessibleDescription = resources.GetString("txtUserName.Properties.AccessibleDescription");
            this.txtUserName.Properties.AccessibleName = resources.GetString("txtUserName.Properties.AccessibleName");
            this.txtUserName.Properties.AutoHeight = ((bool)(resources.GetObject("txtUserName.Properties.AutoHeight")));
            this.txtUserName.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtUserName.Properties.Mask.AutoComplete")));
            this.txtUserName.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtUserName.Properties.Mask.BeepOnError")));
            this.txtUserName.Properties.Mask.EditMask = resources.GetString("txtUserName.Properties.Mask.EditMask");
            this.txtUserName.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtUserName.Properties.Mask.IgnoreMaskBlank")));
            this.txtUserName.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtUserName.Properties.Mask.MaskType")));
            this.txtUserName.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtUserName.Properties.Mask.PlaceHolder")));
            this.txtUserName.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtUserName.Properties.Mask.SaveLiteral")));
            this.txtUserName.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtUserName.Properties.Mask.ShowPlaceHolders")));
            this.txtUserName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtUserName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtUserName.Properties.NullValuePrompt = resources.GetString("txtUserName.Properties.NullValuePrompt");
            this.txtUserName.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtUserName.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // txtUserCode
            // 
            resources.ApplyResources(this.txtUserCode, "txtUserCode");
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Properties.AccessibleDescription = resources.GetString("txtUserCode.Properties.AccessibleDescription");
            this.txtUserCode.Properties.AccessibleName = resources.GetString("txtUserCode.Properties.AccessibleName");
            this.txtUserCode.Properties.AutoHeight = ((bool)(resources.GetObject("txtUserCode.Properties.AutoHeight")));
            this.txtUserCode.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtUserCode.Properties.Mask.AutoComplete")));
            this.txtUserCode.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtUserCode.Properties.Mask.BeepOnError")));
            this.txtUserCode.Properties.Mask.EditMask = resources.GetString("txtUserCode.Properties.Mask.EditMask");
            this.txtUserCode.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtUserCode.Properties.Mask.IgnoreMaskBlank")));
            this.txtUserCode.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtUserCode.Properties.Mask.MaskType")));
            this.txtUserCode.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtUserCode.Properties.Mask.PlaceHolder")));
            this.txtUserCode.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtUserCode.Properties.Mask.SaveLiteral")));
            this.txtUserCode.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtUserCode.Properties.Mask.ShowPlaceHolders")));
            this.txtUserCode.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtUserCode.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtUserCode.Properties.NullValuePrompt = resources.GetString("txtUserCode.Properties.NullValuePrompt");
            this.txtUserCode.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtUserCode.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // FRM_User
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_User";
            this.Load += new System.EventHandler(this.FRM_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl UserGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView UserView;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtUserCode;
        private System.Windows.Forms.ComboBox cmbRole;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}