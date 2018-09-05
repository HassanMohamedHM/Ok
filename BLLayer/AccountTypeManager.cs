using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
namespace BLLayer
{
    public class AccountTypeManager:Repository<AccountType>
    {
        public enum accTypeDetails
        {
            typeCode,
            typeName
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<AccountType> SourceData)
        {
            dt.Rows.Clear();
            foreach (AccountType type in SourceData)
            {
                dt.Rows.Add(type.typeCode, type.typeName);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = accTypeDetails.typeCode.ToString(), ArabicCaption = "كود النوع", EnglishCaption = "Type Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = accTypeDetails.typeName.ToString(), ArabicCaption = "نوع الحساب", EnglishCaption = "Type Name", DataType = typeof(string) });
            return headers;
        }
        
    }
}
