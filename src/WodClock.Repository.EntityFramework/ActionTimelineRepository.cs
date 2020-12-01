using WodClock.Repository.EntityFramework.Abstractions;
using WodClock.Repository.EntityFramework.Entities;

namespace WodClock.Repository.EntityFramework
{
    public class ActionTimelineRepository : Repository<ActionTimeline>, IActionTimelineRepository
    {
        public ActionTimelineRepository(ApiContext context)
            : base(context) { }
    }
}