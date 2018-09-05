using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DALLayer
{
     interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(params object[] Id);
        TEntity Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool DeleteMulti(IEnumerable<TEntity> entities);

    }
}
