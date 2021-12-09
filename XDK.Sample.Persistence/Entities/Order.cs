using System;
using System.Collections.Generic;
using System.Linq;
using XDK.Data.Abstractions.Entities;

namespace XDK.Sample.Persistence.Entities;

/// <summary>
/// Pedido.
/// </summary>
public class Order : BaseEntity
{
    /// <summary>
    /// Valor total.
    /// </summary>
    public virtual decimal TotalAmount => Items.Sum(i => i.Quantity * i.UnitValue);

    /// <summary>
    /// Itens do pedido.
    /// </summary>
    public ICollection<OrderItem> Items { get; set; }

    /// <summary>
    /// Data da compra.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Indica se está cancelado.
    /// </summary>
    public bool IsCanceled { get; set; }

    public Order()
    {
        Items = new HashSet<OrderItem>();
    }
}