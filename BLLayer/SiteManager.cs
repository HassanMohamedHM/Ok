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
    public class SiteManager : Repository<Site>
    {
        public enum SiteDetails
        {
            SiteCode,
            SiteName,
            SiteAddress,
            CityName,
            CountryName,
            SiteType,
            Notes
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().Site_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<Site> SourceData)
        {
            dt.Rows.Clear();
            foreach (Site site in SourceData)
            {
                dt.Rows.Add(site.Site_Code,
                    site.Site_Name,
                    site.Address,
                    site.City.City_Name,
                    site.City.Country.Country_Name,
                    site.Site_Type,
                    site.Notes);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = SiteDetails.SiteCode.ToString(), ArabicCaption = "كود الفرع", EnglishCaption = "Branch Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = SiteDetails.SiteName.ToString(), ArabicCaption = "إسم الفرع", EnglishCaption = "Branch Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = SiteDetails.SiteAddress.ToString(), ArabicCaption = "عنوان الفرع", EnglishCaption = "Branch Address", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = SiteDetails.CityName.ToString(), ArabicCaption = "المدينة", EnglishCaption = "City Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = SiteDetails.CountryName.ToString(), ArabicCaption = "الدولة", EnglishCaption = "Country Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = SiteDetails.SiteType.ToString(), ArabicCaption = "نوع الفرع", EnglishCaption = "Site Type", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = SiteDetails.Notes.ToString(), ArabicCaption = "ملاحظات", EnglishCaption = "Notes", DataType = typeof(string) });
            return headers;
        }
        public static void FillSiteComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new SiteManager().CreateTable(), SiteDetails.SiteName.ToString(), SiteDetails.SiteCode.ToString());
        }
    }
}
