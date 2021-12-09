using System;
using XDK.Core.Abstractions;

namespace XDK.Sample.Models.Responses;

public class OrderResponse : BaseModel
{
    public decimal TotalAmount { get; set; }
    public OrderItemResponse[] Items { get; set; }
    public DateTime Date { get; set; }
    public bool IsCanceled { get; set; }
}