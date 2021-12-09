using System;
using XDK.Data.Abstractions;
using XDK.Domain.Abstractions;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Persistence.Entities;
using XDK.Sample.Persistence.Repositories;

namespace XDK.Sample.Domain.Services;

public class TestDomainService : BaseDomainService, ITestDomainService
{
    public TestDomainService(IServiceProvider serviceProvider, IUnitOfWork unitOfWork)
        : base(serviceProvider, unitOfWork) { }

    public void Test()
    {
        UnitOfWork.GetRepository<ProductRepository, Product>().UpdateStockUnits();
    }
}