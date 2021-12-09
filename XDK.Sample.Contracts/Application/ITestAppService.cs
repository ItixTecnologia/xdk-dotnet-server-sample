using XDK.Application.Abstractions;

namespace XDK.Sample.Contracts.Application;

public interface ITestAppService : IAppService
{
    void Test();
}