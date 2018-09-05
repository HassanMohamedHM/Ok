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
   public class JobManager:Repository<Job>
    {
       public enum JobDetails
       {
           JobCode,
           JobName,
           Notes
       }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().Job_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<Job> SourceData )
        {
            dt.Rows.Clear();
            foreach (Job job in  SourceData)
            {
                dt.Rows.Add(job.Job_Code, job.Job_Name, job.Notes);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = JobDetails.JobCode.ToString(), ArabicCaption = "كود الوظيفة", EnglishCaption = "Job Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = JobDetails.JobName.ToString(), ArabicCaption = "إسم الوظيفة", EnglishCaption = "Job Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = JobDetails.Notes.ToString(), ArabicCaption = "ملاحظات", EnglishCaption = "Notes", DataType = typeof(string) });
            return headers;
        }
        public static void FillJobComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new JobManager().CreateTable(), JobDetails.JobName.ToString(), JobDetails.JobCode.ToString());
        }
    }
}
