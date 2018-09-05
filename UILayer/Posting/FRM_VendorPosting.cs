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
namespace UILayer.Posting
{
    public partial class FRM_VendorPosting : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        VendorPostingManager vendor = new VendorPostingManager();
        public FRM_VendorPosting()
        {
            InitializeComponent();
        }

        private void FRM_VendorPosting_Load(object sender, EventArgs e)
        {
            #region Fill Grid View By Data :
            VendorGroupsGrid.DataSource = new VendorGroupManager().CreateTable();
            #endregion

            #region Fill search Look Up By Data :
            HelperClass.FillSearchLookUpByData(VendorAccount, new AccountsManager().CreateTable(),
                AccountsManager.AccountDetails.accName.ToString(),
                AccountsManager.AccountDetails.accCode.ToString());

            HelperClass.FillSearchLookUpByData(CashAccount, new AccountsManager().CreateTable(),
                AccountsManager.AccountDetails.accName.ToString(),
                AccountsManager.AccountDetails.accCode.ToString());


            #endregion
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (VendorAccount.EditValue == null || CashAccount.EditValue == null)
                {

                    MessageBox.Show("You Must Chhose All Accounts", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                #region Add New :
                if (IsNew == true)
                {
                    vendor.Add(new VendorPosting()
                    {
                        VendorGroupCode = VendorGroupCode,
                       VendorAccount = VendorAccount.EditValue.ToString(),
                        CashAccount = CashAccount.EditValue.ToString()
                    });
                }
                #endregion

                #region Modify :
                else
                {
                    Vend.VendorAccount = VendorAccount.EditValue.ToString();
                    Vend.CashAccount = CashAccount.EditValue.ToString();

                    vendor.Update(Vend);
                }
                #endregion

                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int VendorGroupCode;
        bool IsNew = true;
        VendorPosting Vend;

        private void VendorGroupsView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (VendorGroupsView.RowCount > 0)
                {
                    VendorGroupCode = int.Parse(VendorGroupsView.GetRowCellValue(e.RowHandle, VendorGroupsView.Columns[0]).ToString());

                    if (vendor.GetAll().Count() > 0)
                    {
                        Vend = vendor.Get(VendorGroupCode);
                        if (Vend != null)
                        {
                            IsNew = false;
                            VendorAccount.EditValue = Vend.VendorAccount;
                            CashAccount.EditValue = Vend.CashAccount;
                        }
                        else
                        {
                            IsNew = true;
                            VendorAccount.EditValue = CashAccount.EditValue = null;
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