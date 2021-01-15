using FluentAssertions;
using Medina.Api1.Softplan.Application.Services;
using Xunit;

namespace Medina.Api1.Softplan.Application.Test.Services
{
    public class TaxaDeJurosServiceTests
    {
        private readonly TaxaDeJurosService _service = new TaxaDeJurosService();

        [Fact]
        public void Quando_obter_taxa_de_juros()
        {
            var resultado = _service.Obter();

            resultado.Should().Be(0.01m);
        }
    }
}
