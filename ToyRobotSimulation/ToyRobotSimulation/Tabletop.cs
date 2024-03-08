namespace ToyRobotSimulation
{
    internal class Tabletop : ITabletop
    {
        private const int Width = 5;
        private const int Height = 5;

        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < Width && y >= 0 && y < Height;
        }
    }
}
