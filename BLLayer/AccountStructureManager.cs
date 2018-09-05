using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
namespace BLLayer
{
   public class AccountStructureManager:Repository<AccountStructure>
    {
        public enum AccountStructureDetails
        {
            StructureCode,
            StructureName
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().StructureCode + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref System.Data.DataTable dt, IQueryable<AccountStructure> SourceData)
        {
            dt.Rows.Clear();
            foreach (AccountStructure acc in SourceData)
            {
                dt.Rows.Add(
                    acc.StructureCode,
                    acc.StructureName
                    );
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = AccountStructureDetails.StructureCode.ToString(), ArabicCaption = "الكود", EnglishCaption = "Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = AccountStructureDetails.StructureName.ToString(), ArabicCaption = "إسم الحساب", EnglishCaption = "Account Structure Name", DataType = typeof(string) });
            return headers;
        }
    }
}
