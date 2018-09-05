using System;
using System.Windows.Forms;
using BLLayer;
using System.Collections.Generic;
using DALLayer;
using System.Linq;
using System.Threading;
namespace UILayer.Invoices
{
    public partial class FRM_PurchaseInvoice : DevExpress.XtraEditors.XtraForm
    {
        List<Product> ProductList;
        PurchaseManager purchase = new PurchaseManager();

        decimal InvoiceTotal = 0;
        public FRM_PurchaseInvoice()
        {
            InitializeComponent();
            dgvProducts.BackgroundColor = this.BackColor;
        }
        private void FRM_PurchaseInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                WareHouseManager.FillWareHouseComboBox(cmbWareHouse);
                VendorManager.FillVendorComboBox(cmbVendor);
                UnitManager.FillUnitComboBox(cmbUnit);

                HelperClass.FillSearchLookUpByData(cmbProduct, new ProductManager().CreateTable(), ProductManager.ProductDetails.ProductName.ToString(), ProductManager.ProductDetails.ProductCode.ToString());
                ProductList = new ProductManager().GetAll().ToList();
                btnAddNew_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                spPrice.Focus();
                e.Handled = true;
            }
        }

        private void cmbUnit_DropDownClosed(object sender, EventArgs e)
        {
            spPrice.Focus();
        }
        private void spPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                spQty.Focus();
                e.Handled = true;
            }
        }

        private void spQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddRecordToGrid(e);
                radPaymentSystem_SelectedIndexChanged(null, null);
                txtProduct.Focus();
                e.Handled = true;
            }
        }

        private void dtExpired_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void AddRecordToGrid(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (spQty.Value <= 0)
                {
                    return;
                }
                decimal _Total = (spQty.Value * spPrice.Value);
                InvoiceTotal += _Total;
                dgvProducts.Rows.Add(txtProduct.Tag, txtProduct.Text, cmbUnit.SelectedValue,
                    cmbUnit.Text, spPrice.Value, spQty.Value, _Total);
                txtProduct.Text = "";
                spPrice.Value = spQty.Value = 0;
                txtInvoiceTotal.Text = InvoiceTotal.ToString();
                txtProduct.Focus();
                e.Handled = true;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtInvoiceReminder.Text = txtInvoiceTotal.Text = spInvoicePaied.Text = "0";
                txtInvoiceCode.Text = purchase.GetCode().ToString();
                btnSave.Enabled = cmbVendor.Enabled = radInvoiceType.Enabled = radPaymentSystem.Enabled = grpProductDetails.Enabled = true;
                InvoiceTotal = 0;
                dgvProducts.Rows.Clear();
                btnAddNew.Enabled = false;
                txtProduct.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProducts.Columns[e.ColumnIndex].Name == btnDelete.Name)
                {
                    InvoiceTotal -= (decimal)dgvProducts.Rows[e.RowIndex].Cells[Total.Name].Value;
                    dgvProducts.Rows.RemoveAt(e.RowIndex);
                    txtInvoiceTotal.Text = InvoiceTotal.ToString();
                    txtProduct.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void radPaymentSystem_SelectedIndexChanged(object sender, EventArgs e)
        {

            spInvoicePaied.Enabled = radPaymentSystem.SelectedIndex == 0 ? false : true;
            if (radPaymentSystem.SelectedIndex == 0)
            {
                spInvoicePaied.Value = InvoiceTotal;
            }
            else
            {
                spInvoicePaied.Value = 0;
            }
            spInvoicePaied_EditValueChanged(null, null);
        }

        private void spInvoicePaied_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (spInvoicePaied.Value >= 0)
                {
                    txtInvoiceReminder.Text = (decimal.Parse(txtInvoiceTotal.Text) - spInvoicePaied.Value).ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtInvoiceTotal_TextChanged(object sender, EventArgs e)
        {
            spInvoicePaied_EditValueChanged(null, null);
        }
        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtProduct.Text != "")
                    {
                        Product pr = ProductList.Where(p => p.Product_Barcode == txtProduct.Text).FirstOrDefault();
                        if (pr != null)
                        {
                            txtProduct.Text = pr.Product_Name;
                            txtProduct.Tag = pr.Product_Code;
                            cmbUnit.Text = pr.Unit.Unit_Name;
                            spPrice.Value = (decimal)pr.DefPurchasePrice;
                            spPrice.Focus();
                        }
                        else
                        {
                            MessageBox.Show("This Product Not Exist");
                        }
                    }
                    e.Handled = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    cmbProduct.Visible = true;
                    cmbProduct.Focus();
                    cmbProduct.ShowPopup();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    Product pr = ProductList.Where(p => p.Product_Code == int.Parse(cmbProduct.EditValue.ToString())).FirstOrDefault();
                    txtProduct.Text = pr.Product_Name;
                    txtProduct.Tag = pr.Product_Code;
                    cmbUnit.Text = pr.Unit.Unit_Name;
                    spPrice.Value = (decimal)pr.DefPurchasePrice;
                    spPrice.Focus();
                    cmbProduct.Visible = false;
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        TransactionHeaderManager header = new TransactionHeaderManager();
        TransactionLineManager lines = new TransactionLineManager();
        PostedTransactionsManager posted = new PostedTransactionsManager();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * RadInvoiceType ==0    ---> مشتريات (false)
                 * RadInvoiceType ==1    ---> مرتجع مشتريات (true)
                 * RadPaymentSystem ==0  --->كاش (false)
                 * RadPaymentSystem ==1  --->أجل (false)
                 */
                if (dgvProducts.Rows.Count <= 0)
                {
                    return;
                }

                #region Variables :
                DateTime Date = DateTime.Now;
                int UserCode = int.Parse(Thread.CurrentPrincipal.Identity.Name);
                int WHCode = int.Parse(cmbWareHouse.SelectedValue.ToString());
                int VendorCode = int.Parse(cmbVendor.SelectedValue.ToString());
                decimal PurchaseTotal = decimal.Parse(txtInvoiceTotal.Text);
                decimal PurchasePaied = decimal.Parse(spInvoicePaied.Text);
                decimal PurchaseReminder = decimal.Parse(txtInvoiceReminder.Text);
                long TransactionCode = long.Parse(header.GetCode().ToString());
                #endregion

                #region Add Invoice Header :
                purchase.AddInvoiceHeader(txtInvoiceCode.Text, Date, PurchaseTotal, PurchasePaied, PurchaseReminder,
                    radInvoiceType.SelectedIndex == 0 ? false : true,
                    WHCode, VendorCode, radPaymentSystem.SelectedIndex == 0 ? false : true, UserCode);
                #endregion


                string ProductRecieptAccount, VendorAccount, CashAccount, PurchaseDiscountAccount;
                VendorPostingManager.GetVendorPostingAccountsCode(VendorCode, out VendorAccount, out CashAccount);

                #region Add Transaction Header Details :
                header.AddHeaderDetails(TransactionCode, radInvoiceType.SelectedIndex == 0 ? 1 : 2, Date, radInvoiceType.SelectedIndex == 0 ? "فاتورة مشتريات" : "مرتجع مشتريات", UserCode, true);
                #endregion

                for (int i = 0; i < dgvProducts.Rows.Count; i++)
                {
                    #region  Variables :
                    int PCode = int.Parse(dgvProducts.Rows[i].Cells[ProductCode.Name].Value.ToString());
                    int UCode = int.Parse(dgvProducts.Rows[i].Cells[UnitCode.Name].Value.ToString());
                    decimal UPrice = decimal.Parse(dgvProducts.Rows[i].Cells[Price.Name].Value.ToString());
                    decimal PQty = decimal.Parse(dgvProducts.Rows[i].Cells[Qty.Name].Value.ToString());
                    decimal PQTotal = decimal.Parse(dgvProducts.Rows[i].Cells[Total.Name].Value.ToString());
                    #endregion

                    #region Add Purchase Details :
                    purchase.AddInvoiceDetails(txtInvoiceCode.Text, PCode, UCode, (double)UPrice, PQty, PQTotal);
                    #endregion

                    #region Add OnHandProduct Details :
                    new OnHandProductManager().AddOnHandDetails(PCode, WHCode, PQty, UCode, UPrice, radInvoiceType.SelectedIndex == 0 ? false : true, true);
                    #endregion


                    ProductPostingManager.GetPurchasePostingAccountsCode(PCode, out ProductRecieptAccount, out PurchaseDiscountAccount);

                    #region Add Transaction Details :

                    #region If Invoice is Cash Or Accrual :

                    #region Add Transaction Line Details :


                    if (radInvoiceType.SelectedIndex == 0)
                    {
                        lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(), ProductRecieptAccount,
                                       PQTotal, null, "قيد مشتريات", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                                       VendorAccount + "-2-" + VendorCode);

                    }
                    else if (radInvoiceType.SelectedIndex == 1)
                    {
                        lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(), VendorAccount + "-2-" + VendorCode,
                                       PQTotal, null, "قيد مرتجع مشتريات", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                                      ProductRecieptAccount);
                    }


                    #endregion

                    #region Add Posted Lines Details :
                    if (radInvoiceType.SelectedIndex == 0)
                    {
                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, ProductRecieptAccount, PQTotal, null);

                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, VendorAccount + "-2-" + VendorCode, null, PQTotal);
                    }
                    else if (radInvoiceType.SelectedIndex == 1)
                    {
                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, VendorAccount + "-2-" + VendorCode, PQTotal, null);

                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, ProductRecieptAccount, null, PQTotal);
                    }
                    #endregion

                    #endregion

                    #endregion

                }

                #region If Invoice is Cash :
                if (radPaymentSystem.SelectedIndex == 0)
                {
                    if (radInvoiceType.SelectedIndex == 0)
                    {
                        #region Add Transaction Line Details :
                        lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                            VendorAccount + "-2-" + VendorCode, PurchaseTotal, null, "سداد المورد", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                            CashAccount);
                        #endregion


                        #region Add Posted Lines Details :
                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, VendorAccount + "-2-" + VendorCode, PurchaseTotal, null);

                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CashAccount, null, PurchaseTotal);

                        #endregion
                    }
                    else if (radInvoiceType.SelectedIndex == 1)
                    {
                        #region Add Transaction Line Details :
                        lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                           CashAccount, PurchaseTotal, null,
                            "سداد المورد", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                            VendorAccount + "-2-" + VendorCode);
                        #endregion


                        #region Add Posted Lines Details :
                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CashAccount, PurchaseTotal, null);

                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, VendorAccount + "-2-" + VendorCode, null, PurchaseTotal);

                        #endregion
                    }

                }
                #endregion

                #region If Invoice is Accrual :
                else if (radPaymentSystem.SelectedIndex == 1 && PurchasePaied > 0)
                {
                    if (radInvoiceType.SelectedIndex == 0)
                    {
                        #region Add Transaction Line Details :
                        lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                            VendorAccount + "-2-" + VendorCode, PurchasePaied, null, "سداد المورد", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                            CashAccount);
                        #endregion

                        #region Add Posted Lines Details :
                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, VendorAccount + "-2-" + VendorCode, PurchasePaied, null);

                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CashAccount, null, PurchasePaied);

                        #endregion
                    }
                    else if (radInvoiceType.SelectedIndex == 0)
                    {
                        #region Add Transaction Line Details :
                        lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                            CashAccount, PurchasePaied, null, "سداد المورد", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                            VendorAccount + "-2-" + VendorCode);
                        #endregion

                        #region Add Posted Lines Details :
                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CashAccount, PurchasePaied, null);

                        posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, VendorAccount + "-2-" + VendorCode, null, PurchasePaied);

                        #endregion
                    }
                }
                #endregion

                MessageBox.Show("Success");

                btnAddNew.Enabled = true;
                btnSave.Enabled = false;
                btnPrint.Enabled = true;
                btnAddNew_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Reports.PurchaseInvoice rpt = new Reports.PurchaseInvoice();
            //rpt.SetParameterValue("@PurchaseCode", txtInvoiceCode.Text);
            //rpt.PrintToPrinter(1, true, 1, 1);
        }
    }
}