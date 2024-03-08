using ToyRobotSimulation;

ITabletop tabletop = new Tabletop();
IRobot robot = new ToyRobot(tabletop);

// Sample test data
string[] commands = File.ReadAllLines("commands.txt");

foreach (string command in commands)
{
    Console.WriteLine(command);
    string[] parts = command.Split(' ');
    string commandName = parts[0];

    switch (commandName)
    {
        case "PLACE":
            string[] placeArgs = parts[1].Split(',');
            int x = int.Parse(placeArgs[0]);
            int y = int.Parse(placeArgs[1]);
            Direction facing = (Direction)Enum.Parse(typeof(Direction), placeArgs[2]);
            robot.Place(x, y, facing);
            break;
        case "MOVE":
            robot.Move();
            break;
        case "LEFT":
            robot.Left();
            break;
        case "RIGHT":
            robot.Right();
            break;
        case "REPORT":
            robot.Report();
            break;
        case "": Console.WriteLine(); break;
        default:
            Console.WriteLine("Invalid command");
            break;
    }
}
