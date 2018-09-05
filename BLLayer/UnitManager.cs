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
    public class UnitManager : Repository<Unit>
    {
        public enum UnitDetails
        {
            UnitCode,
            UnitName,
            catCode,
            category
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().Unit_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<Unit> SourceData)
        {
            dt.Rows.Clear();
            foreach (Unit unit in SourceData)
            {
                dt.Rows.Add(unit.Unit_Code, unit.Unit_Name,unit.CatCode,unit.UOMCCategory.CatName);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = UnitDetails.UnitCode.ToString(), ArabicCaption = "كود الوحدة", EnglishCaption = "Unit Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = UnitDetails.UnitName.ToString(), ArabicCaption = "إسم الوحدة", EnglishCaption = "Unit Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = UnitDetails.catCode.ToString(), ArabicCaption = "كود التصنيف", EnglishCaption = "Category Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = UnitDetails.category.ToString(), ArabicCaption = "التصنيف", EnglishCaption = "Category", DataType = typeof(string) });
            return headers;
        }
        public static void FillUnitComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new UnitManager().CreateTable(), UnitDetails.UnitName.ToString(), UnitDetails.UnitCode.ToString());
        }
    }
}
