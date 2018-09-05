using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using BLLayer;
using DALLayer;
namespace UILayer.Licences
{
    public partial class FRM_Licence : DevExpress.XtraEditors.XtraForm
    {
        public FRM_Licence()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLicence_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLicence.Text!="")
                {
                    LicenceManager licMG = new LicenceManager();
                    Lic lic= licMG.GetAll().FirstOrDefault(l => l.Lic1 == txtLicence.Text);
                    if (lic != null)
                    {
                        File.Create(@"C:\Windows\lic.txt");
                        licMG.Delete(lic);
                        Users.FRM_Login login = new  Users.FRM_Login();
                        this.Hide();
                        login.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("عفواّ رقم الترخيص غير صحيح");
                    }
                } 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FRM_Licence_Load(object sender, EventArgs e)
        {
            //Check File Existence
            if (File.Exists(@"C:\Windows\lic.txt"))
            {
                Users.FRM_Login login = new Users.FRM_Login();
                this.Hide();
                login.ShowDialog();
                Application.Exit();
            }
        }
    }
}