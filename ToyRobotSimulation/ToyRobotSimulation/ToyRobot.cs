namespace ToyRobotSimulation
{
    public class ToyRobot : IRobot
    {
        private readonly ITabletop _tabletop;
        private int _x;
        private int _y;
        private Direction _facing;
        private bool _isPlaced;

        public ToyRobot(ITabletop tabletop)
        {
            _tabletop = tabletop;
        }

        public void Place(int x, int y, Direction facing)
        {
            if (_tabletop.IsValidPosition(x, y))
            {
                _x = x;
                _y = y;
                _facing = facing;
                _isPlaced = true;
            }
        }

        public void Move()
        {
            if (!_isPlaced)
                return;

            int newX = _x;
            int newY = _y;

            switch (_facing)
            {
                case Direction.NORTH:
                    newY++;
                    break;
                case Direction.EAST:
                    newX++;
                    break;
                case Direction.SOUTH:
                    newY--;
                    break;
                case Direction.WEST:
                    newX--;
                    break;
            }

            if (_tabletop.IsValidPosition(newX, newY))
            {
                _x = newX;
                _y = newY;
            }
        }

        public void Left()
        {
            if (_isPlaced)
            {
                _facing = (Direction)(((int)_facing + 3) % 4); // Rotate 90 degrees left
            }
        }

        public void Right()
        {
            if (_isPlaced)
            {
                _facing = (Direction)(((int)_facing + 1) % 4); // Rotate 90 degrees right
            }
        }

        public void Report()
        {
            if (_isPlaced)
            {
                Console.WriteLine($"Output: {_x},{_y},{_facing}");
            }
        }
    }
}
