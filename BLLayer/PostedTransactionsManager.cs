using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
namespace BLLayer
{
    public class PostedTransactionsManager:Repository<PostedTransactions>
    {
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().LinCode + 1).ToString();
            }
            return "1";
        }
        protected override void CreateRows(ref System.Data.DataTable dt, IQueryable<PostedTransactions> SourceData)
        {
            throw new NotImplementedException();
        }

        protected override List<TableHeader> SetHeaders()
        {
            throw new NotImplementedException();
        }


        public void AddPostedTransactionDetails(long TransactionCode, DateTime PostedDateTime, int UserCode, string AccountCode,decimal? DebitAmount, decimal? CreditAmount)
        {
            Add(new PostedTransactions()
            {
                LinCode = int.Parse(GetCode().ToString()),
                transCode = TransactionCode,
                PostedDate = PostedDateTime.Date,
                PostedTime = PostedDateTime.TimeOfDay,
                UserCode = UserCode,
                accCode = AccountCode,
                DebitAmount = DebitAmount,
                CreditAmount = CreditAmount
            });
        }
    }
}
