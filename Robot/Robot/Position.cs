namespace OCPRobot.Commands
{
    public struct Position
    {
        public int X;
        public int Y;
        
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Position operator +(Position position1, Position position2)
        {
            return new Position(position1.X + position2.X, position1.X + position2.Y);
        }

        public static bool operator ==(Position position1, Position position2)
        {
            return position1.X == position2.X && position1.Y == position2.Y;
        }

        public static bool operator !=(Position position1, Position position2)
        {
            return !(position1 == position2);
        }
    }
}