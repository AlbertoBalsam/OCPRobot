using System.Collections.Generic;

namespace OCPRobot.Commands
{
    public class RobotCommandInvoker
    {
        private IList<IRobotCommand> _commands = new List<IRobotCommand>();

        public void Store(IRobotCommand command)
        {
            _commands.Add(command);
        }

        public void Execute()
        {
            foreach (IRobotCommand command in _commands)
                command.Execute();
        }
    }
}