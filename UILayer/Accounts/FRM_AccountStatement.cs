using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLLayer;

namespace UILayer.Accounts
{
    public partial class FRM_AccountStatement : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FRM_AccountStatement()
        {
            InitializeComponent();
        }

        private void FRM_AccountStatement_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new AccountsManager().CreateTable().Copy();
                for (int i = 2; i < dt.Columns.Count; i = 2)
                {
                    dt.Columns.RemoveAt(i);
                }
                AccountSearchLookUpEdit.DataSource = dt;
                AccountSearchLookUpEdit.DisplayMember = AccountSearchLookUpEdit.ValueMember = AccountsManager.AccountDetails.accCode.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        decimal Account_Debit, Account_Credit;
        private void btnDisplay_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (Account.EditValue == null)
                {
                    MessageBox.Show("You must Choose Vendor", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                DataTable dt = AccountsManager.GetAccountStatement(Account.EditValue.ToString(), null, null, out Account_Debit, out Account_Credit);
                AccountStatementGrid.DataSource = dt;
                AccountStatementGrid.DataMember = dt.TableName;
                AccountDebit.Caption = Account_Debit.ToString();
                AccountCredit.Caption = Account_Credit.ToString();
                AccountBalance.Caption = (Account_Debit - Account_Credit).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPeriodDisplay_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (Account.EditValue == null)
                {
                    MessageBox.Show("You must Choose Account", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (DateFrom.EditValue == null)
                {
                    MessageBox.Show("You must Choose From Date", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (DateTo.EditValue == null)
                {
                    MessageBox.Show("You must Choose To Date", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if ((DateTime)DateFrom.EditValue > (DateTime)DateTo.EditValue)
                {
                    MessageBox.Show("From Date must be Less than Or Equal To Date", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                DataTable dt = AccountsManager.GetAccountStatement(Account.EditValue.ToString(), (DateTime)DateFrom.EditValue, (DateTime)DateTo.EditValue, out Account_Debit, out Account_Credit);
                AccountStatementGrid.DataSource = dt;
                AccountStatementGrid.DataMember = dt.TableName;
                AccountDebit.Caption = Account_Debit.ToString();
                AccountCredit.Caption = Account_Credit.ToString();
                AccountBalance.Caption = (Account_Debit - Account_Credit).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            AccountStatementView.ShowRibbonPrintPreview();
        }
    }
}