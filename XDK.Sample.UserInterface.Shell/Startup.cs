using Microsoft.OpenApi.Models;
using XDK.Core.Extensions;
using XDK.Sample.UserInterface.Shell.Filters;
using XDK.UserInterface.API.Abstractions;

namespace XDK.Sample.UserInterface.Shell;

public class Startup : BaseStartup<SampleShellExceptionFilter, Guid>
{
    public override void ConfigureServices(IServiceCollection services)
    {
        base.ConfigureServices(services);

        services
            .AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "XDK.Sample.UserInterface.Shell", Version = "v1" }); });
    }

    public override void Configure(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "XDK.Sample.UserInterface.Shell v1"));
        }

        base.Configure(app);
    }

    protected override Dictionary<string, string> GetXDKVersions()
    {
        var baseVersions = base.GetXDKVersions();

        baseVersions.Add("XDK.Cloud", typeof(Cloud.Abstractions.IConnection).GetVersion());

        return baseVersions;
    }
}