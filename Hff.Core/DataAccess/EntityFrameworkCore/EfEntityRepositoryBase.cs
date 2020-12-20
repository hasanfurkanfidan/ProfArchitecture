using Hff.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Core.DataAccess.EntityFrameworkCore
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using var context = new TContext();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using var context = new TContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            using var context = new TContext();
            return await context.Set<TEntity>().Where(expression).FirstOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            using var context = new TContext();
            if (expression==null)
            {
                return await context.Set<TEntity>().ToListAsync();
            }
            return await context.Set<TEntity>().Where(expression).ToListAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using var context = new TContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
