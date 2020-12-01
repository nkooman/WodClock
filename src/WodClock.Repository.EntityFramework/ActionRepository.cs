using WodClock.Repository.EntityFramework.Abstractions;
using WodClock.Repository.EntityFramework.Entities;

namespace WodClock.Repository.EntityFramework
{
    public class ActionRepository : Repository<Action>, IActionRepository
    {
        public ActionRepository(ApiContext context)
            : base(context) { }
    }
}