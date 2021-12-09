using Microsoft.EntityFrameworkCore;
using XDK.Core.Constants;
using XDK.Data.EntityFramework.Abstractions;

namespace XDK.Sample.Persistence;
public class SampleAdditionalDatabaseContext : BaseContext
{
    public SampleAdditionalDatabaseContext()
    {
        SourceAssemblies.Add(typeof(SampleAdditionalDatabaseContext).Assembly);
    }

    protected override void Setup(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(HostSettings.Configuration["ConnectionStrings:AdditionalConnection"]);
    }
}
