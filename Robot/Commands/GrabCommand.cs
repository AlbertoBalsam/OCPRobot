namespace OCPRobot.Commands
{
    public class GrabCommand : IRobotCommand
    {
        private IRobot _robot;

        public GrabCommand(IRobot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.Grab();
        }
    }
}