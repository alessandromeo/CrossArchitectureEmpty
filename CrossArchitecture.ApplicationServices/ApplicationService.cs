using CrossArchitecture.CoreModel;
using CrossArchitecture.CoreServices;
using CrossArchitecture.Infrastructure;

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

        public CoreModelEntity EscapePrefixAndSend(CoreModelEntity coreModelEntity, string prefix, string filePath)
        {
            var resultingEntity = _coreService.EscapeAndPrefix(coreModelEntity, prefix);
            _infrastructureEndpoint.Send(resultingEntity, filePath);
            return resultingEntity;
        }
    }
}
