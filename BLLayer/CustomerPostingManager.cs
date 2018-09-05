using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
namespace BLLayer
{
   public class CustomerPostingManager:Repository<CustomerPosting>
    {
        protected override void CreateRows(ref System.Data.DataTable dt, IQueryable<CustomerPosting> SourceData)
        {
            throw new NotImplementedException();
        }

        protected override List<TableHeader> SetHeaders()
        {
            throw new NotImplementedException();
        }


        public static void GetCustomerPostingAccountsCode(int CustomerCode, out string CustomerAccountCode, out string CashAccountCode)
        {
            CustomerManager cust = new CustomerManager();
            CustomerAccountCode = cust.Get(CustomerCode).CustomerGroup.CustomerPosting.CustomerAccount;
            CashAccountCode = cust.Get(CustomerCode).CustomerGroup.CustomerPosting.CashAccount;
        }
    }
}
