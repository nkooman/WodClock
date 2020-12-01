using System.Threading.Tasks;
using WodClock.Core.Abstractions;

namespace WodClock.Infrastructure.Abstractions
{
    public interface IModelPopulation<TModel>
        where TModel : class, IModel
    {
        Task<TModel> PopulateModel(TModel model);
    }
}