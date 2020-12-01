using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WodClock.Core.Abstractions;
using WodClock.Infrastructure.Abstractions;
using WodClock.Repository.EntityFramework.Abstractions;

namespace WodClock.Infrastructure
{
    public class Service<TEntity, TModel> : IService<TModel>
        where TEntity : class, IEntity
        where TModel : class, IModel
    {
        private readonly IMapper mapper;
        private readonly IRepository<TEntity> repository;

        public Service(IMapper mapper, IRepository<TEntity> repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async virtual void DeleteAsync(Guid id)
        {
            var entity = await repository.GetAsync(id);

            await repository.DeleteAsync(entity);
        }

        public virtual IEnumerable<TModel> Get()
        {
            var entities = repository.Get();

            return mapper.Map<IEnumerable<TModel>>(entities);
        }

        public async virtual Task<TModel> GetAsync(Guid id)
        {
            var entity = await repository.GetAsync(id);

            return mapper.Map<TModel>(entity);
        }

        public async virtual Task<IEnumerable<TModel>> GetAsync(IEnumerable<Guid> ids)
        {
            var entities = await repository.GetAsync(queryFilter => queryFilter.Where(entity => ids.Any(id => id == entity.Id)));

            return mapper.Map<IEnumerable<TModel>>(entities);
        }

        public async virtual Task<bool> SaveAsync(TModel model)
        {
            var entity = mapper.Map<TEntity>(model);

            return await repository.SaveAsync(entity);
        }
    }
}