using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;

namespace BLLayer
{
    public class ProductGroupManager : Repository<ProductGroup>
    {
        public enum GroupDetails
        {
            GroupCode,
            GroupName
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().GroupCode + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<ProductGroup> SourceData)
        {
            dt.Rows.Clear();
            foreach (ProductGroup gr in SourceData)
            {
                dt.Rows.Add(gr.GroupCode, gr.GroupName);
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = GroupDetails.GroupCode.ToString(), ArabicCaption = "كود المجموعة", EnglishCaption = "Group Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = GroupDetails.GroupName.ToString(), ArabicCaption = "إسم المجموعة", EnglishCaption = "Group Name", DataType = typeof(string) });
            return headers;
        }
    }
}
