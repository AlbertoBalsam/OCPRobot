using System;

namespace OCPRobot.Logging
{
    public class PrinterLogger : ILoggingDevice
    {
        public void Log(string message)
        {
            Console.WriteLine("Printer: " + message);
        }
    }
}