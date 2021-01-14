using Medina.Api1.Softplan.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Medina.Api1.Softplan.Controllers
{
    [Route("api/taxaJuros")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        private readonly ITaxaDeJurosService _taxaDeJurosService;

        public JurosController(ITaxaDeJurosService taxaDeJurosService)
        {
            _taxaDeJurosService = taxaDeJurosService;
        }


        /// <summary>
        /// Retorna a taxa de juros com valor estático: 0.01
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<decimal> ObterTaxaJuros()
        {
            return _taxaDeJurosService.Obter();
        }
    }
}
