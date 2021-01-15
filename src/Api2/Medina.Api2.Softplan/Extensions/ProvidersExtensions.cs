using Medina.Api2.Softplan.Infrastructure.Provider;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Medina.Api2.Softplan.Extensions
{
    public static class ProvidersExtensions
    {
        public static void ProvidersConfigure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Api1Provider>(configuration.GetSection("Api1Provider"));
        }
    }
}
