using System;
using System.Collections.Generic;
using System.Text;

namespace Transversal.Logger
{
    public interface ILogger
    {
        void Debug(String message, object target);
        void Info(String message, object target);
        void Warn(String message, object target);
        void Error(String message, object target);
        void Error(String message, Exception exception, object target);
        void Fatal(String message, object target);
        void Fatal(String message, Exception exception, object target);
    }
}
