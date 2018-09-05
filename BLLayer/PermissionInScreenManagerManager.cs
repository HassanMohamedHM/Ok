using DALLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLayer
{
    public class PermissionInScreenManagerManager : Repository<PermissionsInScreen>
    {
        protected override void CreateRows(ref DataTable dt, IQueryable<PermissionsInScreen> SourceData)
        {
            throw new NotImplementedException();
        }

        protected override List<TableHeader> SetHeaders()
        {
            throw new NotImplementedException();
        }
    }
}
