namespace OCPRobot.Network
{
    public class IsPositionTakenMessage : IRobotMessage
    {
        public string Message
        {
            get { return "Is position taken?"; }
        }

        public bool Taken { get; set; }
    }
}