using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CrossArchitecture.ApplicationInterface.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() =>
            Redirect("Test/Good%20morning%21-Hello%20World%21-Hello%20Everybody%21");
    }
}
