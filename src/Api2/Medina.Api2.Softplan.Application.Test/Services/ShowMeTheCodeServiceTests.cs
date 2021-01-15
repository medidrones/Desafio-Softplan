using FluentAssertions;
using Medina.Api2.Softplan.Application.Services;
using Xunit;

namespace Medina.Api2.Softplan.Application.Test.Services
{
    public class ShowMeTheCodeServiceTests
    {
        const string GIT_URL = "https://github.com/medidrones/Desafio-Softplan";

        private readonly ShowMeTheCodeService _service;

        public ShowMeTheCodeServiceTests()
        {
            _service = new ShowMeTheCodeService();
        }

        [Fact]
        public void Quando_obter_url_git()
        {
            var resultado = _service.ObterUrlGit();
            resultado.Should().Be(GIT_URL);
        }
    }
}
