using System;

namespace OCPRobot.Logging
{
    public class FileLogger : ILoggingDevice
    {
        public void Log(string message)
        {
            Console.WriteLine("File: " + message);
        }
    }
}