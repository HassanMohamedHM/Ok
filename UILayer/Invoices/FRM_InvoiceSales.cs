using System;
using System.Data;
using System.Windows.Forms;
using DALLayer;
using BLLayer;
using System.Globalization;
namespace UILayer.Invoices
{
    public partial class FRM_InvoiceSales : DevExpress.XtraEditors.XtraForm
    {
        #region Methods :
         private DataTable SourceTable(DataTable SourceData)
        {
            DataTable dt = SourceData.Copy();
            for (int i = 2; i < dt.Columns.Count; )
            {

                dt.Columns.RemoveAt(i);
            }
            return dt;
        }

         private void ControlKeyDown(object sender, KeyEventArgs e)
         {
             try
             {
                 if (e.KeyCode == Keys.Enter)
                 {
                     if (sender == SearchProduct && SearchProduct.EditValue != null)
                     {
                         spLength.Focus();
                     }
                     else if (sender == spPrice)
                     {
                         spLength.Focus();
                     }
                     else if (sender == spLength)
                     {
                         spWidth.Focus();
                     }
                     else if (sender == spWidth)
                     {
                         spQuantity.Focus();
                     }
                     else if (sender == spQuantity)
                     {
                         spDiscount.Value = (spPrice.Value * spLength.Value * spWidth.Value * spQuantity.Value) - (int)(spPrice.Value * spLength.Value * spWidth.Value * spQuantity.Value);
                         spDiscount.Focus();
                     }
                     else if (sender == spDiscount)
                     {
                         ProductView.AddNewRow();
                         SearchProduct.EditValue = null;
                         SearchProduct.Focus();
                     }
                 }
                 else if (e.KeyCode==Keys.Delete)
                 {
                     if (sender == ProductView)
                     {
                         if (ProductView.RowCount>0)
                         {
                             SpInvoiceDiscount.Value = SpInvoiceDiscount.Value - decimal.Parse(ProductView.GetRowCellValue(ProductView.FocusedRowHandle, ProductView.Columns[9]).ToString());
                             spInvoiceTotal.Value = spInvoiceTotal.Value - decimal.Parse(ProductView.GetRowCellValue(ProductView.FocusedRowHandle, ProductView.Columns[10]).ToString());
                             ProductView.DeleteRow(ProductView.FocusedRowHandle);
                             SearchProduct.Focus(); 
                         }
                     }
                 }
             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }
            
         }
        #endregion
        public FRM_InvoiceSales()
        {
            InitializeComponent();
        }
       
        private void FRM_InvoiceSales_Load(object sender, EventArgs e)
        {
            try
            {
                #region Fill Mandatory Data :

                HelperClass.FillSearchLookUpByData(SearchWareHouse, SourceTable(new WareHouseManager().CreateTable()),
                     WareHouseManager.WareHouseDetails.WareHouseName.ToString(),
                     WareHouseManager.WareHouseDetails.WareHouseCode.ToString());
                //SearchWareHouse.EditValue = 1;
                SearchWareHouse.Properties.View.SelectRow(0);
                HelperClass.FillSearchLookUpByData(SearchCustomer, SourceTable(new CustomerManager().CreateTable()),
                    CustomerManager.CustomerDetails.CustomerName.ToString(),
                    CustomerManager.CustomerDetails.CustomerCode.ToString());
                //SearchCustomer.EditValue = 1;

                HelperClass.FillSearchLookUpByData(SearchProduct, new ProductManager().CreateTable(),
                    ProductManager.ProductDetails.ProductName.ToString(),
                    ProductManager.ProductDetails.ProductCode.ToString());

                HelperClass.FillSearchLookUpByData(searchUnit, SourceTable(new UnitManager().CreateTable()),
                    UnitManager.UnitDetails.UnitName.ToString(),
                    UnitManager.UnitDetails.UnitCode.ToString());
                #endregion
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
        private void radPaymentSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            spInvoicePaied.Enabled = radPaymentSystem.SelectedIndex == 1 ? true : false;
            //Cash
            if (radPaymentSystem.SelectedIndex == 0)
            {

                spInvoicePaied.Value = spInvoiceTotal.Value;
            }
            //Accrual
            else
            {
                spInvoicePaied.Value = 0;
            }
            InvoiceTotal_Paied_Reminder(null, null);
        }
        private void InvoiceTotal_Paied_Reminder(object sender, EventArgs e)
        {
            if (spInvoicePaied.Value >= 0  )
            {
                if (radPaymentSystem.SelectedIndex == 1)
                {
                    spInvoiceReminder.Value = spInvoiceTotal.Value - spInvoicePaied.Value;
                }
                else
                {
                    spInvoicePaied.Value = spInvoiceTotal.Value;
                }
               
            }


        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                SearchProduct.Focus();
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn { ColumnName = "v1", DataType = typeof(string) });//PCode
                dt.Columns.Add(new DataColumn { ColumnName = "v2", DataType = typeof(string) });//PName
                dt.Columns.Add(new DataColumn { ColumnName = "v3", DataType = typeof(string) });//UCode
                dt.Columns.Add(new DataColumn { ColumnName = "v4", DataType = typeof(string) });//UName
                dt.Columns.Add(new DataColumn { ColumnName = "v5", DataType = typeof(string) });//Price
                dt.Columns.Add(new DataColumn { ColumnName = "v6", DataType = typeof(string) });//Length
                dt.Columns.Add(new DataColumn { ColumnName = "v7", DataType = typeof(string) });//Width
                dt.Columns.Add(new DataColumn { ColumnName = "v8", DataType = typeof(string) });//Quantity
                dt.Columns.Add(new DataColumn { ColumnName = "v9", DataType = typeof(string) });//Total Quantity
                dt.Columns.Add(new DataColumn { ColumnName = "v10", DataType = typeof(string) });//Discount
                dt.Columns.Add(new DataColumn { ColumnName = "v11", DataType = typeof(string) });//Line Total
                ProductGrid.DataSource = dt;
                ProductGrid.DataMember = dt.TableName;
                SpInvoiceDiscount.Value = spInvoiceTotal.Value = spInvoicePaied.Value = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void SearchProduct_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (SearchProduct.EditValue != null)
                {
                    Product pr = new ProductManager().Get(int.Parse(SearchProduct.EditValue.ToString()));
                    searchUnit.EditValue = pr.Unit.Unit_Code;
                    spPrice.Value = (decimal)pr.DefPurchasePrice;
                    spLength.Focus();
                }
                else
                {
                    searchUnit.EditValue = null;
                    spPrice.Value = spLength.Value = spWidth.Value = spDiscount.Value = 0;
                    spQuantity.Value = 1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ProductView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                ProductView.SetRowCellValue(e.RowHandle, ProductView.Columns[0], SearchProduct.EditValue);
                ProductView.SetRowCellValue(e.RowHandle, ProductView.Columns[1], SearchProduct.Text);
                ProductView.SetRowCellValue(e.RowHandle, ProductView.Columns[2], searchUnit.EditValue);
                ProductView.SetRowCellValue(e.RowHandle, ProductView.Columns[3], searchUnit.Text);
                ProductView.SetRowCellValue(e.RowHandle, ProductView.Columns[4], spPrice.EditValue);
                ProductView.SetRowCellValue(e.RowHandle, ProductView.Columns[5], spLength.EditValue);
                ProductView.SetRowCellValue(e.RowHandle, ProductView.Columns[6], spWidth.EditValue);
                ProductView.SetRowCellValue(e.RowHandle, ProductView.Columns[7], spQuantity.EditValue);
                //
                decimal TotalQuantity = (spLength.Value * spWidth.Value * spQuantity.Value);
                ProductView.SetRowCellValue(e.RowHandle, ProductView.Columns[8], TotalQuantity);
                //
                ProductView.SetRowCellValue(e.RowHandle, ProductView.Columns[9], spDiscount.Value);
                //
                decimal TotalLine = (spPrice.Value * TotalQuantity) - spDiscount.Value;
                ProductView.SetRowCellValue(e.RowHandle, ProductView.Columns[10], TotalLine);

                spInvoiceTotal.Value = spInvoicePaied.Value = spInvoiceTotal.Value + TotalLine;

                SpInvoiceDiscount.Value = SpInvoiceDiscount.Value + spDiscount.Value;

                 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

       

    }
}