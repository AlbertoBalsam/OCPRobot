using System;

namespace OCPRobot.ExceptionHandling
{
    public class RobotOutOfMemoryException : Exception
    {
        public override string Message
        {
            get { return "I have no memory"; }
        }

        public override string StackTrace
        {
            get { return "Hehe!\n" + base.StackTrace; }
        }
    }
}