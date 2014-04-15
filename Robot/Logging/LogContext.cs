namespace OCPRobot.Logging
{
    public class LogContext
    {
        private ILoggingDevice _device;

        public LogContext(ILoggingDevice device)
        {
            _device = device;
        }

        public void Log(string message)
        {
            _device.Log(message);
        }
    }
}