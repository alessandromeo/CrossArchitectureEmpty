using System.Linq;
using CrossArchitecture.ApplicationServices;
using CrossArchitecture.CoreModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CrossArchitecture.ApplicationInterface.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public TestController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet("{names}")]
        public IActionResult Get(string names)
        {
            var entities = names.Split("-").Select(name => new Entity(name)).ToList();
            var destinationFile = _applicationService.EscapeFirstByPrefixAndSend(entities, "Hello");
            return Ok(new {
                InputNames = names,
                EscapedEntities = entities,
                DestinationFile = destinationFile
            });
        }
    }
}
