using Microsoft.OpenApi.Models;
using XDK.Core.Extensions;
using XDK.Data.EntityFramework.Extensions;
using XDK.Notification.AWS.Extensions;
using XDK.Sample.Application.Services;
using XDK.Sample.Contracts.Domain;
using XDK.Sample.Domain.Services;
using XDK.Sample.Persistence;
using XDK.Sample.UserInterface.Filters;
using XDK.UserInterface.API.Abstractions;

namespace XDK.Sample.UserInterface;

public class Startup : BaseOAuthSecurityStartup<SampleExceptionFilter, Guid>
{
    public Startup()
    {
        TypeFromContractsAssembly = typeof(IOrderDomainService);
        TypeFromDomainContractsAssembly = typeof(IOrderDomainService);
        TypeFromApplicationAssembly = typeof(OrderAppService);
        TypeFromDomainAssembly = typeof(OrderDomainService);
        TypeFromAutoMapperProfilesAssembly = typeof(SampleAutoMapperProfile);
        TypeForManagementService = typeof(ManagementDomainService);
        TypeFromPersistenceAssembly = typeof(SampleDatabaseContext);
    }

    public override void ConfigureServices(IServiceCollection services)
    {
        base.ConfigureServices(services);

        services
            .AddXdkNotification()
            .AddXdkPersistence<SampleDatabaseContext>() 
            .AddXdkPersistenceWithSpecificContext<SampleAdditionalDatabaseContext>()
            .AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "XDK.Sample.UserInterface", Version = "v1" }); });
    }

    public override void Configure(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "XDK.Sample.UserInterface v1"));
        }

        base.Configure(app);
    }

    protected override Dictionary<string, string> GetXDKVersions()
    {
        var baseVersions = base.GetXDKVersions();

        baseVersions.Add("XDK.Notification", typeof(Notification.Abstractions.INotificationClient).GetVersion());
        baseVersions.Add("XDK.Notification.AWS", typeof(Notification.AWS.NotificationClient).GetVersion());
        baseVersions.Add("XDK.Cloud", typeof(Cloud.Abstractions.IConnection).GetVersion());
        baseVersions.Add("XDK.Cloud.AWS", typeof(Cloud.AWS.Abstractions.BaseQueue).GetVersion());
        baseVersions.Add("XDK.Data.EntityFramework", typeof(Data.EntityFramework.Abstractions.BaseContext).GetVersion());

        return baseVersions;
    }
}