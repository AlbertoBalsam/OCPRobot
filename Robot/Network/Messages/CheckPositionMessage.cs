using OCPRobot.Commands;

namespace OCPRobot.Network
{
    public class CheckPositionMessage : IRobotMessage
    {
        public string Message
        {
            get { return "Check position message"; }
        }

        public Position Position { get; set; }
    }
}