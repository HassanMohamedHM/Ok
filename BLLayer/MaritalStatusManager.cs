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
   public class MaritalStatusManager:Repository<MaritalStatus>
    {
       public enum MaritalStatusDetails
       {
           MaritalStatusCode,
           MaritalStatusName
       }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().MaritalStatusCode + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<MaritalStatus> SourceData)
        {
            dt.Rows.Clear();
            foreach (MaritalStatus status in  SourceData)
            {
                dt.Rows.Add(status.MaritalStatusCode, status.MaritalStatusName);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = MaritalStatusDetails.MaritalStatusCode.ToString(), ArabicCaption = "كود الحالة الإجتماعية", EnglishCaption = "Marital Status Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = MaritalStatusDetails.MaritalStatusName.ToString(), ArabicCaption = "إسم الحالة الإجتماعية", EnglishCaption = "Marital Status Name", DataType = typeof(string) });
            return headers;
        }
        public static void FillMaritalStatusCodeComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new MaritalStatusManager().CreateTable(), MaritalStatusDetails.MaritalStatusName.ToString(), MaritalStatusDetails.MaritalStatusCode.ToString());
        }
    }
}
