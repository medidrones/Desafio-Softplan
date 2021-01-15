using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Medina.Api2.Softplan.Domain.Services;
using Medina.Api2.Softplan.Infrastructure.Extensions;
using Medina.Api2.Softplan.Infrastructure.Provider;
using Microsoft.Extensions.Options;

namespace Medina.Api2.Softplan.Infrastructure.Services
{
    public class Api1Service : IApi1Service
    {

        private readonly IOptions<Api1Provider> _api1Provider;

        public Api1Service(IOptions<Api1Provider> api1Provider)
        {
            _api1Provider = api1Provider;
        }

        public async Task<decimal> ObterTaxaDeJurosAsync()
        {
            using (var client = new HttpClient().CreateClient(_api1Provider.Value.Url))
            {
                var responseMessage = await client.GetAsync("api/taxaJuros");
                var response = await responseMessage.Content.ReadAsStringAsync();

                if (responseMessage.IsSuccessStatusCode)
                {
                    return decimal.Parse(response);
                }

                switch (responseMessage.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        throw new ArgumentException(response);

                    default:
                        throw new Exception(response);
                }

            }
        }
    }
}
