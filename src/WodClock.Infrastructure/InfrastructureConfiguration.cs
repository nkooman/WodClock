using Microsoft.Extensions.DependencyInjection;
using WodClock.Infrastructure.Abstractions;

namespace WodClock.Infrastructure
{
    public static class InfrastructureConfiguration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IActionTimelineService, ActionTimelineService>();
            services.AddScoped<IActionService, ActionService>();
        }
    }
}