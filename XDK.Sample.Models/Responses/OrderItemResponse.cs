using System;
using XDK.Core.Abstractions;

namespace XDK.Sample.Models.Responses;

public class OrderItemResponse : BaseModel
{
    public Guid ProductId { get; set; }
    public Guid OrderId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitValue { get; set; }
}