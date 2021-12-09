using System;
using XDK.Data.Models;
using XDK.Domain.Abstractions;
using XDK.Sample.Models.Inputs;
using XDK.Sample.Models.Responses;

namespace XDK.Sample.Contracts.Domain;

public interface IOrderItemDomainService : IEntityDomainService<OrderItemInput, OrderItemResponse>
{
    PagedListModel<OrderItemResponse> GetByOrderId(Guid orderId);
}