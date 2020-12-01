using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WodClock.Repository.EntityFramework;

namespace WodClock.Api.Extensions
{
    public static class IApplicationBuilderExtensions
    {
        public static IApplicationBuilder EnsureApiContextInitialized(this IApplicationBuilder app, IServiceScopeFactory serviceScopeFactory)
        {
            using (var scope = serviceScopeFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApiContext>();

                context.Database.EnsureCreated();
            }

            return app;
        }
    }
}