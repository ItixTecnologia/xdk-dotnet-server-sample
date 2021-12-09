using System;
using XDK.Application.Abstractions;
using XDK.Sample.Contracts.Application;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Models;

namespace XDK.Sample.Application.Services;

public class ProductAppService : BaseEntityAppService<IProductDomainService, ProductModel, ProductModel>, IProductAppService
{
    public ProductAppService(IServiceProvider serviceProvider)
        : base(serviceProvider) { }
}