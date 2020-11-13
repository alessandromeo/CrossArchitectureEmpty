using CrossArchitecture.CoreModel;
using CrossArchitecture.CoreServices;
using CrossArchitecture.Infrastructure;
using System.Collections.Generic;

namespace CrossArchitecture.ApplicationServices
{
    public class ApplicationService : IApplicationService
    {
        private readonly ICoreService _coreService;

        private readonly IInfrastructureEndpoint _infrastructureEndpoint;

        public ApplicationService(ICoreService coreService, IInfrastructureEndpoint infrastructureEndpoint)
        {
            _coreService = coreService;
            _infrastructureEndpoint = infrastructureEndpoint;
        }

        public string EscapeFirstByPrefixAndSend(ICollection<Entity> entities, string prefix)
        {
            _coreService.EscapeFirstByPrefix(entities, prefix);
            return _infrastructureEndpoint.Send(entities);
        }
    }
}
