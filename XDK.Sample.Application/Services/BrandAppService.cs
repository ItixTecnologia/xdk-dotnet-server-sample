using System;
using XDK.Application.Abstractions;
using XDK.Sample.Contracts.Application;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Models;

namespace XDK.Sample.Application.Services;

public class BrandAppService : BaseEntityAppService<IBrandDomainService, BrandModel, BrandModel>, IBrandAppService
{
    public BrandAppService(IServiceProvider serviceProvider)
        : base(serviceProvider) { }
}