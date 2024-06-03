
using RobotSimulator.Enums;

namespace RobotSimulator.Services
{
    public class CommandProcessor
    {
        private readonly Robot _robot;

        public CommandProcessor(Robot robot)
        {
            _robot = robot;
        }

        public void ProcessCommand(string command)
        {
            var parts = command.Split(' ');

            switch (parts[0])
            {
                case "PLACE":
                    var placeParams = parts[1].Split(',');
                    int x = int.Parse(placeParams[0]);
                    int y = int.Parse(placeParams[1]);
                    Direction direction = Enum.Parse<Direction>(placeParams[2]);
                    _robot.Place(x, y, direction);
                    break;
                case "MOVE":
                    _robot.Move();
                    break;
                case "LEFT":
                    _robot.Left();
                    break;
                case "RIGHT":
                    _robot.Right();
                    break;
                case "REPORT":
                    Console.WriteLine(_robot.Report());
                    break;
            }
        }
    }
}

