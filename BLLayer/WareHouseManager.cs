using System.Collections.Generic;
using System.Linq;
using DALLayer;
using System.Windows.Forms;
using System.Data;
namespace BLLayer
{
    public class WareHouseManager : Repository<WareHouse>
    {
        public enum WareHouseType
        {
        }
        public enum WareHouseDetails
        {
            WareHouseCode,
            WareHouseName,
            SiteName,
            WareHouseType,
            WareHouse_Manager,
            Notes
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().WareHouse_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<WareHouse> SourceData)
        {
            dt.Rows.Clear();
            foreach (WareHouse warehouse in SourceData)
            {
                dt.Rows.Add(warehouse.WareHouse_Code,
                    warehouse.WareHouse_Name,
                    warehouse.Site.Site_Name,
                    warehouse.WareHouse_Type,
                    warehouse.Employee.Employee_Name,
                    warehouse.Notes);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = WareHouseDetails.WareHouseCode.ToString(), ArabicCaption = "كود المخزن", EnglishCaption = "WareHouse Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = WareHouseDetails.WareHouseName.ToString(), ArabicCaption = "إسم المخزن", EnglishCaption = "WareHouse Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = WareHouseDetails.SiteName.ToString(), ArabicCaption = "إسم الفرع", EnglishCaption = "Site Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = WareHouseDetails.WareHouseType.ToString(), ArabicCaption = "نوع المخزن", EnglishCaption = "WareHouse Type", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = WareHouseDetails.WareHouse_Manager.ToString(), ArabicCaption = "مدير المخزن", EnglishCaption = "WareHouse Manager", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = WareHouseDetails.Notes.ToString(), ArabicCaption = "ملاحظات", EnglishCaption = "Notes", DataType = typeof(string) });
            return headers;
        }
        public static void FillWareHouseComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new WareHouseManager().CreateTable(), WareHouseDetails.WareHouseName.ToString(), WareHouseDetails.WareHouseCode.ToString());
        }
    }
}

