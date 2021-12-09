using System;
using XDK.Application.Abstractions;
using XDK.Sample.Contracts.Application;
using XDK.Sample.Contracts.Domain;

namespace XDK.Sample.Application.Services;

public class TestAppService : BaseAppService, ITestAppService
{
    public TestAppService(IServiceProvider serviceProvider)
        : base(serviceProvider) { }

    public void Test()
    {
        GetDomainService<ITestDomainService>().Test();
    }
}