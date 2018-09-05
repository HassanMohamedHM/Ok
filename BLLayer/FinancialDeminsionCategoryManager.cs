using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
namespace BLLayer
{
   public class FinancialDeminsionCategoryManager : Repository<FinancialCategory>
    {
        public enum FinDemCatDetails
        {
            FinDemCatCode,
            FinDemCatName
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().FinCatCode + 1);
            }
            return 1;
        }
        protected sealed override void CreateRows(ref System.Data.DataTable dt, IQueryable<FinancialCategory> SourceData)
        {
            dt.Rows.Clear();
            foreach (FinancialCategory finCat in SourceData)
            {
                dt.Rows.Add(
                    finCat.FinCatCode,
                    finCat.FinCatName
                    );
            }
        }

        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = FinDemCatDetails.FinDemCatCode.ToString(), ArabicCaption = "كود التصنيف", EnglishCaption = "Financial Deminsion Category Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = FinDemCatDetails.FinDemCatName.ToString(), ArabicCaption = " تصنيف البعد المالى", EnglishCaption = "Financial Deminsion Category", DataType = typeof(string) });
            return headers;
        }
    }
}

