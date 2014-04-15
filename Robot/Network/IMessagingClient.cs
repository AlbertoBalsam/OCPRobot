namespace OCPRobot.Network
{
    public interface IMessagingClient
    {
        void ReceiveMessage(IRobotMessage message, IMessagingClient sender);
    }
}