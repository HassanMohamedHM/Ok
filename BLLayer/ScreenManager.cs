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
    public class ScreenManager:Repository<DALLayer.Screen>
    {
        public enum ScreenDetails
        {
            ScreenCode,
            ScreenName
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().Screen_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<DALLayer.Screen> SourceData)
        {
            dt.Rows.Clear();
            foreach (DALLayer.Screen screen in SourceData)
            {
                dt.Rows.Add(screen.Screen_Code, screen.Screen_Name);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = ScreenDetails.ScreenCode.ToString(), ArabicCaption = "كود الشاشة", EnglishCaption = "Screen Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = ScreenDetails.ScreenName.ToString(), ArabicCaption = "إسم الشاشة", EnglishCaption = "Screen Name", DataType = typeof(string) });
            return headers;
        }
        public static void FillScreenComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new ScreenManager().CreateTable(), ScreenDetails.ScreenName.ToString(), ScreenDetails.ScreenCode.ToString());
        }
    }
}
