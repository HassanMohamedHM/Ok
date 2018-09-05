using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
using System.Threading;


namespace BLLayer
{
    public class TransactionHeaderManager : Repository<TransactionHeader>
    {
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().transCode + 1).ToString();
            }
            return "1";
        }
        protected override void CreateRows(ref System.Data.DataTable dt, IQueryable<TransactionHeader> SourceData)
        {
            throw new NotImplementedException();
        }

        protected override List<TableHeader> SetHeaders()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// This Method Get All transactions Header upon Condition
        /// </summary>
        /// <param name="index">if index ==0 --> Get All ,if index==1 --> Get Open Only ,if index==2 --> Get Posted Only ,if index==3 --> Get Current User Transactions</param>
        public  void MakeFirstTable(int index)
        {
            DataTable table = new DataTable(tablename);
            DataColumn col;
            col = new DataColumn();
            col.DataType = typeof(string);
            col.ColumnName = "v1";
            table.Columns.Add(col);
            col = new DataColumn();
            col.DataType = typeof(string);
            col.ColumnName = "v2";
            table.Columns.Add(col);
            col = new DataColumn();
            col.DataType = typeof(string);
            col.ColumnName = "v3";
            table.Columns.Add(col);
            col = new DataColumn();
            col.DataType = typeof(string);
            col.ColumnName = "v4";
            table.Columns.Add(col);
            col = new DataColumn();
            col.DataType = typeof(bool);
            col.ColumnName = "v5";
            table.Columns.Add(col);
            // 0 defualt --> ALL
            IQueryable<TransactionHeader> AllTransaction = GetAll();
            // 1 --> Open 
            if (index == 1)
            {
                AllTransaction = GetAll().Where(h => h.IsPosted == false);
            }
                // 2 --> Posted
            else if (index == 2)
            {
                AllTransaction = GetAll().Where(h => h.IsPosted == true);
            }
                //3 --> Current user
            else if (index == 3)
            {
                int userCode=int.Parse(Thread.CurrentPrincipal.Identity.Name.ToString());
                AllTransaction = GetAll().Where(h => h.UserCode == userCode);
            }
            foreach (TransactionHeader item in AllTransaction)
            {
                table.Rows.Add(item.transCode, item.JournalCode, item.JournalNames.JournalName, item.Discription, item.IsPosted);
            }
            DataSet = new DataSet();
            DataSet.Tables.Add(table);
            DataSet.AcceptChanges();

        }

        public void AddHeaderDetails(long TransactionCode,int JournalCode,DateTime TransactionDate,string Discription,int UserCode,bool IsPosted)
        {
            Add(new TransactionHeader()
            {
                transCode = TransactionCode,
                JournalCode = JournalCode,
                transDate = TransactionDate.Date,
                Discription =Discription,
                UserCode = UserCode,
                IsPosted = IsPosted
            });
        }
    }
}
