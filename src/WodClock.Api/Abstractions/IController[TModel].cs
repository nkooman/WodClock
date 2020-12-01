using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WodClock.Core.Abstractions;

namespace WodClock.Api.Abstractions
{
    public interface IController<TModel>
        where TModel : class, IModel
    {
        void DeleteAsync(Guid id);
        IEnumerable<TModel> Get();
        Task<TModel> GetAsync(Guid id);
        Task<bool> SaveAsync(TModel model);
    }
}