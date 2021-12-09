using System;
using XDK.Data.Abstractions;
using XDK.Domain.Abstractions;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Domain.Specifications;
using XDK.Sample.Models.Inputs;
using XDK.Sample.Models.Responses;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Domain.Services;

public class OrderDomainService : BaseEntityDomainService<Order, OrderInput, OrderResponse>, IOrderDomainService
{
    public OrderDomainService(IServiceProvider serviceProvider, IUnitOfWork unitOfWork)
        : base(serviceProvider, unitOfWork) { }

    public override OrderResponse Create(OrderInput data, bool shouldSave = true)
    {
        var entity = UnitOfWork.GetRepository<Order>().Add(new Order { Id = (Guid)data.Id });
        var orderItemDomainService = GetDomainService<OrderItemDomainService>();
        new CheapProductsRunningOutSpecification(2).Not();

        foreach (var orderItem in data.Items)
        {
            orderItemDomainService.Create(orderItem);
        }

        return ToResponse<OrderResponse>(entity);
    }
}