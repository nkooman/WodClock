using AutoMapper;
using WodClock.Infrastructure.Abstractions;
using WodClock.Repository.EntityFramework.Abstractions;
using Entities = WodClock.Repository.EntityFramework.Entities;
using Models = WodClock.Core.Models;

namespace WodClock.Infrastructure
{
    public class ActionService : Service<Entities.Action, Models.Action>, IActionService
    {
        public ActionService(IMapper mapper, IActionRepository repository)
            : base(mapper, repository) { }
    }
}