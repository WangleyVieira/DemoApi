using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MensagemController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMensagem()
        {
			var mensagem = new { texto = "Comunicação com servidor ASP.NET Web API com sucesso!" };
			return Ok(mensagem);
		}
    }
}
