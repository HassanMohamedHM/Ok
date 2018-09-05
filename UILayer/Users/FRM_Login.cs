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
using BLLayer;
using System.Threading;
using System.Security.Principal;
using DALLayer;
namespace UILayer.Users
{
    public partial class FRM_Login : DevExpress.XtraEditors.XtraForm
    {
        public FRM_Login()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");
            InitializeComponent();
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            try
            {
                UserManager.FillUserComboBox(cmbUsers);

               if( new TransactionLineManager().GetAll().Count()>=400)
               {
                   MessageBox.Show("عفواً لقد أنتهت النسخة التجريبية يرجى الإتصال على شركة  أوكي  للبرامج المحاسبية ","شركة أوكي");
                    new Licences.FRM_About().ShowDialog();
                    this.Close();
                    Application.Exit();
               }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("You must Enter Password");
                    return;
                }
                UserManager user = new UserManager();
                User curUser = user.Get(int.Parse(cmbUsers.SelectedValue.ToString()));

                if (curUser.Password == txtPassword.Text)
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(
                        new GenericIdentity(cmbUsers.SelectedValue.ToString()),
                        curUser.UserRoles.Select(ur => ur.Role).Select(r => r.Role_Name).ToArray()
                        );

                    if (curUser.UserRoles.First().Role.Role_Name == "Seller")
                    {
                        Invoices.FRM_SalesInvoice sale = new Invoices.FRM_SalesInvoice();
                        this.Hide();
                        sale.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {

                        FRM_HomePage home = new FRM_HomePage();
                        this.Hide();
                        home.ShowDialog();
                        Application.Exit();
                    }
                    
                }
                else
                {
                    MessageBox.Show("هذا الباسورد خطأ برجاء التأكد من الباسور والمحاولة مرة اّخرى");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}