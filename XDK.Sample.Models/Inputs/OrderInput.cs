using XDK.Core.Abstractions;

namespace XDK.Sample.Models.Inputs;

public class OrderInput : BaseModel
{
    public OrderItemInput[] Items { get; set; }
}