using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;

namespace BLLayer
{
   public class OrganizationManager:Repository<Organization>
    {
        protected override void CreateRows(ref System.Data.DataTable dt, IQueryable<Organization> SourceData)
        {
            throw new NotImplementedException();
        }

        protected override List<TableHeader> SetHeaders()
        {
            throw new NotImplementedException();
        }
    }
}
