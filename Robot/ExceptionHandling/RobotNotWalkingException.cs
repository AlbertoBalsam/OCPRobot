using System;

namespace OCPRobot.ExceptionHandling
{
    public class RobotNotWalkingException : Exception
    {
        public override string Message
        {
            get { return "I can't walk"; }
        }
    }
}