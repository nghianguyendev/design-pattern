using System;
using System.Collections.Generic;

namespace Strategy
{
    internal enum LogType
    {
        Console,
        File
    }

    internal interface ILog
    {
        void Info(string message);
    }

    internal class ConsoleLog : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }

    internal class FileLog : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine($"Write to file the message: {message}");
        }
    }

    internal class LogService
    {
        private IDictionary<LogType, ILog> _log = new Dictionary<LogType, ILog>();

        public LogService()
        {
            _log.Add(LogType.Console, new ConsoleLog());
            _log.Add(LogType.File, new FileLog());
        }

        public void Log(LogType logType, string message)
        {
            _log[logType].Info(message);
        }
    }
}