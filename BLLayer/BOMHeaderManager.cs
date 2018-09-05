using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
namespace BLLayer
{
    public class BOMHeaderManager:Repository<BOMHeader>
    {
        public enum BOMHeadreDetails
        {
            BOMCode,
            BOMDate,
            JournalCode,
            Description,
            IsPosted
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Max(c => c.BOMCode) + 1);
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<BOMHeader> SourceData)
        {
            dt.Rows.Clear();
            foreach (BOMHeader bom in SourceData)
            {
                dt.Rows.Add(bom.BOMLookUpCode, bom.BOMDate, bom.JournalCode, bom.Description, bom.IsPosted);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = "v1", ArabicCaption = "كود اليومية", EnglishCaption = "BOM Code", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = "v2", ArabicCaption = "تاريخ اليومية", EnglishCaption = "BOM Date", DataType = typeof(DateTime) });
            headers.Add(new TableHeader() { ColumnName = "v3", ArabicCaption = "اليومية", EnglishCaption = "Journal", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = "v4", ArabicCaption = "البيـــان", EnglishCaption = "Description", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = "v5", ArabicCaption = "مرحلة", EnglishCaption = "IsPosted", DataType = typeof(bool) });
            return headers;
        }

        public static DataTable GetBomDetails(long BOMCode)
        {
            DataTable dt = new DataTable();
            BOMOutputProductManager output = new BOMOutputProductManager();
            BOMIngredientsProductsManager ingred = new BOMIngredientsProductsManager();

            dt.Columns.Add("v1", typeof(string));
            dt.Columns.Add("v2", typeof(string));
            dt.Columns.Add("v3", typeof(string));
            dt.Columns.Add("v4", typeof(string));
            dt.Columns.Add("v5", typeof(string));
            dt.Columns.Add("v6", typeof(string));
            dt.Columns.Add("v7", typeof(string));
            var Details =
                output.GetAll().Where(o => o.BOMCode == BOMCode).Select(
                o => new { o.LookUpCode, o.WHCode, o.ProductCode, o.Cost, o.Quantity })
                 .Union(ingred.GetAll().Where(i => i.BOMCode == BOMCode).Select(
                 i => new { i.LookUpCode, i.WHCode, i.ProductCode, i.Cost, i.Quantity })).OrderByDescending(c => c.LookUpCode)
                 .ToList();
            ProductManager p=new ProductManager();
            foreach (var item in Details)
            {
                dt.Rows.Add(item.LookUpCode, item.ProductCode, item.WHCode, item.Cost, item.Quantity, (item.Cost * item.Quantity),p.Get(item.ProductCode).Product_Name);
            }

            return dt;
        }

        public static void PostBom(long BOMCode)
        {
            ProductManager PrManager = new ProductManager();
            BOMHeaderManager headerManger = new BOMHeaderManager();
            BOMHeader header = headerManger.Get(BOMCode);

            header.IsPosted = true;
            headerManger.Update(header);
            foreach (BOMOutputProduct item in header.BOMOutputProduct)
            {
                #region Add OnHandProduct Details :
                new OnHandProductManager().AddOnHandDetails((int)item.ProductCode, (int)item.WHCode, (decimal)item.Quantity
                    , (int)PrManager.Get(item.ProductCode).DefInventoryUnit, (decimal)item.Cost, false, true);
                #endregion
            }
            foreach (BOMIngredientsProducts item in header.BOMIngredientsProducts)
            {
                #region Add OnHandProduct Details :
                new OnHandProductManager().AddOnHandDetails((int)item.ProductCode, (int)item.WHCode, (decimal)item.Quantity
                    , (int)PrManager.Get(item.ProductCode).DefInventoryUnit, (decimal)item.Cost, true, false);
                #endregion
            }
            
           

        }


        public static bool ValidateBOM(long BOMCode)
        {
            return true;
        }

    }
}
