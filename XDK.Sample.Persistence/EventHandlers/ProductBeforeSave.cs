using System;
using System.Threading;
using System.Threading.Tasks;
using XDK.Data.Events;
using XDK.Data.Models.Enums;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.Persistence.EventHandlers;

public class ProductBeforeSave : BeforeSaveEntityNotificationHandler<Product>
{
    public override Task Handle(BeforeSaveEntityNotification<Product> notification, CancellationToken cancellationToken)
    {
        switch (notification.EntityState)
        {
            case EntityState.Added:
                break;
        }

        return Task.FromResult(0);
    }
}