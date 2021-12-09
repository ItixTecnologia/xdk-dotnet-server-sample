using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using XDK.Data.Abstractions;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Domain.Specifications;

public class OldCanceledOrdersWithItemsSpecification : BaseSpecification<Order>
{
    private readonly int _itemsAmount;

    public OldCanceledOrdersWithItemsSpecification(int itemsAmount)
    {
        _itemsAmount = itemsAmount;
        PageSize = 50;
        Include = orders => orders.Include(o => o.Items);
        OrderBy = orders => orders.OrderBy(o => o.Date);
    }

    public override Expression<Func<Order, bool>> IsSatisfiedBy()
    {
        return order => order.Date <= DateTime.Now.AddDays(-30)
            && order.IsCanceled
            && order.Items.Sum(i => i.Quantity) >= _itemsAmount;
    }
}