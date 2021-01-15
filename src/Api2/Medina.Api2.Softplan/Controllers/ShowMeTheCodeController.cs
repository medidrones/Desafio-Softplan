using Medina.Api2.Softplan.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Medina.Api2.Softplan.Controllers
{
    [Route("api/showmethecode")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly IShowMeTheCodeService _showMeTheCodeService;

        public ShowMeTheCodeController(IShowMeTheCodeService showMeTheCodeService)
        {
            _showMeTheCodeService = showMeTheCodeService;
        }

        /// <summary>
        /// Retorna a URL do Repositório GIT da aplicação
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> ObterUrlGit()
        {
            return _showMeTheCodeService.ObterUrlGit();
        }
    }
}
