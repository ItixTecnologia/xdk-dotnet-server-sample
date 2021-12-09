using System;
using XDK.Application.Abstractions;
using XDK.Data.Models;
using XDK.Sample.Models.Inputs;
using XDK.Sample.Models.Responses;

namespace XDK.Sample.Contracts.Application;

public interface IOrderItemAppService : IEntityAppService<OrderItemInput, OrderItemResponse>
{
    PagedListModel<OrderItemResponse> GetByOrderId(Guid orderId);
}