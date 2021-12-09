using System;
using XDK.Application.Abstractions;
using XDK.Sample.Contracts.Application;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Models;

namespace XDK.Sample.Application.Services;

public class UserAppService : BaseEntityAppService<IUserDomainService, UserModel, UserModel>, IUserAppService
{
    public UserAppService(IServiceProvider serviceProvider)
        : base(serviceProvider) { }
}