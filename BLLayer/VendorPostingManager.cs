using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
namespace BLLayer
{
    public class VendorPostingManager:Repository<VendorPosting>
    {
        protected override void CreateRows(ref System.Data.DataTable dt, IQueryable<VendorPosting> SourceData)
        {
            throw new NotImplementedException();
        }

        protected override List<TableHeader> SetHeaders()
        {
            throw new NotImplementedException();
        }

        public static void GetVendorPostingAccountsCode(int VendorCode,out string VendorAccountCode,out string CashAccountCode)
        {
            VendorManager vend = new VendorManager();
            VendorAccountCode = vend.Get(VendorCode).VendorGroup.VendorPosting.VendorAccount;
            CashAccountCode = vend.Get(VendorCode).VendorGroup.VendorPosting.CashAccount;
        }
    }
}
