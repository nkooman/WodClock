using WodClock.Api.Abstractions;
using WodClock.Core.Models;
using WodClock.Infrastructure.Abstractions;

namespace WodClock.Api.Controllers
{
    public class ActionTimelineController : Controller<ActionTimeline>, IActionTimelineController
    {
        public ActionTimelineController(IActionTimelineService service)
            : base(service) { }
    }
}