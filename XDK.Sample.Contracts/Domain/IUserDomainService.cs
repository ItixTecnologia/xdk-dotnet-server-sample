using XDK.Domain.Abstractions;
using XDK.Sample.Models;

namespace XDK.Sample.Contracts.Domain;

public interface IUserDomainService : IEntityDomainService<UserModel, UserModel> { }