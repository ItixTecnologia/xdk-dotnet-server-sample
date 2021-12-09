using System;
using XDK.Core.Abstractions;

namespace XDK.Sample.Models.Inputs;

public class OrderItemInput : BaseModel
{
    public Guid ProductId { get; set; }
    public Guid OrderId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitValue { get; set; }
}