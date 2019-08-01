using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transversal.Logger
{
    public class LoggerLog4Net : ILogger
    {
        public void Debug(string message, object target) => LogManager.GetLogger(target.GetType()).Debug(message);

        public void Error(string message, object target) => LogManager.GetLogger(target.GetType()).Error(message);

        public void Error(string message, Exception exception, object target) => LogManager.GetLogger(target.GetType()).Error(message, exception);

        public void Fatal(string message, object target) => LogManager.GetLogger(target.GetType()).Fatal(message);

        public void Fatal(string message, Exception exception, object target) => LogManager.GetLogger(target.GetType()).Fatal(message, exception);

        public void Info(string message, object target) => LogManager.GetLogger(target.GetType()).Info(message);

        public void Warn(string message, object target) => LogManager.GetLogger(target.GetType()).Warn(message);
    }
}
