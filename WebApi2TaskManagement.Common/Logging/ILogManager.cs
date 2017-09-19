using System;
using log4net;

namespace WebApi2TaskManagement.Common.Logging
{
    public interface ILogManager
    {
        ILog GetLog(Type typeAssociatedWithRequestedLog);
    }
}
