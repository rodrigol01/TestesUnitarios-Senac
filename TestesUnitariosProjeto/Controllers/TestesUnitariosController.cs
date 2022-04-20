using Microsoft.AspNetCore.Mvc;

namespace TestesUnitariosServiceFolder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestesUnitariosController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}