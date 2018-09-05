using System;
using System.Windows.Forms;
using BLLayer;
using DALLayer;
namespace UILayer.Accounts
{
    public partial class FRM_AddFinancialDeminsion : DevExpress.XtraEditors.XtraForm
    {
        FinancialDeminsionManager findem = new FinancialDeminsionManager();
        public FRM_AddFinancialDeminsion()
        {
            InitializeComponent();
        }

        private void txtMainAccount_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //FRM_AllAccounts account = new FRM_AllAccounts();
                //account.ShowDialog();
                //txtMainAccount.Text = account.dgvAccounts.CurrentRow.Cells["accName"].Value.ToString();
                //txtMainAccount.Tag = account.dgvAccounts.CurrentRow.Cells["accCode"].Value.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FRM_AddFinancialDeminsion_Load(object sender, EventArgs e)
        {
            try
            {
                txtFinDemCode.Text = findem.GetCode().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFinDemName.Text == "")
                {
                    MessageBox.Show("You must enter Financial Deminsion Name");
                    return;
                }
                findem.Add(new FinancialDeminsions()
                    {
                        FinDemCode = long.Parse(txtFinDemCode.Text),
                        FinDemName = txtFinDemName.Text
                    });
                MessageBox.Show("Success");
                txtFinDemName.Text = "";
                FRM_AddFinancialDeminsion_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}