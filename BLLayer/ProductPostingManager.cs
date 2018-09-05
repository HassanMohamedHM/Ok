using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
namespace BLLayer
{
    public class ProductPostingManager : Repository<ItemPosting>
    {

        protected override void CreateRows(ref System.Data.DataTable dt, IQueryable<ItemPosting> SourceData)
        {
            throw new NotImplementedException();
        }

        protected override List<TableHeader> SetHeaders()
        {
            throw new NotImplementedException();
        }


        public static void GetPurchasePostingAccountsCode(int ProductCode, out string ProductRecieptAccount, out string PurchaseDiscountAccount)
        {
            ProductManager product = new ProductManager();
            ProductRecieptAccount = product.Get(ProductCode).ProductGroup.ItemPosting.ProductRecieptAccount;
            PurchaseDiscountAccount = product.Get(ProductCode).ProductGroup.ItemPosting.PurchaseDiscountAccount;
        }

        public static void GetSalesPostingAccountsCode(int ProductCode, out string IssueAccount, out string ConsumptionAccount,out string RevenueAccount,out string SalesDiscountAccount)
        {
            ProductManager product = new ProductManager();
            IssueAccount = product.Get(ProductCode).ProductGroup.ItemPosting.IssueAccount;
            ConsumptionAccount = product.Get(ProductCode).ProductGroup.ItemPosting.ConsumptionAccount;
            RevenueAccount = product.Get(ProductCode).ProductGroup.ItemPosting.RevenueAccount;
            SalesDiscountAccount = product.Get(ProductCode).ProductGroup.ItemPosting.SalesDiscountAccount;
        }
    }
}
