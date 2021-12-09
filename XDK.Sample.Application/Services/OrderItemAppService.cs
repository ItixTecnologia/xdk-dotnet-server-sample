using System;
using XDK.Application.Abstractions;
using XDK.Data.Models;
using XDK.Sample.Contracts.Application;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Models.Inputs;
using XDK.Sample.Models.Responses;

namespace XDK.Sample.Application.Services;

public class OrderItemAppService : BaseEntityAppService<IOrderItemDomainService, OrderItemInput, OrderItemResponse>, IOrderItemAppService
{
    public OrderItemAppService(IServiceProvider serviceProvider)
        : base(serviceProvider) { }

    public PagedListModel<OrderItemResponse> GetByOrderId(Guid orderId)
    {
        return GetDomainService<IOrderItemDomainService>().GetByOrderId(orderId);
    }
}