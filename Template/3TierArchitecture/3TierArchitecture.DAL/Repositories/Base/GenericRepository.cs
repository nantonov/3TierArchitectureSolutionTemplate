using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using $safeprojectname$.Entities.Base;
using $safeprojectname$.Interfaces.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace $safeprojectname$.Repositories.Base
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : HasIdBaseEntity
    {
        protected ApplicationDbContext Context { get; }

        protected DbSet<TEntity> EntityDbSet { get; }

        public virtual IQueryable<TEntity> Query => EntityDbSet.AsQueryable();

        public GenericRepository(ApplicationDbContext context)
        {
            Context = context;
            EntityDbSet = context.Set<TEntity>();
        }

        public Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return Query.Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            await EntityDbSet.AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return entity;
        }

        public Task Delete(TEntity entity)
        {
            Context.Remove(entity);
            return Context.SaveChangesAsync();
        }
    }
}
