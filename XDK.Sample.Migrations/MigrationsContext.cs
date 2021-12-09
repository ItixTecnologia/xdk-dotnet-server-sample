using Microsoft.EntityFrameworkCore;
using XDK.Sample.Persistence;

namespace XDK.Sample.Migrations;

/// <summary>
/// Contexto do projeto migrations.
/// Uso na CLI:
///     Editar csproj: https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet
///     Para adicionar uma nova migration: dotnet ef migrations add NomeDaMigration
///     Gerar script: dotnet ef migrations script -o ScriptUpdate.sql
/// Uso no Package Manager Console (https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/powershell):
///     Instalar: Microsoft.EntityFrameworkCore.Tools
///     Para adicionar uma nova migration: Add-Migration NomeDaMigration
///     Gerar script: Script-Migration -Output ScriptUpdate.sql
/// </summary>
public class MigrationsContext : SampleDatabaseContext
{
    protected override void Setup(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=tcp:xdk.database.windows.net,1433;Initial Catalog=xdk;Persist Security Info=False;User ID=xdk-admin;Password=N=PJ33%n}q%8:YcC;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
        );
    }
}