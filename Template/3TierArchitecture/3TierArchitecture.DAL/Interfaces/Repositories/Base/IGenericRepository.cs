using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using $safeprojectname$.Interfaces.Entities.Base;

namespace $safeprojectname$.Interfaces.Repositories.Base
{
    public interface IGenericRepository<TEntity>
        where TEntity : IHasIdBaseEntity
    {
        IQueryable<TEntity> Query { get; }

        Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> Insert(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task Delete(TEntity entity);
    }
}
