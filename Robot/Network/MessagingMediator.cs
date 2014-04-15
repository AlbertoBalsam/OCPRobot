using System;
using System.Collections.Generic;

namespace OCPRobot.Network
{
    public class MessagingMediator : IMessagingMediator
    {
        private Action<IRobotMessage, IMessagingClient> _publisher;

        public void AddClient(IMessagingClient client)
        {
            _publisher += client.ReceiveMessage;
        }

        public void RemoveClient(IMessagingClient client)
        {
            _publisher -= client.ReceiveMessage;
        }

        public void SendMessage(IRobotMessage message, IMessagingClient sender)
        {
            _publisher(message, sender);
        }
    }
}