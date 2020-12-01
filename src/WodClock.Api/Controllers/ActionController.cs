using WodClock.Api.Abstractions;
using WodClock.Core.Models;
using WodClock.Infrastructure.Abstractions;

namespace WodClock.Api.Controllers
{
    public class ActionController : Controller<Action>, IActionController
    {
        public ActionController(IActionService service)
            : base(service) { }
    }
}