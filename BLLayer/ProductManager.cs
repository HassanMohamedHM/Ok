using System.Collections.Generic;
using System.Linq;
using DALLayer;
using System.Data;
using System.Windows.Forms;
using System;
using System.Collections;
namespace BLLayer
{
    public class ProductManager : Repository<Product>
    {
        /// <summary>
        /// RM =>> Row Material
        /// PKG=>> Packaging Material
        /// PACK=>> Packing Material
        /// SFG=>> Semi Finished Goods
        /// FG=>>Finished Goods
        /// Service
        /// CoProduct
        /// </summary>
        public enum ProductType
        {
            RM,
            PKG,
            PACK,
            SFG,
            FG,
            Service,
            CoProduct
        }

        public enum ProductDetails
        {
            ProductCode,
            ProductName,
            ProductDesc,
            SearchName,
            ProductType,
            Unit,
            Barcode,
            Quantity
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().Product_Code + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<Product> SourceData)
        {
            dt.Rows.Clear();
            foreach (Product product in SourceData)
            {
                dt.Rows.Add(product.Product_Code,
                    product.Product_Name,
                    product.ProductDesc,
                    product.SearchName,
                    product.ProductType,
                    product.Product_Barcode,
                    product.ProductOnHand.Sum(p=>p.Qty));
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = ProductDetails.ProductCode.ToString(), ArabicCaption = "كود المُنتج", EnglishCaption = "Product Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = ProductDetails.ProductName.ToString(), ArabicCaption = "إسم المُنتج", EnglishCaption = "Product Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = ProductDetails.ProductDesc.ToString(), ArabicCaption = "وصف المُنتج", EnglishCaption = "Product Description", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = ProductDetails.SearchName.ToString(), ArabicCaption = "إسم البحث", EnglishCaption = "Search Name", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = ProductDetails.ProductType.ToString(), ArabicCaption = "نوع المُنتج", EnglishCaption = "Product Type", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = ProductDetails.Barcode.ToString(), ArabicCaption = "الباركود", EnglishCaption = "Barcode", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = ProductDetails.Quantity.ToString(), ArabicCaption = "الكمية فى المخازن", EnglishCaption = "Quantity in Stores", DataType = typeof(decimal) });
            return headers;
        }
        public static void FillProductComboBox(ComboBox ComboBoxName)
        {
            FillCombox(ComboBoxName, new ProductManager().CreateTable(), ProductDetails.ProductName.ToString(), ProductDetails.ProductCode.ToString());
        }


        public static SortedList<int, decimal> GetMostSoldProductOnPeriod(DateTime? FromDate, DateTime? ToDate)
        {
            ProductManager pr = new ProductManager();
            SortedList<int, decimal> productList = new SortedList<int, decimal>();
            foreach (Product item in pr.GetAll())
            {
                if (FromDate != null && ToDate != null)
                {

                    productList.Add(item.Product_Code, (decimal)item.SalesDetails.Where
                        (
                        (s => (s.SalesHeader.Sales_Date.Value >= FromDate &&
                            s.SalesHeader.Sales_Date.Value <= ToDate))).Sum(su => su.Qty));
                }
                else
                {
                    productList.Add(item.Product_Code, (decimal)item.SalesDetails.Sum(su => su.Qty));
                }
            }
            return productList;
        }

        public static DataTable GetZeroProductQuantity(decimal value)
        {
            ProductManager pr = new ProductManager();
            DataTable dt = pr.CreateTable();
            pr.CreateRows(ref dt, pr.GetAll().Where(p => p.ProductOnHand.Sum(s => s.Qty) <= value));
            return dt;
        }

        public static DataTable GetNotSoldProductsOnPeriod(DateTime? FromDate, DateTime? ToDate)
        {
            ProductManager pr = new ProductManager();
            SalesDetailsManager sdm = new SalesDetailsManager();
            DataTable dt = pr.CreateTable();
            if (FromDate != null && ToDate != null)
            {
                pr.CreateRows(ref dt, pr.GetAll().Where(p => p.ProductOnHand.Sum(q => q.Qty) > 0)
                     .Where(ps => ps.SalesDetails.Where(s => (s.SalesHeader.Sales_Date.Value >= FromDate &&
                             s.SalesHeader.Sales_Date.Value <= ToDate)).Count() == 0));
            }
            else
            {
                pr.CreateRows(ref dt, pr.GetAll().Where(p => p.ProductOnHand.Sum(q => q.Qty) > 0)
                    .Where(ps => ps.SalesDetails.Count() == 0));
            }
            return dt;
        }



        public static SortedList<int, decimal> GetProfit()
        {
            ProductManager pr = new ProductManager();
            SortedList<int, decimal> productList = new SortedList<int, decimal>();
            foreach (Product item in pr.GetAll())
            {
                decimal Price = (decimal)(item.DefSalesPrice - (item.ProductOnHand.Count() == 0 ? 0 : item.ProductOnHand.LastOrDefault().AvgCost));
                productList.Add(item.Product_Code, (Price * (item.SalesDetails.Count() == 0 ? 0 : (decimal)item.SalesDetails.Sum(s => s.Qty))));
            }
            return productList;
        }

    }
}
