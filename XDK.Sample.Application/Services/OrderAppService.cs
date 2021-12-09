using System;
using XDK.Application.Abstractions;
using XDK.Sample.Contracts.Application;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Models.Inputs;
using XDK.Sample.Models.Responses;

namespace XDK.Sample.Application.Services;

public class OrderAppService : BaseEntityAppService<IOrderDomainService, OrderInput, OrderResponse>, IOrderAppService
{
    public OrderAppService(IServiceProvider serviceProvider)
        : base(serviceProvider) { }
}