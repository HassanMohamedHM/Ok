using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
namespace BLLayer
{
    public class PurchaseManager:Repository<PurchaseHeader>,IInvoiceManager
    {
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Count + 1).ToString() + DateTime.Now.ToLongTimeString();
            }
            return "1" + DateTime.Now.ToLongTimeString();
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<PurchaseHeader> SourceData)
        {
            //dt.Rows.Clear();
            //foreach (PurchaseHeader purchaseheader in SourceData)
            //{
            //    dt.Rows.Add(purchaseheader.Product_Code,
            //        purchaseheader.Product_Name,
            //        purchaseheader.ProductDesc,
            //        purchaseheader.SearchName,
            //        purchaseheader.ProductType,
            //        purchaseheader.Product_Inventory.Sum(p => p.Qty));
            //}
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            //headers.Add(new TableHeader() { ColumnName = ProductDetails.ProductCode.ToString(), ArabicCaption = "كود المُنتج", EnglishCaption = "Product Code", DataType = typeof(int) });
            //headers.Add(new TableHeader() { ColumnName = ProductDetails.ProductName.ToString(), ArabicCaption = "إسم المُنتج", EnglishCaption = "Product Name", DataType = typeof(string) });
            //headers.Add(new TableHeader() { ColumnName = ProductDetails.ProductDesc.ToString(), ArabicCaption = "وصف المُنتج", EnglishCaption = "Product Description", DataType = typeof(string) });
            //headers.Add(new TableHeader() { ColumnName = ProductDetails.SearchName.ToString(), ArabicCaption = "إسم البحث", EnglishCaption = "Search Name", DataType = typeof(string) });
            //headers.Add(new TableHeader() { ColumnName = ProductDetails.ProductType.ToString(), ArabicCaption = "نوع المُنتج", EnglishCaption = "Product Type", DataType = typeof(string) });
            //headers.Add(new TableHeader() { ColumnName = ProductDetails.Quantity.ToString(), ArabicCaption = "الكمية فى المخازن", EnglishCaption = "Quantity in Stores", DataType = typeof(decimal) });
            return headers;
        }

        public void AddInvoiceHeader(string InvoiceCode, DateTime InvoiceDateTime, decimal Total, decimal Paied, 
            decimal Reminder, bool InvoiceType, int WareHouseCode, int VendorCode, bool PaymentSystem, int UserCode)
        {
            Add(new PurchaseHeader()
            {
                Purchase_Code = InvoiceCode,
                Purchase_Date = InvoiceDateTime.Date,
                Purchase_Time = InvoiceDateTime.TimeOfDay,
                Purchase_Total = Total,
                Purchase_Paied = Paied,
                Purchase_Reminder = Reminder,
                Type_Code = InvoiceType,
                Inventory_Code = WareHouseCode,
                Vendor_Code = VendorCode,
                PaymentSystem = PaymentSystem,
                User_Code = UserCode
            });
        }

        public void AddInvoiceDetails(string InvoiceCode, int ProductCode, int UnitCode, double UnitPrice, decimal Qty, decimal Total)
        {
            new PurchaseDetailsManager().Add(new PurchaseDetails()
            {
                Purchase_Code = InvoiceCode,
                Product_Code = ProductCode,
                Unit_Code = UnitCode,
                Unit_Price = UnitPrice,
                Qty = Qty,
                Total = Total
            });
        }
    }
}
