using System.Collections.Generic;
using System.IO;
using CrossArchitecture.ApplicationServices;
using CrossArchitecture.CoreModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CrossArchitecture.ApplicationInterface.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EscapePrefixAndSendController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public EscapePrefixAndSendController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet("{value}")]
        public IDictionary<string, string> Get(string value)
        {
            var destinationFile = Path.GetTempFileName();
            return new Dictionary<string, string>
            {
                { "input value", value },
                { "elaborated value", _applicationService.EscapePrefixAndSend(
                    new CoreModelEntity(value), ">>> ", destinationFile).Value },
                { "destination file", destinationFile }
            };
        }
    }
}
