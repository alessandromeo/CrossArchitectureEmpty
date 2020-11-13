using CrossArchitecture.CoreModel;
using System.Collections.Generic;

namespace CrossArchitecture.CoreServices
{
    public interface ICoreService
    {
        void EscapeFirstByPrefix(ICollection<Entity> entities, string prefix);
    }
}
