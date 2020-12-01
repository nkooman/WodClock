using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WodClock.Repository.EntityFramework.Abstractions;

namespace WodClock.Repository.EntityFramework
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        protected readonly ApiContext context;
        protected readonly DbSet<TEntity> entities;

        public Repository(ApiContext context)
        {
            this.context = context;
            this.entities = context.Set<TEntity>();
        }

        public virtual Task DeleteAsync(TEntity entity)
        {
            ThrowIfEntityIsNull(entity);

            EntityEntry<TEntity> entry = context.Entry(entity);

            if (!entry.IsKeySet)
            {
                return Task.CompletedTask;
            }

            entities.Remove(entity);

            return context.SaveChangesAsync();
        }

        public virtual IQueryable<TEntity> Get()
            => entities.AsNoTracking();

        public async virtual Task<TEntity> GetAsync(Guid id)
            => await context.FindAsync<TEntity>(new object[] { id });

        public async virtual Task<IEnumerable<TEntity>> GetAsync()
            => await GetAsync(query => query);

        public async virtual Task<IEnumerable<TEntity>> GetAsync(Func<IQueryable<TEntity>, IQueryable<TEntity>> queryFilter)
            => await queryFilter(Get()).ToListAsync();

        public virtual async Task<bool> SaveAsync(TEntity entity)
        {
            ThrowIfEntityIsNull(entity);

            EntityEntry<TEntity> entry = context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                await entities.AddAsync(entity);
            }

            if (entry.State == EntityState.Unchanged)
            {
                return true;
            }

            if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
            {
                return (await context.SaveChangesAsync()) > 0;
            }

            return false;
        }

        protected void ThrowIfEntityIsNull(TEntity entity, string name = null)
        {
            if (entity == null) throw new ArgumentNullException(name ?? nameof(entity));
        }
    }
}