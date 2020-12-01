using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WodClock.Core.Abstractions;

namespace WodClock.Infrastructure.Abstractions
{
    public interface IService<TModel>
        where TModel : class, IModel
    {
        void DeleteAsync(Guid id);
        IEnumerable<TModel> Get();
        Task<TModel> GetAsync(Guid id);
        Task<IEnumerable<TModel>> GetAsync(IEnumerable<Guid> ids);
        Task<bool> SaveAsync(TModel model);
    }
}