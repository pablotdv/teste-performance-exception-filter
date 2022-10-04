using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ValidacaoSemException.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            return BadRequest($"SemException validação de exemplo");
        }
    }
}
