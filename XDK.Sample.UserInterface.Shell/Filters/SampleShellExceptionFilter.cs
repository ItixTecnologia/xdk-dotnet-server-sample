using System.Text.Json;
using XDK.Cloud.Azure.Models;
using XDK.Core.Constants;
using XDK.Core.Models;
using XDK.Core.Models.Enums;
using XDK.UserInterface.API.Abstractions;

namespace XDK.Sample.UserInterface.Shell.Filters;

public class SampleShellExceptionFilter : BaseExceptionFilter
{
    protected override async Task<string> LogExceptionAsync(ExceptionData exceptionData)
    {
        await Task.Delay(0);

        if (Server.Environment == EnvironmentType.Production)
        {
            // var record = await _logTable.AddOrUpdateAsync(new LogData
            var logData = new LogData
            {
                Severity = LogSeverity.Error,
                IsException = true,
                StackTrace = exceptionData.Exception.StackTrace,
                Message = exceptionData.Exception.Message,
                ExtraData = JsonSerializer.Serialize(
                    new
                    {
                        exceptionData.Exception.StackTrace,
                        exceptionData.Exception.Message
                    }
                )
            };
            return logData.RowKey;
        }

        return Guid.NewGuid().ToString();
    }

    protected override string GetDefaultExceptionMessage()
    {
        return "Mensagem de erro padrão: Erro no servidor.";
    }
}