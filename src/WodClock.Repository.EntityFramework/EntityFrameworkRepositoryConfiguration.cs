using Microsoft.Extensions.DependencyInjection;
using WodClock.Repository.EntityFramework.Abstractions;

namespace WodClock.Repository.EntityFramework
{
    public static class EntityFrameworkRepositoryConfiguration
    {
        public static void AddEntityFrameworkRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IActionTimelineRepository, ActionTimelineRepository>();
            services.AddScoped<IActionRepository, ActionRepository>();
        }
    }
}