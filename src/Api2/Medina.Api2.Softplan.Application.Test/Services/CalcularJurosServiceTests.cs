using System.Threading.Tasks;
using FluentAssertions;
using Medina.Api2.Softplan.Application.Services;
using Medina.Api2.Softplan.Domain.Services;
using Moq;
using Xunit;

namespace Medina.Api2.Softplan.Application.Test.Services
{
    public class CalcularJurosServiceTests
    {
        const decimal VALOR_INICIAL = 100;
        const int MESES = 5;
        const decimal RESULTADO = 105.10m;
        const string RESULTADO_FORMATADO = "105,10";

        private readonly CalcularJurosService _service;
        private readonly Mock<IApi1Service> _api1ServiceMock = new Mock<IApi1Service>();

        public CalcularJurosServiceTests()
        {
            _api1ServiceMock.Setup(x => x.ObterTaxaDeJurosAsync()).Returns(Task.FromResult(0.01m));
            _service = new CalcularJurosService(_api1ServiceMock.Object);
        }

        [Fact]
        public void Quando_calcuar_juros_composto()
        {
            var resultado = _service.CalcularAsync(VALOR_INICIAL, MESES).GetAwaiter().GetResult();
            resultado.Should().Be(RESULTADO);
        }

        [Fact]
        public void Quando_calcuar_juros_composto_formatado()
        {
            var resultado = _service.CalcularComFormatacaoAsync(VALOR_INICIAL, MESES).GetAwaiter().GetResult();
            resultado.Should().Be(RESULTADO_FORMATADO);
        }
    }
}
