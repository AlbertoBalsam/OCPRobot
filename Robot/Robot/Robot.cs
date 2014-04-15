using System;
using OCPRobot.ExceptionHandling;
using OCPRobot.Logging;
using OCPRobot.Network;
using OCPRobot.Validation;

namespace OCPRobot.Commands
{
    public class Robot : IRobot, IValidateable, IMessagingClient
    {
        private Position _position;
        private IMessagingMediator _messagingMediator;
        
        public LogContext Logger { get; set; }
        public bool PowerOn { get; set; }
        public bool CanWalk { get; set; }

        public Robot(LogContext logger, IMessagingMediator messagingMediator)
        {
            _messagingMediator = messagingMediator;
            Logger = logger;
        }

        public void Move(Position position)
        {
            _position = position;
            Logger.Log(String.Format("Moved to ({0}, {1})", _position.X, _position.Y));
        }

        public void Move(int x, int y)
        {
            Move(new Position(x, y));
        }

        public void MoveRelative(Position steps)
        {
            Move(_position + steps);
        }

        public void MoveRelative(int stepsX, int stepsY)
        {
            MoveRelative(new Position(stepsX, stepsY));
        }

        public Position GetPosition()
        {
            return _position;
        }

        public void Grab()
        {
            Logger.Log(String.Format("Grabbed object at ({0}, {1})", _position.X, _position.Y));
        }

        public void Drop()
        {
            Logger.Log(String.Format("Dropped object at ({0}, {1})", _position.X, _position.Y));
        }

        private void HandleMessage(CheckPositionMessage message)
        {
            IsPositionTakenMessage isPositionTakenMessage = new IsPositionTakenMessage();
            isPositionTakenMessage.Taken = (_position == message.Position);
            _messagingMediator.SendMessage(isPositionTakenMessage, this);
        }

        private void HandleMessage(IsPositionTakenMessage message)
        {
            CanWalk = !message.Taken && CanWalk;
        }

        public void ReceiveMessage(IRobotMessage message, IMessagingClient sender)
        {
            if (sender == this)
                return;

            if(message is CheckPositionMessage)
                HandleMessage((CheckPositionMessage)message);
            else
                HandleMessage((IsPositionTakenMessage)message);
        }
    }
}