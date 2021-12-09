using XDK.Application.Abstractions;
using XDK.Sample.Models;

namespace XDK.Sample.Contracts.Application;

public interface IUserAppService : IEntityAppService<UserModel, UserModel> { }