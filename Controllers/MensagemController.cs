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
            return Ok("Olá");
        }
    }
}
