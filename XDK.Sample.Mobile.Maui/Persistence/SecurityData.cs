using System;
using XDK.Mobile.Abstractions;

namespace XDK.Sample.Mobile.Maui.Persistence
{
    public class SecurityData : BaseSecurityData<Guid>
    {
        public SecurityData()
        {
            Id = Guid.NewGuid();
        }
    }
}
