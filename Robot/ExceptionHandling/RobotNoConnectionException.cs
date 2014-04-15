using System;

namespace OCPRobot.ExceptionHandling
{
    public class RobotNoConnectionException : Exception
    {
        public override string Message
        {
            get { return "I can't connect"; }
        }
    }
}