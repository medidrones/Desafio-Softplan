using Medina.Api2.Softplan.Domain.Services;

namespace Medina.Api2.Softplan.Application.Services
{
    public class ShowMeTheCodeService : IShowMeTheCodeService
    {
        const string GIT_URL = "https://github.com/medidrones/Desafio-Softplan";

        public string ObterUrlGit()
        {
            return GIT_URL;
        }
    }
}
