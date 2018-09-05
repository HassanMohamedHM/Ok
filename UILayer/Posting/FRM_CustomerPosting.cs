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
using DevExpress.XtraEditors;
using DALLayer;
using BLLayer;

namespace UILayer.Posting
{
    public partial class FRM_CustomerPosting : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CustomerPostingManager customer = new CustomerPostingManager();
        public FRM_CustomerPosting()
        {
            InitializeComponent();
           
        }

        private void FRM_CustomerPosting_Load(object sender, EventArgs e)
        {
            try
            {
                #region Fill Grid View By Data :
                CustomerGroupsGrid.DataSource = new CustomerGroupManager().CreateTable();
                #endregion

                #region Fill search Look Up By Data :
                HelperClass.FillSearchLookUpByData(CustomerAccount, new AccountsManager().CreateTable(),
                    AccountsManager.AccountDetails.accName.ToString(),
                    AccountsManager.AccountDetails.accCode.ToString());

                HelperClass.FillSearchLookUpByData(CashAccount, new AccountsManager().CreateTable(),
                    AccountsManager.AccountDetails.accName.ToString(),
                    AccountsManager.AccountDetails.accCode.ToString());


                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }
        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (CustomerAccount.EditValue == null || CashAccount.EditValue == null )
                {

                    MessageBox.Show("You Must Chhose All Accounts", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                #region Add New :
                if (IsNew == true)
                {
                    customer.Add(new CustomerPosting()
                    {
                        CustomerGroupCode = CustomerGroupCode,
                        CustomerAccount = CustomerAccount.EditValue.ToString(),
                        CashAccount = CashAccount.EditValue.ToString()
                    });
                }
                #endregion

                #region Modify :
                else
                {
                    Cust.CustomerAccount = CustomerAccount.EditValue.ToString();
                    Cust.CashAccount = CashAccount.EditValue.ToString();

                    customer.Update(Cust);
                }
                #endregion

                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int CustomerGroupCode;
        bool IsNew = true;
        CustomerPosting Cust;
        private void CustomerGroupsView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (CustomerGroupsView.RowCount > 0)
                {
                    CustomerGroupCode = int.Parse(CustomerGroupsView.GetRowCellValue(e.RowHandle, CustomerGroupsView.Columns[0]).ToString());

                    if (customer.GetAll().Count() > 0)
                    {
                        Cust = customer.Get(CustomerGroupCode);
                        if (Cust != null)
                        {
                            IsNew = false;
                            CustomerAccount.EditValue = Cust.CustomerAccount;
                            CashAccount.EditValue = Cust.CashAccount;
                        }
                        else
                        {
                            IsNew = true;
                            CustomerAccount.EditValue = CashAccount.EditValue = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}