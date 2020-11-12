using CrossArchitecture.CoreModel;

namespace CrossArchitecture.Infrastructure
{
    public interface IInfrastructureEndpoint
    {
        void Send(CoreModelEntity coreModelEntity, string filePath);
    }
}
