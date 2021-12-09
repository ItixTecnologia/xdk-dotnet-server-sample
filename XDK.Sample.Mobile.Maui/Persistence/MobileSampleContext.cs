using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Essentials;
using System.IO;
using XDK.Data.EntityFramework.Abstractions;

namespace XDK.Sample.Mobile.Maui.Persistence
{
    public class MobileSampleContext : BaseContext
    {
        public MobileSampleContext()
        {
            SourceAssemblies.Add(typeof(MobileSampleContext).Assembly);
            SQLitePCL.Batteries_V2.Init();
            Database.EnsureCreated();
        }

        protected override void Setup(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "MobileSample.db3");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
