using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
namespace BLLayer
{
    public  class UserRolesManager:Repository<UserRoles>
    {
        protected override void CreateRows(ref System.Data.DataTable dt, IQueryable<UserRoles> SourceData)
        {
            throw new NotImplementedException();
        }

        protected override List<TableHeader> SetHeaders()
        {
            throw new NotImplementedException();
        }
    }
}
