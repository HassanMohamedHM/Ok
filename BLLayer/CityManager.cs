using System.Collections.Generic;
using System.Linq;
using DALLayer;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity;
namespace BLLayer
{
    public class CityManager : Repository<City>
    {
        public enum CityDetails
        {
            CityCode,
            CityName,
            CountryName
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().City_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<City> SourceData)
        {
            dt.Rows.Clear();
            foreach (City city in SourceData)
            {
                dt.Rows.Add(city.City_Code,city.City_Name,city.Country.Country_Name);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = CityDetails.CityCode.ToString(), ArabicCaption = "كود المدينة", EnglishCaption = "City Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = CityDetails.CityName.ToString(), ArabicCaption = "إسم المدينة", EnglishCaption = "City Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = CityDetails.CountryName.ToString(), ArabicCaption = "إسم الدولة", EnglishCaption = "Country Name", DataType = typeof(string) });
            return headers;
        }
        public static void FillCityComboBox(ComboBox ComboBoxName, int CountryCode)
        {
            CityManager city = new CityManager();
            DataTable dt = city.CreateTable();;
            city.CreateRows(ref dt, city.GetAll().Where(c => c.Country_Code == CountryCode));
            FillCombox(ComboBoxName, dt, CityDetails.CityName.ToString(), CityDetails.CityCode.ToString());
        }
    }
}
