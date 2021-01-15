using System.Linq;
using Medina.Api2.Softplan.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Medina.Api2.Softplan.Application.DI
{
    public static class ApplicationServicesModule
    {
        public static void ApplicationServicesModuleRegister(this IServiceCollection services)
        {
            var appServices = typeof(ServicesFoo).Assembly.GetTypes().Where(t => t.FullName.StartsWith("Medina.Api2.Softplan.Application.Services.") &&
                           t.FullName.EndsWith("Service"));

            foreach (var appService in appServices)
            {
                services.AddSingleton(appService.GetInterfaces().First(), appService);
            }
        }
    }
}
