using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
namespace BLLayer
{
    public class OnHandProductManager : Repository<ProductOnHand>
    {
        public enum WhProductDetails
        {
            Product,
            WhareHouse,
            Unit,
            Qty,
            SalesPrice,
            PurchasePrice,
            AvgCost
        }
        protected override void CreateRows(ref System.Data.DataTable dt, IQueryable<ProductOnHand> SourceData)
        {
            foreach (ProductOnHand item in SourceData)
            {
                dt.Rows.Add(
                item.Product.Product_Name,
                item.WareHouse.WareHouse_Name,
                item.Unit.Unit_Name,
                item.Qty,
                item.Product.DefSalesPrice,
                item.NewPurchasePrice,
                item.AvgCost
                );
            }
        }

        protected override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = WhProductDetails.Product.ToString(), ArabicCaption = "المنتج", EnglishCaption = "Product", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = WhProductDetails.WhareHouse.ToString(), ArabicCaption = "المخزن", EnglishCaption = "WareHouse", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = WhProductDetails.Unit.ToString(), ArabicCaption = "الوحدة", EnglishCaption = "Unit", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = WhProductDetails.Qty.ToString(), ArabicCaption = "الكمية فى المخزن", EnglishCaption = "Quantity in WareHouse", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = WhProductDetails.SalesPrice.ToString(), ArabicCaption = "سعر البيع", EnglishCaption = "Sales Price", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = WhProductDetails.PurchasePrice.ToString(), ArabicCaption = "اخر سعر شراء", EnglishCaption = "Last Purchase Price", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = WhProductDetails.AvgCost.ToString(), ArabicCaption = "متوسط السعر فى المخزن", EnglishCaption = "Average Cost", DataType = typeof(string) });
            return headers;
        }

        public void AddOnHandDetails(int ProductCode,int WareHouseCode,decimal Qty,int UnitCode,decimal UnitPrice,bool InvoiceType, bool IsPurchase)
        {
            decimal? LastPurchasePrice = null;
            ProductOnHand hand = null;
            if (GetAll().ToList().Count > 0)
            {
                LastPurchasePrice = GetLastPurchasePrice(ProductCode);

                hand = GetAll().ToList().FirstOrDefault(oh => oh.Product_Code == ProductCode && oh.WHCode == WareHouseCode);
            }

            #region Update If Exist :
            if (hand != null)
            {
                Edit(Qty, UnitPrice, InvoiceType, LastPurchasePrice, hand,IsPurchase);
            }
            #endregion

            #region Add If New :
            else if (hand == null)
            {
                AddNew(ProductCode, WareHouseCode, Qty, UnitCode, UnitPrice, LastPurchasePrice);
            }
            #endregion

        }

        private decimal? GetLastPurchasePrice(int ProductCode)
        {
            ProductOnHand poh = GetAll().ToList().FirstOrDefault(oh => oh.Product_Code == ProductCode);
            return poh != null ? poh.NewPurchasePrice : null;
        }

        private void AddNew(int ProductCode, int WareHouseCode, decimal Qty, int UnitCode, decimal UnitPrice, decimal? LastPurchasePrice)
        {
            Add(new ProductOnHand()
            {
                Product_Code = ProductCode,
                WHCode = WareHouseCode,
                Qty = Qty,
                Unit_Code = UnitCode,
                LastPurchasePrice = LastPurchasePrice != null ? LastPurchasePrice : UnitPrice,
                NewPurchasePrice = UnitPrice,
                AvgCost = LastPurchasePrice != null ? (LastPurchasePrice + UnitPrice) / 2 : UnitPrice
            });
        }

        private void Edit(decimal Qty, decimal UnitPrice, bool InvoiceType, decimal? LastPurchasePrice, ProductOnHand hand, bool IsPurchase)
        {
            hand.Qty = InvoiceType == false ? hand.Qty += Qty : hand.Qty -= Qty;

            if (IsPurchase == true)
            {
                hand.LastPurchasePrice = LastPurchasePrice;
                hand.NewPurchasePrice = UnitPrice;
                hand.AvgCost = (LastPurchasePrice + UnitPrice) / 2;
            }
            Update(hand);
        }




        public static decimal? GetAvgCost(int ProductCode)
        {
            ProductOnHand poh =new OnHandProductManager().GetAll().ToList().FirstOrDefault(oh => oh.Product_Code == ProductCode);
            return poh != null ? poh.AvgCost : null;
        }

       
    }

}
