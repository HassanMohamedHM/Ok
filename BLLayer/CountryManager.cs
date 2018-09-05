using System.Collections.Generic;
using System.Linq;
using DALLayer;
using System.Data;
using System.Windows.Forms;
namespace BLLayer
{
    public class CountryManager : Repository<Country>
    {
        public enum CountryDetails
        {
            CountryCode,
            CountryName
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().Country_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<Country> SourceData)
        {
            dt.Rows.Clear();
            foreach (Country country in  SourceData)
            {
                dt.Rows.Add(country.Country_Code, country.Country_Name);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = CountryDetails.CountryCode.ToString(), ArabicCaption = "كود الدولة", EnglishCaption = "Country Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = CountryDetails.CountryName.ToString(), ArabicCaption = "إسم الدولة", EnglishCaption = "Country Name", DataType = typeof(string) });
            return headers;
        }
        public static void FillCountryComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new CountryManager().CreateTable(), CountryDetails.CountryName.ToString(), CountryDetails.CountryCode.ToString());
        }
    }
}
