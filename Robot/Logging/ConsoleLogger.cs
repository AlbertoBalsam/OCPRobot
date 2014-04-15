using System;

namespace OCPRobot.Logging
{
    public class ConsoleLogger : ILoggingDevice
    {
        public void Log(string message)
        {
            Console.WriteLine("Console: " + message);
        }
    }
}