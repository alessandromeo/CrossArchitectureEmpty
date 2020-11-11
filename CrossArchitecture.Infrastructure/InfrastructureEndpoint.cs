using CrossArchitecture.CoreModel;
using System.IO;

namespace CrossArchitecture.Infrastructure
{
    public class InfrastructureEndpoint : IInfrastructureEndpoint
    {
        public void Send(CoreModelEntity coreModelEntity, string filePath)
        {
            File.WriteAllText(filePath,
                $"Sent to file entity with value: {coreModelEntity.Value}");
        }
    }
}
