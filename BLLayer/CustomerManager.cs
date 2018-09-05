using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Windows.Forms;
using System.Data;
namespace BLLayer
{
    public class CustomerManager:Repository<Customer>
    {
        public enum CustomerDetails
        {
            CustomerCode,
            CustomerName,
            Address,
            City,
            Country,
            Mobile1,
            Mobile2,
            EMail,
            FaceBook,
            Notes,
            CreditLimit,
            CustGroup
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().Customer_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<Customer> SourceData)
        {
            dt.Rows.Clear();
            foreach (Customer customer in SourceData)
            {
                dt.Rows.Add(customer.Customer_Code,
                    customer.Customer_Name,
                    customer.Address,
                    customer.City.City_Name,
                    customer.City.Country.Country_Name,
                    customer.Mobile1,
                    customer.Mobile2,
                    customer.EMail,
                    customer.FaceBook,
                    customer.CreditLimit,
                    customer.CustomerGroup.GroupName,
                    customer.Notes
                    );
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.CustomerCode.ToString(), ArabicCaption = "كود العميل", EnglishCaption = "Customer Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.CustomerName.ToString(), ArabicCaption = "إسم العميل", EnglishCaption = "Customer Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.Address.ToString(), ArabicCaption = "العنوان", EnglishCaption = "Address", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.City.ToString(), ArabicCaption = "المدينة", EnglishCaption = "City", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.Country.ToString(), ArabicCaption = "الدولة", EnglishCaption = "Country", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.Mobile1.ToString(), ArabicCaption = "محمول1", EnglishCaption = "Mobile1", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.Mobile2.ToString(), ArabicCaption = "محمول2", EnglishCaption = "Mobile2", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.EMail.ToString(), ArabicCaption = "الإيميل", EnglishCaption = "EMail", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.FaceBook.ToString(), ArabicCaption = "الفيسبوك", EnglishCaption = "FaceBook", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.CreditLimit.ToString(), ArabicCaption = "الحد الإتمانى", EnglishCaption = "Credit Limit", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.CustGroup.ToString(), ArabicCaption = "مجموعة العملاء", EnglishCaption = "Customer Group", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = CustomerDetails.Notes.ToString(), ArabicCaption = "ملاحظات", EnglishCaption = "Notess", DataType = typeof(string) });
            return headers;
        }


        public static void FillCustomerComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new CustomerManager().CreateTable(), CustomerDetails.CustomerName.ToString(), CustomerDetails.CustomerCode.ToString());
        }


        public static DataTable GetCustomerStatement(string CustomerCode, DateTime? DateFrom, DateTime? DateTo, out decimal CustomerDebit, out decimal CustomerCredit)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("v1", typeof(string));
            dt.Columns.Add("v2", typeof(string));
            dt.Columns.Add("v3", typeof(string));
            dt.Columns.Add("v4", typeof(string));
            PostedTransactionsManager manager = new PostedTransactionsManager();
            IQueryable<PostedTransactions> PostedTransactionsList = manager.GetAll();

            if (!string.IsNullOrEmpty(CustomerCode))
            {
                PostedTransactionsList = manager.GetAll().Where(p => (p.accCode.Contains("-1-" + CustomerCode) || p.accCode == "1-" + CustomerCode));
            }
            if (DateFrom != null && DateTo != null)
            {
                PostedTransactionsList = PostedTransactionsList.Where(p => (p.PostedDate.Value >= DateFrom.Value && p.PostedDate.Value <= DateTo.Value));
            }
            foreach (PostedTransactions item in PostedTransactionsList)
            {
                dt.Rows.Add(item.PostedDate.Value.ToShortDateString(), item.PostedTime, item.DebitAmount, item.CreditAmount);
            }
            CustomerDebit = PostedTransactionsList.Sum(p => p.DebitAmount) == null ? 0 : (decimal)PostedTransactionsList.Sum(p => p.DebitAmount);
            CustomerCredit = PostedTransactionsList.Sum(p => p.CreditAmount) == null ? 0 : (decimal)PostedTransactionsList.Sum(p => p.CreditAmount);
            return dt;
        }
    }
}
