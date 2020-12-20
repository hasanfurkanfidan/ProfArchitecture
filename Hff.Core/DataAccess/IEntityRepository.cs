using Hff.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Core.DataAccess
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        #region[Get]
        Task<TEntity> Get(Expression<Func<TEntity, bool>> expression);
        Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> expression=null);
        #endregion
        #region[Crud]
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        #endregion
    }
}
