using CrossArchitecture.CoreModel;
using System.Collections.Generic;

namespace CrossArchitecture.Infrastructure
{
    public interface IInfrastructureEndpoint
    {
        string Send(IEnumerable<Entity> entities);
    }
}
