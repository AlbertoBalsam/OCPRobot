using System;
using OCPRobot.Commands;
using OCPRobot.Logging;
using OCPRobot.Network;
using OCPRobot.Scenarios;

namespace OCPRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            IRobotScenario moveBoxScenario = new RobotMoveBoxScenario();
            LogContext logger = new LogContext(new FileLogger());
            IMessagingMediator network = new MessagingMediator();
            IRobot ed209 = new Robot(logger, network);
            IRobot murphy = new Robot(logger, network);

            RobotCommandInvoker robotCommands = new RobotCommandInvoker();
            MoveRelativeCommand forward = new MoveRelativeCommand(ed209);
            MoveRelativeCommand back = new MoveRelativeCommand(ed209);
            GrabCommand grab = new GrabCommand(ed209);
            DropCommand drop = new DropCommand(ed209);

            forward.YSteps = 5;
            back.YSteps = -5;

            robotCommands.Store(forward);
            robotCommands.Store(grab);
            robotCommands.Store(back);
            robotCommands.Store(drop);

            robotCommands.Execute();
        }
    }
}
