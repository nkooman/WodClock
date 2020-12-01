using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WodClock.Api.Abstractions;
using WodClock.Api.Attributes;
using WodClock.Core.Models;
using WodClock.Infrastructure.Abstractions;
using System.Linq;

namespace WodClock.Api.Controllers
{
    public class UsersController : Controller<User>, IUserController, IModelPopulationController<User>
    {
        private readonly IUserService service;
        private readonly IActionTimelineService actionTimelineService;
        private readonly IActionService actionService;
        public UsersController(IUserService service, IActionTimelineService actionTimelineService, IActionService actionService)
            : base(service)
        {
            this.service = service;
            this.actionTimelineService = actionTimelineService;
            this.actionService = actionService;
        }

        public async Task<IEnumerable<User>> GetAsync([RequiredFromQuery] bool populate)
        {
            var models = service.Get();

            if (populate)
            {
                foreach (var model in models)
                {
                    model.ActionTimelines = await actionTimelineService.GetAsync(model.ActionTimelineIds);
                    model.Actions = await actionService.GetAsync(model.ActionIds);
                }
            }

            return models;
        }

        public async Task<User> GetAsync(Guid id, [RequiredFromQuery] bool populate)
        {
            var model = await service.GetAsync(id);

            if (populate)
            {
                model.ActionTimelines = await actionTimelineService.GetAsync(model.ActionTimelineIds);
                model.Actions = await actionService.GetAsync(model.ActionIds);
            }

            return model;
        }
    }
}