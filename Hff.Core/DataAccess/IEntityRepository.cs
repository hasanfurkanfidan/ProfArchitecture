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
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> expression=null);
        #endregion
        #region[Crud]
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        #endregion
    }
}
