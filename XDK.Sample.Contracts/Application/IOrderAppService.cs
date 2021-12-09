using XDK.Application.Abstractions;
using XDK.Sample.Models.Inputs;
using XDK.Sample.Models.Responses;

namespace XDK.Sample.Contracts.Application;

public interface IOrderAppService : IEntityAppService<OrderInput, OrderResponse> { }