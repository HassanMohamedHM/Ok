namespace UILayer.Accounts
{
    partial class FRM_FinancialDeminsion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_FinancialDeminsion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDeminsions = new System.Windows.Forms.DataGridView();
            this.FinDemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinDemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeminsions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeminsions
            // 
            resources.ApplyResources(this.dgvDeminsions, "dgvDeminsions");
            this.dgvDeminsions.AllowUserToAddRows = false;
            this.dgvDeminsions.AllowUserToDeleteRows = false;
            this.dgvDeminsions.AllowUserToResizeColumns = false;
            this.dgvDeminsions.AllowUserToResizeRows = false;
            this.dgvDeminsions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeminsions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeminsions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeminsions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeminsions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FinDemCode,
            this.FinDemName,
            this.accCode,
            this.accName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeminsions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeminsions.MultiSelect = false;
            this.dgvDeminsions.Name = "dgvDeminsions";
            this.dgvDeminsions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeminsions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeminsions.RowHeadersVisible = false;
            this.dgvDeminsions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeminsions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellDoubleClick);
            // 
            // FinDemCode
            // 
            resources.ApplyResources(this.FinDemCode, "FinDemCode");
            this.FinDemCode.Name = "FinDemCode";
            this.FinDemCode.ReadOnly = true;
            // 
            // FinDemName
            // 
            resources.ApplyResources(this.FinDemName, "FinDemName");
            this.FinDemName.Name = "FinDemName";
            this.FinDemName.ReadOnly = true;
            // 
            // accCode
            // 
            resources.ApplyResources(this.accCode, "accCode");
            this.accCode.Name = "accCode";
            this.accCode.ReadOnly = true;
            // 
            // accName
            // 
            resources.ApplyResources(this.accName, "accName");
            this.accName.Name = "accName";
            this.accName.ReadOnly = true;
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.txtSearch);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Name = "panelControl1";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.AccessibleDescription = resources.GetString("txtSearch.Properties.AccessibleDescription");
            this.txtSearch.Properties.AccessibleName = resources.GetString("txtSearch.Properties.AccessibleName");
            this.txtSearch.Properties.AutoHeight = ((bool)(resources.GetObject("txtSearch.Properties.AutoHeight")));
            this.txtSearch.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtSearch.Properties.Mask.AutoComplete")));
            this.txtSearch.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtSearch.Properties.Mask.BeepOnError")));
            this.txtSearch.Properties.Mask.EditMask = resources.GetString("txtSearch.Properties.Mask.EditMask");
            this.txtSearch.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtSearch.Properties.Mask.IgnoreMaskBlank")));
            this.txtSearch.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtSearch.Properties.Mask.MaskType")));
            this.txtSearch.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtSearch.Properties.Mask.PlaceHolder")));
            this.txtSearch.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtSearch.Properties.Mask.SaveLiteral")));
            this.txtSearch.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtSearch.Properties.Mask.ShowPlaceHolders")));
            this.txtSearch.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtSearch.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtSearch.Properties.NullValuePrompt = resources.GetString("txtSearch.Properties.NullValuePrompt");
            this.txtSearch.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtSearch.Properties.NullValuePromptShowForEmptyValue")));
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // FRM_FinancialDeminsion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDeminsions);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_FinancialDeminsion";
            this.Load += new System.EventHandler(this.FRM_FinancialDeminsion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeminsions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDeminsions;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinDemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinDemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn accName;
    }
}