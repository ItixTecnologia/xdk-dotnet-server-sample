using System;
using XDK.Data.Abstractions.Entities;

namespace XDK.Sample.Persistence.Entities;

/// <summary>
/// Item de pedido.
/// </summary>
public class OrderItem : BaseEntity
{
    /// <summary>
    /// ID do produto.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Produto.
    /// </summary>
    public Product Product { get; set; }

    /// <summary>
    /// ID do pedido.
    /// </summary>
    public Guid OrderId { get; set; }

    /// <summary>
    /// Pedido.
    /// </summary>
    public Order Order { get; set; }

    /// <summary>
    /// Quantidade.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Valor unitário.
    /// </summary>
    public decimal UnitValue { get; set; }
}