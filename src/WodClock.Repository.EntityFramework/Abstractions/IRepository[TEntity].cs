using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WodClock.Repository.EntityFramework.Abstractions
{
    public interface IRepository<TEntity>
        where TEntity : class, IEntity
    {
        Task DeleteAsync(TEntity entity);
        IQueryable<TEntity> Get();
        Task<TEntity> GetAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAsync();
        Task<IEnumerable<TEntity>> GetAsync(Func<IQueryable<TEntity>, IQueryable<TEntity>> queryFilter);
        Task<bool> SaveAsync(TEntity entity);
    }
}