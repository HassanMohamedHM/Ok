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
using DALLayer;
using BLLayer;
namespace UILayer.Accounts
{
    public partial class FRM_CustomerStatement : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FRM_CustomerStatement()
        {
            InitializeComponent();
        }

        private void FRM_CustomerStatement_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new CustomerManager().CreateTable().Copy();
                for (int i = 2; i < dt.Columns.Count; i = 2)
                {
                    dt.Columns.RemoveAt(i);
                }
                CustomerSearchLookUpEdit.DataSource = dt;
                CustomerSearchLookUpEdit.DisplayMember = CustomerSearchLookUpEdit.ValueMember = CustomerManager.CustomerDetails.CustomerCode.ToString();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        decimal Customer_Debit, Customer_Credit;
        private void btnDisplay_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (Customer.EditValue == null)
                {
                    MessageBox.Show("You must Choose Customer", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                DataTable dt = CustomerManager.GetCustomerStatement(Customer.EditValue.ToString(), null, null, out Customer_Debit, out Customer_Credit);
                CustomerStatementGrid.DataSource = dt;
                CustomerStatementGrid.DataMember = dt.TableName;
                CustomerDebit.Caption = Customer_Debit.ToString();
                CustomerCredit.Caption = Customer_Credit.ToString();
                CustomerBalance.Caption = (Customer_Debit - Customer_Credit).ToString();
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
                if (Customer.EditValue == null)
                {
                    MessageBox.Show("You must Choose Customer", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                DataTable dt = CustomerManager.GetCustomerStatement(Customer.EditValue.ToString(), (DateTime)DateFrom.EditValue, (DateTime)DateTo.EditValue, out Customer_Debit, out Customer_Credit);
                CustomerStatementGrid.DataSource = dt;
                CustomerStatementGrid.DataMember = dt.TableName;
                CustomerDebit.Caption = Customer_Debit.ToString();
                CustomerCredit.Caption = Customer_Credit.ToString();
                CustomerBalance.Caption = (Customer_Debit - Customer_Credit).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomerStatementView.ShowRibbonPrintPreview();
        }
    }
}