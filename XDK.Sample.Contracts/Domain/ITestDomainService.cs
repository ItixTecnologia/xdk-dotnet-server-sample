using XDK.Domain.Abstractions;

namespace XDK.Sample.Contracts.Domain;

public interface ITestDomainService : IDomainService
{
    void Test();
}