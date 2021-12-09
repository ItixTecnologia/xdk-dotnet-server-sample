using System;
using XDK.Data.Abstractions;
using XDK.Domain.Abstractions;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Models;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Domain.Services;

public class UserDomainService : BaseEntityDomainService<User, UserModel, UserModel>, IUserDomainService
{
    public UserDomainService(IServiceProvider serviceProvider, IUnitOfWork unitOfWork)
        : base(serviceProvider, unitOfWork) { }
}