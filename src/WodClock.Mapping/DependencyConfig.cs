using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace WodClock.Mapping
{
    public static class DependencyConfiguration
    {
        public static void Register(IServiceCollection services)
        {
            ConfigureAutomapper(services);
        }

        // Add any Assembly Names that need to be scanned for AutoMapper Mapping Profiles here
        private static void ConfigureAutomapper(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(
                cfg => cfg.AddMaps(
                    "WodClock.Api",
                    "WodClock.Infrastructure"
                ));

            var mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);
        }

        private static void RegisterInterfaces(string interfaceType, IServiceCollection services, Assembly coreAssembly, Assembly serviceAssembly)
        {
            var matches = serviceAssembly.GetTypes()
               .Where(t => t.Name.EndsWith(interfaceType, StringComparison.Ordinal) && t.GetInterfaces().Any(i => i.Assembly == coreAssembly))
               .Select(t => new
               {
                   serviceType = t.GetInterfaces().FirstOrDefault(i => i.Assembly == coreAssembly && !i.Name.ToLower().Contains("base")),
                   implementingType = t
               }).ToList();

            // Registers the interface to the implementation.
            foreach (var match in matches)
            {
                services.AddScoped(match.serviceType, match.implementingType);
            }
        }
    }
}
