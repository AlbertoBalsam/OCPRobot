using OCPRobot.Logging;
using OCPRobot.Validation;

namespace OCPRobot.Commands
{
    public interface IRobot
    {
        LogContext Logger { set; get; }
        bool PowerOn { get; set; }
        bool CanWalk { get; set; }
        void Move(int x, int y);
        void MoveRelative(int stepsX, int stepsY);
        void Grab();
        void Drop();

        // Övning 8:
        // 1. Svara på var jag är. 1. Fråga om någon står på en viss position.
    }
}
