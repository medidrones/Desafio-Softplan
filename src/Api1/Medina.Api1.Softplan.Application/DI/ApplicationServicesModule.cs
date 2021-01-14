using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Medina.Api1.Softplan.Application.Services;

namespace Medina.Api1.Softplan.Application.DI
{
    public static class ApplicationServicesModule
    {
        public static void ApplicationServicesModuleRegister(this IServiceCollection services)
        {
            var appServices = typeof(ServicesFoo).Assembly.GetTypes().Where(t => t.FullName.StartsWith("Medina.Api1.Softplan.Application.Services.") &&
                           t.FullName.EndsWith("Service"));

            foreach (var appService in appServices)
            {
                {
                    services.AddSingleton(appService.GetInterfaces().First(), appService);
                }
            }
        }
    }
}
