using XDK.Domain.Abstractions;
using XDK.Sample.Models.Inputs;
using XDK.Sample.Models.Responses;

namespace XDK.Sample.Contracts.Domain;

public interface IOrderDomainService : IEntityDomainService<OrderInput, OrderResponse> { }