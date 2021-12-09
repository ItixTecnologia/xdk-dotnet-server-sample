using System.Threading;
using System.Threading.Tasks;
using XDK.Data.Events;
using XDK.Data.Models.Enums;
using XDK.Sample.Persistence.Entities;
using XDK.Security.Tools;

namespace XDK.Sample.Persistence.EventHandlers;

public class UserBeforeSave : BeforeSaveEntityNotificationHandler<User>
{
    public override Task Handle(BeforeSaveEntityNotification<User> request, CancellationToken cancellationToken)
    {
        if (request.EntityState == EntityState.Added)
        {
            request.Entity.Password = PasswordHelper.GenerateHash(request.Entity.Password);
        }

        return Task.FromResult(0);
    }
}