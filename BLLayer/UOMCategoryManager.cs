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
    public class UOMCategoryManager:Repository<UOMCCategory>
    {
        public enum UnitCategoryDetails
        {
            CatCode,
            Category
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().CatCode + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<UOMCCategory> SourceData)
        {
            dt.Rows.Clear();
            foreach (UOMCCategory cat in SourceData)
            {
                dt.Rows.Add(cat.CatCode, cat.CatName);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = UnitCategoryDetails.CatCode.ToString(), ArabicCaption = "كود التصنيف", EnglishCaption = "Category Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = UnitCategoryDetails.Category.ToString(), ArabicCaption = "التصنيف", EnglishCaption = "Category", DataType = typeof(string) });
            return headers;
        }
        public static void FillUnitCategoryComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new UOMCategoryManager().CreateTable(), UnitCategoryDetails.Category.ToString(), UnitCategoryDetails.CatCode.ToString());
        }
    }
}
