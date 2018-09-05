using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
namespace BLLayer
{
    public class TransactionLineManager:Repository<TransactionLines>
    {
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().LineCode + 1).ToString();
            }
            return "1";
        }
        protected override void CreateRows(ref System.Data.DataTable dt, IQueryable<TransactionLines> SourceData)
        {
            throw new NotImplementedException();
        }

        protected override List<TableHeader> SetHeaders()
        {
            throw new NotImplementedException();
        }

        public long AddTransactionLineDetails(long TransactionCode, DateTime LineDate, string MainType, string AccountCode,
            decimal? DebitAmount, decimal? CreditAmount, string Discription, string OffsetMainType, string OffsetAccountCode)
        {
            long LineCode=long.Parse(GetCode().ToString());
            Add(new TransactionLines()
            {
                LineCode=LineCode,
                transCode = TransactionCode,
                LineDate = LineDate.Date,
                MainType = MainType,
                accCode = AccountCode,
                DebitAmount = DebitAmount,
                CreditAmount = CreditAmount,
                Discription = Discription,
                offsetMainType = OffsetMainType,
                offsetAccCode = OffsetAccountCode
            });
            return LineCode;
        }


        public void MakeFirstTable(long TransCode)
        {
            DataTable table = new DataTable(tablename);
            table.Columns.Add("v1", typeof(int));
            table.Columns.Add("v2", typeof(long));
            table.Columns.Add("v3", typeof(DateTime));
            table.Columns.Add("v4", typeof(string));
            table.Columns.Add("v5", typeof(string));
            table.Columns.Add("v6", typeof(string));
            table.Columns.Add("v7", typeof(string));
            table.Columns.Add("v8", typeof(string));
            table.Columns.Add("v9", typeof(string));
            table.Columns.Add("v10", typeof(string));
            foreach (TransactionLines item in GetAll().Where(line => line.transCode == TransCode))
            {
                table.Rows.Add(item.LineCode, item.transCode, item.LineDate.Value, item.MainType, item.accCode,
                    item.DebitAmount, item.CreditAmount, item.Discription, item.offsetMainType, item.offsetAccCode);
            }
            DataSet = new System.Data.DataSet();
            DataSet.Tables.Add(table);
            DataSet.AcceptChanges();

        }
    }
}
