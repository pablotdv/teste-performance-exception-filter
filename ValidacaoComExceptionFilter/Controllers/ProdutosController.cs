using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValidacaoComExceptionFilter;

namespace TestePerformanceValidcacaoComExceptionFilter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            throw new BusinessException("Validação por exception");
        }
    }
}
