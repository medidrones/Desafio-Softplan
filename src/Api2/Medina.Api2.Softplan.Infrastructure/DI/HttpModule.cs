using System.Linq;
using Medina.Api2.Softplan.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Medina.Api2.Softplan.Infrastructure.DI
{
    public static class HttpModule
    {
        public static void HttpModuleRegister(this IServiceCollection services)
        {
            var httpServices = typeof(ServicesFoo).Assembly.GetTypes().Where(t => t.FullName.StartsWith("Medina.Api2.Softplan.Infrastructure.Services.") && t.FullName.EndsWith("Service"));

            foreach (var httpService in httpServices)
            {
                services.AddSingleton(httpService.GetInterfaces().First(), httpService);
            }
        }
    }
}
