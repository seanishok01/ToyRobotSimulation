namespace ToyRobotSimulation
{
    internal interface IRobot
    {
        void Place(int x, int y, Direction facing);
        void Move();
        void Left();
        void Right();
        void Report();
    }
}
