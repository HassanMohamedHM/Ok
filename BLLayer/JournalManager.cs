using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
using System.Windows.Forms;
using System.Threading;
namespace BLLayer
{
   public class JournalManager:Repository<JournalNames>
    {

        public enum JournalDetails
        {
            JournalCode,
            JournalName
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().JournalCode + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<JournalNames> SourceData)
        {
            dt.Rows.Clear();
            foreach (JournalNames journal in SourceData)
            {
                dt.Rows.Add(journal.JournalCode, journal.JournalName);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = JournalDetails.JournalCode.ToString(), ArabicCaption = "كود اليومية", EnglishCaption = "Journal Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = JournalDetails.JournalName.ToString(), ArabicCaption = "إسم اليومية", EnglishCaption = "Journal Name", DataType = typeof(string) });
            return headers;
        }
        public static void FillJournalComboBox(ComboBox ComboBoxName,bool type)
        {
            //JournalManager journal = new JournalManager();
            //DataTable dt = journal.CreateTable(); ;
            //journal.CreateRows(ref dt, journal.GetAll().Where(j => j.JournalType == type));
            //FillCombox(ComboBoxName,dt, JournalDetails.JournalName.ToString(), JournalDetails.JournalCode.ToString());
        }
    }
}
