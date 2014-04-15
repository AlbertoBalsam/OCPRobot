namespace OCPRobot.Commands
{
    public class MoveRelativeCommand : IRobotCommand
    {
        private IRobot _robot;

        public int XSteps { set; private get; }
        public int YSteps { set; private get; }

        public MoveRelativeCommand(IRobot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
         	_robot.MoveRelative(XSteps, YSteps);
        }
    }
}