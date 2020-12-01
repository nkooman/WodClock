using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WodClock.Api.Attributes;
using WodClock.Core.Abstractions;

namespace WodClock.Api.Abstractions
{
    public interface IModelPopulationController<TModel> : IController<TModel>
        where TModel : class, IModel
    {
        Task<IEnumerable<TModel>> GetAsync([RequiredFromQuery] bool populate);
        Task<TModel> GetAsync(Guid id, [RequiredFromQuery] bool populate);
    }
}