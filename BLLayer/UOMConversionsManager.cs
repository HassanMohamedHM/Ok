using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
namespace BLLayer
{
   public class UOMConversionsManager : Repository<UOMConversions>
    {
        public enum UOMDetails
        {
            ID,
            UnitFromCode,
            UnitFromName,
            UnitToCode,
            UnitToName,
            Factor
        }
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Last().ID + 1).ToString();
            }
            return "1";
        }
        protected sealed override void CreateRows(ref DataTable dt, IQueryable<UOMConversions> SourceData)
        {
            dt.Rows.Clear();
            foreach (UOMConversions uom in SourceData)
            {
                dt.Rows.Add(
                    uom.ID,
                    uom.Unit_Code_From,uom.Unit.Unit_Name,
                    uom.Unit_Code_To,uom.Unit1.Unit_Name,
                    uom.Factor
                    );
            }
        }
        protected sealed override List<TableHeader> SetHeaders()
        {
            List<TableHeader> headers = new List<TableHeader>();
            headers.Add(new TableHeader() { ColumnName = UOMDetails.ID.ToString(), ArabicCaption = "كود التحويل", EnglishCaption = "UOM Conversion Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = UOMDetails.UnitFromCode.ToString(), ArabicCaption = "كود الوحدة", EnglishCaption = "Unit Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = UOMDetails.UnitFromName.ToString(), ArabicCaption = "من الوحدة", EnglishCaption = "Unit From", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = UOMDetails.UnitToCode.ToString(), ArabicCaption = "كود الوحدة", EnglishCaption = "Unit Code", DataType = typeof(int) });
            headers.Add(new TableHeader() { ColumnName = UOMDetails.UnitToName.ToString(), ArabicCaption = "إلى الوحدة", EnglishCaption = "Unit To", DataType = typeof(string) });
            headers.Add(new TableHeader() { ColumnName = UOMDetails.Factor.ToString(), ArabicCaption = "المعامل", EnglishCaption = "Factor", DataType = typeof(decimal) });
            return headers;
        }
    }
}
