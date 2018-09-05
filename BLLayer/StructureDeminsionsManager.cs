using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
namespace BLLayer
{
   public class StructureDeminsionsManager:Repository<StructureDeminsions>
    {
        protected override void CreateRows(ref System.Data.DataTable dt, IQueryable<StructureDeminsions> SourceData)
        {
            throw new NotImplementedException();
        }

        protected override List<TableHeader> SetHeaders()
        {
            throw new NotImplementedException();
        }
    }
}
