using CrossArchitecture.CoreModel;

namespace CrossArchitecture.CoreServices
{
    public class CoreService : ICoreService
    {
        public CoreModelEntity EscapeAndPrefix(CoreModelEntity coreModelEntity, string prefix)
        {
            return new CoreModelEntity($"{prefix}{coreModelEntity.Escape().Value}");
        }
    }
}
