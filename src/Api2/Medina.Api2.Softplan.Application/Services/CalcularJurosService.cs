using System;
using System.Threading.Tasks;
using Medina.Api2.Softplan.Application.Extensions;
using Medina.Api2.Softplan.Domain.Services;

namespace Medina.Api2.Softplan.Application.Services
{
    public class CalcularJurosService : ICalcularJurosService
    {

        private readonly IApi1Service _api1Service;

        public CalcularJurosService(IApi1Service api1Service)
        {
            _api1Service = api1Service;
        }

        public async Task<decimal> CalcularAsync(decimal valorInicial, int meses)
        {
            var juros = await _api1Service.ObterTaxaDeJurosAsync();

            var resultado = (double)valorInicial * Math.Pow((double)juros + 1, meses);

            return ((decimal)resultado).TruncateDecimal(2);
        }

        public async Task<string> CalcularComFormatacaoAsync(decimal valorInicial, int meses)
        {

            var juros = await _api1Service.ObterTaxaDeJurosAsync();

            var resultado = (double)valorInicial * Math.Pow((double)juros + 1, meses);

            return resultado.ToString("0.00").Replace(".", ",");
        }
    }
}
