namespace UILayer.Users
{
    partial class FRM_Screen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Screen));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ScreenGrid = new DevExpress.XtraGrid.GridControl();
            this.ScreenView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvPermissions = new System.Windows.Forms.DataGridView();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtScreenName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtScreenCode = new DevExpress.XtraEditors.TextEdit();
            this.PerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScreenName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScreenCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel1.Controls.Add(this.ScreenGrid);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnPrev);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnFirst);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLast);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnNext);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnModify);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnAddNew);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtScreenName);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtScreenCode);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(879, 483);
            this.splitContainerControl1.SplitterPosition = 525;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ScreenGrid
            // 
            this.ScreenGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenGrid.Location = new System.Drawing.Point(0, 0);
            this.ScreenGrid.MainView = this.ScreenView;
            this.ScreenGrid.Name = "ScreenGrid";
            this.ScreenGrid.Size = new System.Drawing.Size(521, 475);
            this.ScreenGrid.TabIndex = 0;
            this.ScreenGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ScreenView});
            // 
            // ScreenView
            // 
            this.ScreenView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.ScreenView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.ScreenView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.ScreenView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.ScreenView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.ScreenView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.Appearance.OddRow.Options.UseTextOptions = true;
            this.ScreenView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.Appearance.Preview.Options.UseTextOptions = true;
            this.ScreenView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.Appearance.Row.Options.UseTextOptions = true;
            this.ScreenView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.ScreenView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.ScreenView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.Appearance.VertLine.Options.UseTextOptions = true;
            this.ScreenView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.ScreenView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScreenView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScreenView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScreenView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.ScreenView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ScreenView.GridControl = this.ScreenGrid;
            this.ScreenView.Name = "ScreenView";
            this.ScreenView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.ScreenView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.ScreenView.OptionsBehavior.AllowIncrementalSearch = true;
            this.ScreenView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.ScreenView.OptionsBehavior.Editable = false;
            this.ScreenView.OptionsCustomization.AllowColumnMoving = false;
            this.ScreenView.OptionsCustomization.AllowColumnResizing = false;
            this.ScreenView.OptionsCustomization.AllowFilter = false;
            this.ScreenView.OptionsCustomization.AllowGroup = false;
            this.ScreenView.OptionsFind.AlwaysVisible = true;
            this.ScreenView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.ScreenView.OptionsPrint.EnableAppearanceOddRow = true;
            this.ScreenView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ScreenView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.ScreenView.OptionsView.EnableAppearanceEvenRow = true;
            this.ScreenView.OptionsView.EnableAppearanceOddRow = true;
            this.ScreenView.OptionsView.RowAutoHeight = true;
            this.ScreenView.OptionsView.ShowGroupPanel = false;
            this.ScreenView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ScreenView_RowClick);
            this.ScreenView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ScreenView_FocusedRowChanged);
            this.ScreenView.RowCountChanged += new System.EventHandler(this.ScreenView_RowCountChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.dgvPermissions);
            this.groupControl1.Location = new System.Drawing.Point(9, 62);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(325, 294);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Permissions in Screen";
            // 
            // dgvPermissions
            // 
            this.dgvPermissions.AllowUserToAddRows = false;
            this.dgvPermissions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPermissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPermissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PerCode,
            this.PerName,
            this.check});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermissions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPermissions.Location = new System.Drawing.Point(2, 20);
            this.dgvPermissions.Name = "dgvPermissions";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermissions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPermissions.RowHeadersVisible = false;
            this.dgvPermissions.Size = new System.Drawing.Size(321, 272);
            this.dgvPermissions.TabIndex = 13;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrev.Location = new System.Drawing.Point(100, 362);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 30);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFirst.Location = new System.Drawing.Point(64, 362);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 30);
            this.btnFirst.TabIndex = 10;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLast.Location = new System.Drawing.Point(249, 362);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 30);
            this.btnLast.TabIndex = 9;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.Location = new System.Drawing.Point(212, 362);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 8;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(230, 447);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(231, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(10, 410);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(103, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(10, 447);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(103, 23);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Screen Name :";
            // 
            // txtScreenName
            // 
            this.txtScreenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScreenName.Location = new System.Drawing.Point(102, 36);
            this.txtScreenName.Name = "txtScreenName";
            this.txtScreenName.Size = new System.Drawing.Size(231, 20);
            this.txtScreenName.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Screen Code :";
            // 
            // txtScreenCode
            // 
            this.txtScreenCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScreenCode.Enabled = false;
            this.txtScreenCode.Location = new System.Drawing.Point(100, 8);
            this.txtScreenCode.Name = "txtScreenCode";
            this.txtScreenCode.Size = new System.Drawing.Size(233, 20);
            this.txtScreenCode.TabIndex = 0;
            // 
            // PerCode
            // 
            this.PerCode.HeaderText = "Permission Code";
            this.PerCode.Name = "PerCode";
            this.PerCode.Visible = false;
            // 
            // PerName
            // 
            this.PerName.HeaderText = "Permission Name";
            this.PerName.Name = "PerName";
            this.PerName.ReadOnly = true;
            // 
            // check
            // 
            this.check.FalseValue = "False";
            this.check.FillWeight = 50.76142F;
            this.check.HeaderText = "Check";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.TrueValue = "True";
            // 
            // FRM_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 483);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Screen Management";
            this.Load += new System.EventHandler(this.FRM_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScreenGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScreenName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScreenCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl ScreenGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView ScreenView;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtScreenName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtScreenCode;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvPermissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}