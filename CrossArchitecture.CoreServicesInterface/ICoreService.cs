using CrossArchitecture.CoreModel;

namespace CrossArchitecture.CoreServices
{
    public interface ICoreService
    {
        CoreModelEntity EscapeAndPrefix(CoreModelEntity coreModelEntity, string prefix);
    }
}
