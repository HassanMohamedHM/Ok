using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
namespace BLLayer
{
   public class FinancialDeminsionManager:Repository<FinancialDeminsions>
    {
       public enum FinDemDetails
       {
           FinDemCode,
           FinDemName,
           accCode,
           accName
       }
       public override object GetCode()
       {
           if (GetAll().Count() > 0)
           {
               return (GetAll().ToList().Last().FinDemCode + 1);
           }
           return 1;
       }
        protected sealed override void CreateRows(ref System.Data.DataTable dt, IQueryable<FinancialDeminsions> SourceData)
        {
            dt.Rows.Clear();
            foreach (FinancialDeminsions findem in SourceData)
            {
                dt.Rows.Add(
                    findem.FinDemCode,
                    findem.FinDemName
                    );
            }
        }

        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = FinDemDetails.FinDemCode.ToString(), ArabicCaption = "كود البعد المالى", EnglishCaption = "Financial Deminsion Code", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = FinDemDetails.FinDemName.ToString(), ArabicCaption = "البعد المالى", EnglishCaption = "Financial Deminsion", DataType = typeof(string) });
            return headers;
        }
    }
}
