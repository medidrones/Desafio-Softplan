using Medina.Api1.Softplan.Domain.Services;

namespace Medina.Api1.Softplan.Application.Services
{
    public class TaxaDeJurosService : ITaxaDeJurosService
    {
        public decimal Obter()
        {
            var taxa = (1 / 100m);
            return taxa;
        }
    }
}
