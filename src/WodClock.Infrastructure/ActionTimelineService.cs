using AutoMapper;
using WodClock.Infrastructure.Abstractions;
using WodClock.Repository.EntityFramework.Abstractions;
using Models = WodClock.Core.Models;
using Entities = WodClock.Repository.EntityFramework.Entities;

namespace WodClock.Infrastructure
{
    public class ActionTimelineService : Service<Entities.ActionTimeline, Models.ActionTimeline>, IActionTimelineService
    {
        public ActionTimelineService(IMapper mapper, IActionTimelineRepository repository)
            : base(mapper, repository) { }
    }
}