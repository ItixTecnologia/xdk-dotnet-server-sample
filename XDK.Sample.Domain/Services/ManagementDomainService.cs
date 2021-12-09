using System;
using XDK.Core.Models;
using XDK.Data.Abstractions;
using XDK.Domain.Abstractions;

namespace XDK.Sample.Domain.Services;

public class ManagementDomainService : BaseManagementDomainService<Guid>
{
    public ManagementDomainService(IServiceProvider serviceProvider, IUnitOfWork unitOfWork) : base(serviceProvider, unitOfWork) { }

    public override void ReportError(Guid id, ExtraErrorInfo<Guid> data)
    {
        var log = new LogData<Guid>(); // todo: obter da fonte de dados.
        log = UpdateLogData(log, data);

        throw new NotImplementedException();
    }
}