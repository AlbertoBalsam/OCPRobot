namespace OCPRobot.Commands
{
    public class MoveCommand : IRobotCommand
    {
        private IRobot _robot;

        public int X { set; private get; }
        public int Y { set; private get; }

        public MoveCommand(IRobot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.Move(X, Y);
        }
    }
}
