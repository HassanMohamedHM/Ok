using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using System.Data;
namespace BLLayer
{
    public class BOMOutputProductManager:Repository<BOMOutputProduct>
    {
        public override object GetCode()
        {
            if (GetAll().Count() > 0)
            {
                return (GetAll().ToList().Max(c => c.OutputCode) + 1);
            }
            return "1";
        }
        protected override void CreateRows(ref DataTable dt, IQueryable<BOMOutputProduct> SourceData)
        {
            throw new NotImplementedException();
        }
        protected override List<TableHeader> SetHeaders()
        {
            throw new NotImplementedException();
        }
    }
}
