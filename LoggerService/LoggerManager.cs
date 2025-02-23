using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using NLog;

namespace LoggerService
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger loger = LogManager.GetCurrentClassLogger();
        public LoggerManager()
        {
        }
        public void LogDebug(string message) => loger.Debug(message);
        
        public void LogError(string message) => loger.Error(message);

        public void LogInfo(string message) => loger.Info(message);
        
        public void LogWarn(string message) => loger.Warn(message);
    }
}
