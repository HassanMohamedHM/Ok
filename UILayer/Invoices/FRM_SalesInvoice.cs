using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLLayer;
using DALLayer;
using System.Threading;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Text;
using System.Data;

namespace UILayer.Invoices
{
    public partial class FRM_SalesInvoice : DevExpress.XtraEditors.XtraForm
    {
        List<Product> ProductList;
        SalesHeaderManager sales = new SalesHeaderManager();
        decimal InvoiceTotal = 0;
        public FRM_SalesInvoice()
        {
            InitializeComponent();
            dgvProducts.BackgroundColor = this.BackColor;
        }
        private void FRM_SalesInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                WareHouseManager.FillWareHouseComboBox(cmbWareHouse);
                CustomerManager.FillCustomerComboBox(cmbCustomer);
                UnitManager.FillUnitComboBox(cmbUnit);

                ProductList = new ProductManager().GetAll().ToList();
                HelperClass.FillSearchLookUpByData(cmbProduct, new ProductManager().CreateTable(), ProductManager.ProductDetails.ProductName.ToString(),
                    ProductManager.ProductDetails.ProductCode.ToString());
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
                spInvoicePaied.Value = InvoiceTotal;
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
                spPrice.Value = spQty.Value = 1;
                txtInvoiceTotal.Text = InvoiceTotal.ToString();
                txtProduct.Focus();
                e.Handled = true;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                HelperClass.FillSearchLookUpByData(cmbProduct, new ProductManager().CreateTable(), ProductManager.ProductDetails.ProductName.ToString(),
                ProductManager.ProductDetails.ProductCode.ToString());
                txtInvoiceReminder.Text = txtInvoiceTotal.Text = spInvoicePaied.Text = "0";
                txtInvoiceCode.Text = sales.GetCode().ToString();
                btnSave.Enabled = cmbCustomer.Enabled = radInvoiceType.Enabled = radPaymentSystem.Enabled = grpProductDetails.Enabled = true;
                InvoiceTotal = 0;
                dgvProducts.Rows.Clear();
                btnPrint.Enabled = true;
                txtProduct.Focus();
                isSaved = false;
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

                if (spInvoicePaied.Value >= 0 && radPaymentSystem.SelectedIndex == 1)
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
                            spPrice.Value = (decimal)pr.DefSalesPrice;
                            spPrice.Focus();
                        }
                        else
                        {
                            MessageBox.Show("This Product Not Exist");
                        }
                    }
                    e.Handled = true;
                }


                else if (e.KeyCode == Keys.Down)
                {
                    
                    cmbProduct.Visible = true;
                    cmbProduct.Focus();
                    cmbProduct.ShowPopup();
                }

                else if (e.KeyCode == Keys.F11)
                {
                    btnSave_Click(null, null);
                }
                else if (e.KeyCode == Keys.F10)
                {
                    btnSave_Click(null, null);
                    btnPrint_Click(null, null);
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

        DateTime Date ;
        int UserCode ;
        int WHCode;
        int CustomerCode;
        decimal SalesTotal ;
        decimal SalesPaied ;
        decimal SalesReminder;
        DataGridViewRow[] ProductsCollection;
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
                 Date = DateTime.Now;
                 UserCode = int.Parse(Thread.CurrentPrincipal.Identity.Name);
                 WHCode = int.Parse(cmbWareHouse.SelectedValue.ToString());
                 CustomerCode = int.Parse(cmbCustomer.SelectedValue.ToString());
                 SalesTotal = decimal.Parse(txtInvoiceTotal.Text);
                 SalesPaied = decimal.Parse(spInvoicePaied.Text);
                 SalesReminder = decimal.Parse(txtInvoiceReminder.Text);
                
                #endregion


              ProductsCollection = new DataGridViewRow[dgvProducts.Rows.Count];

                dgvProducts.Rows.CopyTo(ProductsCollection, 0);

                #region Add Invoice Header :
                sales.AddInvoiceHeader(txtInvoiceCode.Text, Date, SalesTotal, SalesPaied, SalesReminder,
                    radInvoiceType.SelectedIndex == 0 ? false : true,
                    WHCode, CustomerCode, radPaymentSystem.SelectedIndex == 0 ? false : true, UserCode);
                #endregion

                

               
                //string IssueAccount, ConsumptionAccount, RevenueAccount, SalesDiscountAccount, CustomerAccount, CashAccount;
                //CustomerPostingManager.GetCustomerPostingAccountsCode(CustomerCode, out CustomerAccount, out CashAccount);

                //#region Add Transaction Header Details :
                //header.AddHeaderDetails(TransactionCode, 3, Date, "فاتورة مبيعات", UserCode, true);
                //#endregion

                for (int i = 0; i < dgvProducts.Rows.Count; i++)
                {
                    #region  Variables :
                    int PCode = int.Parse(dgvProducts.Rows[i].Cells[ProductCode.Name].Value.ToString());
                    int UCode = int.Parse(dgvProducts.Rows[i].Cells[UnitCode.Name].Value.ToString());
                    decimal UPrice = decimal.Parse(dgvProducts.Rows[i].Cells[Price.Name].Value.ToString());
                    decimal PQty = decimal.Parse(dgvProducts.Rows[i].Cells[Qty.Name].Value.ToString());
                    decimal PQTotal = decimal.Parse(dgvProducts.Rows[i].Cells[Total.Name].Value.ToString());
                    decimal AvgProductConsumption = (decimal)(OnHandProductManager.GetAvgCost(PCode) * PQty);
                    #endregion

                    #region Add Purchase Details :
                    sales.AddInvoiceDetails(txtInvoiceCode.Text, PCode, UCode, (double)UPrice, PQty, PQTotal);
                    #endregion

                    #region Add OnHandProduct Details :

                    new OnHandProductManager().AddOnHandDetails(PCode, WHCode, PQty, UCode, UPrice, !(radInvoiceType.SelectedIndex == 0 ? false : true), false);
                    #endregion

                    //ProductPostingManager.GetSalesPostingAccountsCode(PCode, out IssueAccount, out ConsumptionAccount, out RevenueAccount, out SalesDiscountAccount);

                    //#region Add Transaction Details :

                    //#region If Invoice is Cash Or Accrual :

                    //#region Add Transaction Line Details :
                    //lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                    //    CustomerAccount + "-1-" + CustomerCode, PQTotal, null, "من العميل للايرادات",
                    //    AccountsManager.AccountFilterationTypes.Ledger.ToString(), RevenueAccount);

                    //lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                    //    ConsumptionAccount, AvgProductConsumption, null, "من الاستهلاك للمخزون", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                    //    IssueAccount);
                    //#endregion

                    //#region Add Posted Lines Details :
                    //posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CustomerAccount + "-1-" + CustomerCode, PQTotal, null);

                    //posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, RevenueAccount, null, PQTotal);

                    //posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, ConsumptionAccount, AvgProductConsumption, null);

                    //posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, IssueAccount, null, AvgProductConsumption);
                    //#endregion

                    //#endregion

                    //#endregion

                }

                //#region If Invoice is Cash :
                //if (radPaymentSystem.SelectedIndex == 0)
                //{
                //    #region Add Transaction Line Details :
                //    lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                //        CashAccount, SalesTotal, null, "العميل سدد", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                //        CustomerAccount + "-1-" + CustomerCode);
                //    #endregion

                //    #region Add Posted Lines Details :
                //    posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CashAccount, SalesTotal, null);
                //    posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CustomerAccount + "-1-" + CustomerCode, null, SalesTotal);
                //    #endregion

                //}
                //#endregion

                //#region If Invoice is Accrual :
                //else if (radPaymentSystem.SelectedIndex == 1 && SalesPaied > 0)
                //{
                //    #region Add Transaction Line Details :
                //    lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                //        CashAccount, SalesPaied, null, "العميل سدد", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                //        CustomerAccount + "-1-" + CustomerCode);
                //    #endregion

                //    #region Add Posted Lines Details :
                //    posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CashAccount, SalesPaied, null);
                //    posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CustomerAccount + "-1-" + CustomerCode, null, SalesPaied);
                //    #endregion

                //}
                //#endregion
                isSaved = true;
                btnAddNew_Click(null, null);
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PostTransactions(int CustomerCode, DateTime Date, int UserCode, DataGridViewRow[] ProductsCollection, decimal SalesTotal, decimal SalesPaied)
        {
            TransactionHeaderManager header = new TransactionHeaderManager();
            TransactionLineManager lines = new TransactionLineManager();
            PostedTransactionsManager posted = new PostedTransactionsManager();
            string IssueAccount, ConsumptionAccount, RevenueAccount, SalesDiscountAccount, CustomerAccount, CashAccount;
            CustomerPostingManager.GetCustomerPostingAccountsCode(CustomerCode, out CustomerAccount, out CashAccount);

            long TransactionCode = long.Parse(header.GetCode().ToString());

            #region Add Transaction Header Details :
            header.AddHeaderDetails(TransactionCode, 3, Date, "فاتورة مبيعات", UserCode, true);
            #endregion

            for (int i = 0; i < ProductsCollection.Length; i++)
            {
                #region  Variables :

                int PCode = int.Parse(ProductsCollection[i].Cells[0].Value.ToString());
                int UCode = int.Parse(ProductsCollection[i].Cells[2].Value.ToString());
                decimal UPrice = decimal.Parse(ProductsCollection[i].Cells[4].Value.ToString());
                decimal PQty = decimal.Parse(ProductsCollection[i].Cells[5].Value.ToString());
                decimal PQTotal = decimal.Parse(ProductsCollection[i].Cells[6].Value.ToString());
                decimal AvgProductConsumption = (decimal)(OnHandProductManager.GetAvgCost(PCode) * PQty);
                #endregion

                ProductPostingManager.GetSalesPostingAccountsCode(PCode, out IssueAccount, out ConsumptionAccount, out RevenueAccount, out SalesDiscountAccount);

                #region Add Transaction Details :

                #region If Invoice is Cash Or Accrual :

                #region Add Transaction Line Details :
                lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                    CustomerAccount + "-1-" + CustomerCode, PQTotal, null, "من العميل للايرادات",
                    AccountsManager.AccountFilterationTypes.Ledger.ToString(), RevenueAccount);

                lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                    ConsumptionAccount, AvgProductConsumption, null, "من الاستهلاك للمخزون", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                    IssueAccount);
                #endregion

                #region Add Posted Lines Details :
                posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CustomerAccount + "-1-" + CustomerCode, PQTotal, null);

                posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, RevenueAccount, null, PQTotal);

                posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, ConsumptionAccount, AvgProductConsumption, null);

                posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, IssueAccount, null, AvgProductConsumption);
                #endregion

                #endregion

                #endregion 
            }

            #region If Invoice is Cash :
            if (radPaymentSystem.SelectedIndex == 0)
            {
                #region Add Transaction Line Details :
                lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                    CashAccount, SalesTotal, null, "العميل سدد", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                    CustomerAccount + "-1-" + CustomerCode);
                #endregion

                #region Add Posted Lines Details :
                posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CashAccount, SalesTotal, null);
                posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CustomerAccount + "-1-" + CustomerCode, null, SalesTotal);
                #endregion

            }
            #endregion

            #region If Invoice is Accrual :
            else if (radPaymentSystem.SelectedIndex == 1 && SalesPaied > 0)
            {
                #region Add Transaction Line Details :
                lines.AddTransactionLineDetails(TransactionCode, Date, AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                    CashAccount, SalesPaied, null, "العميل سدد", AccountsManager.AccountFilterationTypes.Ledger.ToString(),
                    CustomerAccount + "-1-" + CustomerCode);
                #endregion

                #region Add Posted Lines Details :
                posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CashAccount, SalesPaied, null);
                posted.AddPostedTransactionDetails(TransactionCode, Date, UserCode, CustomerAccount + "-1-" + CustomerCode, null, SalesPaied);
                #endregion

            }
            #endregion

        }
        bool isSaved = false;
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetDefaultPrinter(StringBuilder pszBuffer, ref int size);

        private void btnPrint_Click(object sender, EventArgs e)
        {
        //    if (isSaved==false)
        //    {
        //        return;
        //    }
        //    btnSave_Click(null, null);
        //    StringBuilder dp = new StringBuilder(256);
        //    int size = dp.Capacity;
        //    Reports.SalesInvoice si = new Reports.SalesInvoice();
        //    if (GetDefaultPrinter(dp, ref size))
        //    {
        //        si.PrintOptions.PrinterName = dp.ToString();
        //    }
        //    si.SetParameterValue("@SalesCode", txtInvoiceCode.Text);
        //    si.PrintToPrinter(1, true, 1, 1);
        }

        private void FRM_SalesInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                btnSave_Click(null, null);
            }
            else if (e.KeyCode == Keys.F10)
            {
                btnPrint_Click(null, null);
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            PostTransactions(CustomerCode, Date, UserCode, ProductsCollection, SalesTotal, SalesPaied);
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            
        }
    }
}