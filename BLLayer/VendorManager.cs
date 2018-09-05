using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
using System.Windows.Forms;
namespace BLLayer
{
    public class VendorManager : Repository<Vendor>
    {
        public enum VendorDetails
        {
            VendorCode,
            VendorName,
            Address,
            City,
            Country,
            Mobile1,
            Mobile2,
            EMail,
            VendorGroup,
            Notes
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().Vendor_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<Vendor> SourceData)
        {
            dt.Rows.Clear();
            foreach (Vendor vendor in SourceData)
            {
                dt.Rows.Add(vendor.Vendor_Code,
                    vendor.Vendor_Name,
                    vendor.Address,
                    vendor.City.City_Name,
                    vendor.City.Country.Country_Name,
                    vendor.Mobile1,
                    vendor.Mobile2,
                    vendor.EMail,
                    vendor.VendorGroup.GroupName,
                    vendor.Notes
                    );
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = VendorDetails.VendorCode.ToString(), ArabicCaption = "كود المورد", EnglishCaption = "Vendor Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = VendorDetails.VendorName.ToString(), ArabicCaption = "إسم المورد", EnglishCaption = "Vendor Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = VendorDetails.Address.ToString(), ArabicCaption = "العنوان", EnglishCaption = "Address", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = VendorDetails.City.ToString(), ArabicCaption = "المدينة", EnglishCaption = "City", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = VendorDetails.Country.ToString(), ArabicCaption = "الدولة", EnglishCaption = "Country", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = VendorDetails.Mobile1.ToString(), ArabicCaption = "محمول1", EnglishCaption = "Mobile1", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = VendorDetails.Mobile2.ToString(), ArabicCaption = "محمول2", EnglishCaption = "Mobile2", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = VendorDetails.EMail.ToString(), ArabicCaption = "الإيميل", EnglishCaption = "EMail", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = VendorDetails.VendorGroup.ToString(), ArabicCaption = "مجموعة الموردين", EnglishCaption = "Vendor Group", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = VendorDetails.Notes.ToString(), ArabicCaption = "ملاحظات", EnglishCaption = "Notess", DataType = typeof(string) });
            return headers;
        }
        public static void FillVendorComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new VendorManager().CreateTable(), VendorDetails.VendorName.ToString(), VendorDetails.VendorCode.ToString());
        }


        public static DataTable GetVendorStatement(string VendorCode, DateTime? DateFrom, DateTime? DateTo,out decimal VendorDebit,out decimal VendorCredit)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("v1", typeof(string));
            dt.Columns.Add("v2", typeof(string));
            dt.Columns.Add("v3", typeof(string));
            dt.Columns.Add("v4", typeof(string));
            PostedTransactionsManager manager = new PostedTransactionsManager();
            IQueryable<PostedTransactions> PostedTransactionsList = manager.GetAll();

            if (!string.IsNullOrEmpty(VendorCode))
            {
                PostedTransactionsList = manager.GetAll().Where(p =>( p.accCode.Contains("-2-" + VendorCode)||p.accCode=="2-"+VendorCode));
            }
            if (DateFrom != null && DateTo != null)
            {
                PostedTransactionsList = PostedTransactionsList.Where(p => (p.PostedDate.Value >= DateFrom.Value && p.PostedDate.Value <= DateTo.Value));
            }
            foreach (PostedTransactions item in PostedTransactionsList)
            {
                dt.Rows.Add(item.PostedDate.Value.ToShortDateString(), item.PostedTime, item.DebitAmount, item.CreditAmount);
            }
            VendorDebit = PostedTransactionsList.Sum(p => p.DebitAmount) == null ? 0 : (decimal)PostedTransactionsList.Sum(p => p.DebitAmount);
            VendorCredit = PostedTransactionsList.Sum(p => p.CreditAmount) == null ? 0 : (decimal)PostedTransactionsList.Sum(p => p.CreditAmount);
            return dt;
        }
    }
}
