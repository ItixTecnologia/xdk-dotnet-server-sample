using Microsoft.EntityFrameworkCore;
using XDK.Core.Constants;
using XDK.Data.EntityFramework.Abstractions;

namespace XDK.Sample.Persistence;

public class SampleDatabaseContext : BaseContext
{
    public SampleDatabaseContext()
    {
        SourceAssemblies.Add(typeof(SampleDatabaseContext).Assembly);
    }

    protected override void Setup(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(HostSettings.Configuration["ConnectionStrings:DefaultConnection"]);
    }
}