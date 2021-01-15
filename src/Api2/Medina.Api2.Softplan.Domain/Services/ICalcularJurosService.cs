using System.Threading.Tasks;

namespace Medina.Api2.Softplan.Domain.Services
{
    public interface ICalcularJurosService
    {
        Task<decimal> CalcularAsync(decimal valorInicial, int meses);

        Task<string> CalcularComFormatacaoAsync(decimal valorInicial, int meses);
    }
}
