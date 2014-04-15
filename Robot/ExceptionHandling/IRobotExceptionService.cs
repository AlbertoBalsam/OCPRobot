using System;

namespace OCPRobot.ExceptionHandling
{
    public interface IRobotExceptionService
    {
        void Process(Exception ex);
    }
}