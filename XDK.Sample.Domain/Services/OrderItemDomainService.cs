using System;
using XDK.Data.Abstractions;
using XDK.Data.Models;
using XDK.Domain.Abstractions;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Models.Inputs;
using XDK.Sample.Models.Responses;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Domain.Services;

public class OrderItemDomainService : BaseEntityDomainService<OrderItem, OrderItemInput, OrderItemResponse>, IOrderItemDomainService
{
    public OrderItemDomainService(IServiceProvider serviceProvider, IUnitOfWork unitOfWork)
        : base(serviceProvider, unitOfWork) { }

    public PagedListModel<OrderItemResponse> GetByOrderId(Guid orderId)
    {
        var result = UnitOfWork.GetRepository<OrderItem>().GetPagedList(oi => oi.OrderId == orderId);
        return Mapper.Map<PagedListModel<OrderItemResponse>>(result);
    }
}