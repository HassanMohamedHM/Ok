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
using DevExpress.XtraEditors;
namespace UILayer.Posting
{
    public partial class FRM_ItemGroupPosting : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProductPostingManager PrPost = new ProductPostingManager();
        public FRM_ItemGroupPosting()
        {
            InitializeComponent();
        }

        private void FRM_ItemGroupPosting_Load(object sender, EventArgs e)
        {
            try
            {
                #region Fill Grid View By Data :
                ItemGroupsGrid.DataSource = new ProductGroupManager().CreateTable();
                #endregion

                #region Fill search Look Up By Data :
                HelperClass.FillSearchLookUpByData(Issue, new AccountsManager().CreateTable(),
                    AccountsManager.AccountDetails.accName.ToString(),
                    AccountsManager.AccountDetails.accCode.ToString());

                HelperClass.FillSearchLookUpByData(Consumption, new AccountsManager().CreateTable(),
                    AccountsManager.AccountDetails.accName.ToString(),
                    AccountsManager.AccountDetails.accCode.ToString());

                HelperClass.FillSearchLookUpByData(Revenue, new AccountsManager().CreateTable(),
                    AccountsManager.AccountDetails.accName.ToString(),
                    AccountsManager.AccountDetails.accCode.ToString());

                HelperClass.FillSearchLookUpByData(SalesDiscount, new AccountsManager().CreateTable(),
                    AccountsManager.AccountDetails.accName.ToString(),
                    AccountsManager.AccountDetails.accCode.ToString());

                HelperClass.FillSearchLookUpByData(ProductReciept, new AccountsManager().CreateTable(),
                    AccountsManager.AccountDetails.accName.ToString(),
                    AccountsManager.AccountDetails.accCode.ToString());

                HelperClass.FillSearchLookUpByData(PurchaseAccrual, new AccountsManager().CreateTable(),
                    AccountsManager.AccountDetails.accName.ToString(),
                    AccountsManager.AccountDetails.accCode.ToString());


                HelperClass.FillSearchLookUpByData(PurchaseDiscount, new AccountsManager().CreateTable(),
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
                if (Issue.EditValue == null || Consumption.EditValue == null || Revenue.EditValue == null || SalesDiscount.EditValue == null
                    || ProductReciept.EditValue == null || PurchaseAccrual.EditValue == null || PurchaseDiscount.EditValue == null)
                {

                    MessageBox.Show("You Must Chhose All Accounts", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                #region Add New :
                if (IsNew == true)
                {
                    PrPost.Add(new ItemPosting()
                        {
                            ProductGroupCode = ProductGroupCode,

                            #region Sales :
                            IssueAccount = Issue.EditValue.ToString(),
                            ConsumptionAccount = Consumption.EditValue.ToString(),
                            RevenueAccount = Revenue.EditValue.ToString(),
                            SalesDiscountAccount = SalesDiscount.EditValue.ToString(),
                            #endregion

                            #region Purchase :
                            ProductRecieptAccount = ProductReciept.EditValue.ToString(),
                            PurchaseAccrualAccount = PurchaseAccrual.EditValue.ToString(),
                            PurchaseDiscountAccount = PurchaseDiscount.EditValue.ToString(),
                            #endregion
                        });
                } 
                #endregion

                #region Modify :
                else
                {
                    #region Sales :
                    item.IssueAccount = Issue.EditValue.ToString();
                    item.ConsumptionAccount = Consumption.EditValue.ToString();
                    item.RevenueAccount = Revenue.EditValue.ToString();
                    item.SalesDiscountAccount = SalesDiscount.EditValue.ToString();
                    #endregion

                    #region Purchase :
                    item.ProductRecieptAccount = ProductReciept.EditValue.ToString();
                    item.PurchaseAccrualAccount = PurchaseAccrual.EditValue.ToString();
                    item.PurchaseDiscountAccount = PurchaseDiscount.EditValue.ToString();
                    #endregion

                    PrPost.Update(item);
                } 
                #endregion

                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int ProductGroupCode;
        bool IsNew = true;
        ItemPosting item;
        private void ItemGroupsView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (ItemGroupsView.RowCount > 0)
                {
                    ProductGroupCode = int.Parse(ItemGroupsView.GetRowCellValue(e.RowHandle, ItemGroupsView.Columns[0]).ToString());

                    if (PrPost.GetAll().Count() > 0)
                    {
                        item = PrPost.Get(ProductGroupCode);
                        if (item != null)
                        {
                            IsNew = false;

                            #region Sales :
                            Issue.EditValue = item.IssueAccount;
                            Consumption.EditValue = item.ConsumptionAccount;
                            Revenue.EditValue = item.RevenueAccount;
                            SalesDiscount.EditValue = item.SalesDiscountAccount;
                            #endregion

                            #region Purchase :
                            ProductReciept.EditValue = item.ProductRecieptAccount;
                            PurchaseAccrual.EditValue = item.PurchaseAccrualAccount;
                            PurchaseDiscount.EditValue = item.PurchaseDiscountAccount;
                            #endregion
                        }
                        else
                        {
                            IsNew = true;
                            Issue.EditValue = Consumption.EditValue = Revenue.EditValue = SalesDiscount.EditValue
                            = ProductReciept.EditValue = PurchaseAccrual.EditValue = PurchaseDiscount.EditValue = null;
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