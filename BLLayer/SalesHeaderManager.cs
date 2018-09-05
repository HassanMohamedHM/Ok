using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
namespace BLLayer
{
    public class SalesHeaderManager : Repository<SalesHeader>, IInvoiceManager
   {
       public enum SalesHeaderDetails
       {
           InvoiceCode,
           InvoiceDate,
           InvoiceTime,
           InvoiceTotal,
           InvoicePaied,
           InvoiceReminder,
           WareHouseName,
           CustomerName,
           Employee_Name,
           PaymentSystem
       }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Count + 1).ToString() + DateTime.Now.ToLongTimeString();
            }
            return "1" + DateTime.Now.ToLongTimeString();
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<SalesHeader> SourceData)
        {
            dt.Rows.Clear();
            foreach (SalesHeader sales in SourceData)
            {
                dt.Rows.Add(sales.Sales_Code,
                    (sales.Sales_Date).Value.ToShortDateString(),
                    sales.Sales_Time,
                    sales.Sales_Total,
                    sales.Sales_Paied,
                    sales.Sales_Reminder,
                    sales.WareHouse.WareHouse_Name,
                    sales.Customer.Customer_Name,
                    sales.User.Employee.Employee_Name,
                    sales.PaymentSystem == false ? "كاش" : "أجل");
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = SalesHeaderDetails.InvoiceCode.ToString(), ArabicCaption = "كود الفاتورة", EnglishCaption = "Invoice Code", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = SalesHeaderDetails.InvoiceDate.ToString(), ArabicCaption = "تاريخ الفاتورة", EnglishCaption = "Invoice Date", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = SalesHeaderDetails.InvoiceTime.ToString(), ArabicCaption = "وقت الفاتورة", EnglishCaption = "Invoice Time", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = SalesHeaderDetails.InvoiceTotal.ToString(), ArabicCaption = "الإجمالى", EnglishCaption = "Total", DataType = typeof(decimal) });
            headers.Add(new TableHeader() { ColumnName = SalesHeaderDetails.InvoicePaied.ToString(), ArabicCaption = "المدفوع", EnglishCaption = "Paied", DataType = typeof(decimal) });
            headers.Add(new TableHeader() { ColumnName = SalesHeaderDetails.InvoiceReminder.ToString(), ArabicCaption = "الباقى", EnglishCaption = "Reminder", DataType = typeof(decimal) });
            headers.Add(new TableHeader() { ColumnName = SalesHeaderDetails.WareHouseName.ToString(), ArabicCaption = "المخزن", EnglishCaption = "WareHouse", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = SalesHeaderDetails.CustomerName.ToString(), ArabicCaption = "العميل", EnglishCaption = "Customer", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = SalesHeaderDetails.Employee_Name.ToString(), ArabicCaption = "البائع", EnglishCaption = "Employer", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = SalesHeaderDetails.PaymentSystem.ToString(), ArabicCaption = "نظام الدفع", EnglishCaption = "Payment System", DataType = typeof(string) });
            return headers;
        }
        public DataTable GetSalesInvoices()
        {
            DataTable dt = CreateTable().Copy();
            CreateRows(ref dt, GetAll().Where(s => s.Type_Code == false));
            return dt;
        }
        public DataTable GetCashSalesInvoices()
        {

            DataTable dt = CreateTable().Copy();

            CreateRows(ref dt, GetAll().Where(s => s.PaymentSystem == false && s.Type_Code == false));
            return dt;
        }

        public  DataTable GetAccrualSalesInvoices()
        {
            DataTable dt = CreateTable().Copy();
            CreateRows(ref dt, GetAll().Where(s => s.PaymentSystem == true && s.Type_Code == false));
            return dt;
        }

        public DataTable GetSpecifiedSalesInvoices(DateTime From, DateTime To)
        {
            DataTable dt = CreateTable().Copy();
            CreateRows(ref dt, GetAll().Where(s => s.Type_Code == false && (s.Sales_Date >= From && s.Sales_Date <= To)));
            return dt;
        }









        public void AddInvoiceHeader(string InvoiceCode, DateTime InvoiceDateTime, decimal Total, decimal Paied,
            decimal Reminder, bool InvoiceType, int WareHouseCode, int CustomerCode, bool PaymentSystem, int UserCode)
        {
            Add(new SalesHeader()
            {
                Sales_Code = InvoiceCode,
                Sales_Date = InvoiceDateTime.Date,
                Sales_Time = InvoiceDateTime.TimeOfDay,
                Sales_Total = Total,
                Sales_Paied = Paied,
                Sales_Reminder = Reminder,
                Type_Code = InvoiceType,
                Inventory_Code = WareHouseCode,
                Customer_Code = CustomerCode,
                PaymentSystem = PaymentSystem,
                User_Code = UserCode
            });
        }

        public void AddInvoiceDetails(string InvoiceCode, int ProductCode, int UnitCode, double UnitPrice, decimal Qty, decimal Total)
        {
            new SalesDetailsManager().Add(new SalesDetails
            {
                Sales_Code = InvoiceCode,
                Product_Code = ProductCode,
                Unit_Code = UnitCode,
                Unit_Price = UnitPrice,
                Qty = Qty,
                Total = Total
            });
        }
   }
}
