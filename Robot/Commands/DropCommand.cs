namespace OCPRobot.Commands
{
    public class DropCommand : IRobotCommand
    {
        private IRobot _robot;

        public DropCommand(IRobot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.Drop();
        }
    }
}