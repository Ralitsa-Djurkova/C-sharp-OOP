using Solid.Appender;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Loggers
{
    class Logger : ILogger
    {
        private IAppender appender;
        public Logger(IAppender appender)
        {
            this.appender = appender;
        }

        public void Error(string date, string message)
        {
            this.appender.Append(date, "Info", message);
        }

        public void Info(string date, string message)
        {
            this.appender.Append(date, "Error", message);
        }
    }
}
