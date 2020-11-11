using CrossArchitecture.CoreModel;

namespace CrossArchitecture.ApplicationServices
{
    public interface IApplicationService
    {
        CoreModelEntity EscapePrefixAndSend(CoreModelEntity coreModelEntity, string prefix, string filePath);
    }
}
