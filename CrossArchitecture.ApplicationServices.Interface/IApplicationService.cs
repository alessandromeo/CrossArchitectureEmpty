using CrossArchitecture.CoreModel;
using System.Collections.Generic;

namespace CrossArchitecture.ApplicationServices
{
    public interface IApplicationService
    {
        string EscapeFirstByPrefixAndSend(ICollection<Entity> entities, string prefix);
    }
}
