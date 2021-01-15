using System.Threading.Tasks;

namespace Medina.Api2.Softplan.Domain.Services
{
    public interface IApi1Service
    {
        Task<decimal> ObterTaxaDeJurosAsync();
    }
}
