namespace UILayer.Licences
{
    partial class FRM_Licence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Licence));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLicence = new DevExpress.XtraEditors.TextEdit();
            this.btnLicence = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // txtLicence
            // 
            resources.ApplyResources(this.txtLicence, "txtLicence");
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.Properties.AccessibleDescription = resources.GetString("txtLicence.Properties.AccessibleDescription");
            this.txtLicence.Properties.AccessibleName = resources.GetString("txtLicence.Properties.AccessibleName");
            this.txtLicence.Properties.AutoHeight = ((bool)(resources.GetObject("txtLicence.Properties.AutoHeight")));
            this.txtLicence.Properties.Mask.AutoComplete = ((DevExpress.XtraEditors.Mask.AutoCompleteType)(resources.GetObject("txtLicence.Properties.Mask.AutoComplete")));
            this.txtLicence.Properties.Mask.BeepOnError = ((bool)(resources.GetObject("txtLicence.Properties.Mask.BeepOnError")));
            this.txtLicence.Properties.Mask.EditMask = resources.GetString("txtLicence.Properties.Mask.EditMask");
            this.txtLicence.Properties.Mask.IgnoreMaskBlank = ((bool)(resources.GetObject("txtLicence.Properties.Mask.IgnoreMaskBlank")));
            this.txtLicence.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtLicence.Properties.Mask.MaskType")));
            this.txtLicence.Properties.Mask.PlaceHolder = ((char)(resources.GetObject("txtLicence.Properties.Mask.PlaceHolder")));
            this.txtLicence.Properties.Mask.SaveLiteral = ((bool)(resources.GetObject("txtLicence.Properties.Mask.SaveLiteral")));
            this.txtLicence.Properties.Mask.ShowPlaceHolders = ((bool)(resources.GetObject("txtLicence.Properties.Mask.ShowPlaceHolders")));
            this.txtLicence.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtLicence.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtLicence.Properties.NullValuePrompt = resources.GetString("txtLicence.Properties.NullValuePrompt");
            this.txtLicence.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtLicence.Properties.NullValuePromptShowForEmptyValue")));
            // 
            // btnLicence
            // 
            resources.ApplyResources(this.btnLicence, "btnLicence");
            this.btnLicence.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLicence.Name = "btnLicence";
            this.btnLicence.Click += new System.EventHandler(this.btnLicence_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureEdit1
            // 
            resources.ApplyResources(this.pictureEdit1, "pictureEdit1");
            this.pictureEdit1.EditValue = global::UILayer.Properties.Resources.OK;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AccessibleDescription = resources.GetString("pictureEdit1.Properties.AccessibleDescription");
            this.pictureEdit1.Properties.AccessibleName = resources.GetString("pictureEdit1.Properties.AccessibleName");
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // FRM_Licence
            // 
            this.AcceptButton = this.btnLicence;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLicence);
            this.Controls.Add(this.txtLicence);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Licence";
            this.Load += new System.EventHandler(this.FRM_Licence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLicence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLicence;
        private DevExpress.XtraEditors.SimpleButton btnLicence;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}