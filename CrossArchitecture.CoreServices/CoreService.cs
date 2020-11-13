using CrossArchitecture.CoreModel;
using System.Collections.Generic;
using System.Linq;

namespace CrossArchitecture.CoreServices
{
    public class CoreService : ICoreService
    {
        public void EscapeFirstByPrefix(ICollection<Entity> entities, string prefix) =>
            entities.
                Where(e => e.Name.StartsWith(prefix)).
                FirstOrDefault()?.Escape();
    }
}
