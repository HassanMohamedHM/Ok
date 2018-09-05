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

namespace UILayer.Invoices
{
    public partial class FRM_Sales : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SalesHeaderManager sales = new SalesHeaderManager();
        public FRM_Sales()
        {
            InitializeComponent();
            btnAllSalesInvoices_ItemClick(null, null);
        }

        private void btnAllSalesInvoices_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FillGrid(sales.CreateTable());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FillGrid(DataTable Source)
        {
            SalesGrid.DataSource = null;
            SalesView.Columns.Clear();
            SalesGrid.DataSource =Source ;
        }

        private void btnCashSalesInvoices_ItemClick(object sender, ItemClickEventArgs e)
        {
            FillGrid(sales.GetCashSalesInvoices());
        }

        private void btnAccrualSalesInvoices_ItemClick(object sender, ItemClickEventArgs e)
        {
            FillGrid(sales.GetAccrualSalesInvoices());
        }

        private void btnDisplaySpecifiedSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (FromItem.EditValue == null || ToItem.EditValue == null)
            {
                MessageBox.Show("You Must Choose All Dates" ,"Stop",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            FillGrid(sales.GetSpecifiedSalesInvoices(DateTime.Parse(FromItem.EditValue.ToString()), DateTime.Parse(ToItem.EditValue.ToString())));
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            SalesView.ShowPrintPreview();
        }
    }
}