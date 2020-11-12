using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CrossArchitecture.ApplicationInterface.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string value)
        {
            return Redirect("escapeprefixandsend/Hello%20World%21");
        }
    }
}
