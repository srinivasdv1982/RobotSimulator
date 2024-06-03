using RobotSimulator.Enums;
using RobotSimulator.Models;


namespace RobotSimulator.Services
{
    public class Robot
    {
        private Position _position;
        private Direction _direction;
        private bool _isPlaced;
        private readonly Table _table;

        public Robot(Table table)
        {
            _table = table;
            _isPlaced = false;
        }

        public void Place(int x, int y, Direction direction)
        {
            var newPosition = new Position(x, y);
            if (_table.IsValidPosition(newPosition))
            {
                _position = newPosition;
                _direction = direction;
                _isPlaced = true;
            }
        }

        public void Move()
        {
            if (!_isPlaced) return;

            var newPosition = new Position(_position.X, _position.Y);
            switch (_direction)
            {
                case Direction.NORTH:
                    newPosition.Y++;
                    break;
                case Direction.SOUTH:
                    newPosition.Y--;
                    break;
                case Direction.EAST:
                    newPosition.X++;
                    break;
                case Direction.WEST:
                    newPosition.X--;
                    break;
            }

            if (_table.IsValidPosition(newPosition))
            {
                _position = newPosition;
            }
        }

        public void Left()
        {
            if (!_isPlaced) return;

            _direction = (Direction)(((int)_direction + 3) % 4);
        }

        public void Right()
        {
            if (!_isPlaced) return;

            _direction = (Direction)(((int)_direction + 1) % 4);
        }

        public string Report()
        {
            if (!_isPlaced) return "Robot is not placed on the table.";

            return $"{_position.X},{_position.Y},{_direction}";
        }
    }
}

