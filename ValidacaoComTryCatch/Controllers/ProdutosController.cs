using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValidacaoComTryCatch;

namespace ValidacaoComTryCatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                throw new BusinessException("Validação por exception");
            }
            catch (BusinessException ex)
            {
                return BadRequest($"TryCatch {ex.Message}");
            }
        }
    }
}
