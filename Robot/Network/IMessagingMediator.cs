namespace OCPRobot.Network
{
    public interface IMessagingMediator
    {
        void AddClient(IMessagingClient client);
        void RemoveClient(IMessagingClient client);
        void SendMessage(IRobotMessage message, IMessagingClient sender);
    }
}