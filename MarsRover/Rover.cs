using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public Position Position { get; }

        public PlateauDimensions PlateauDimensions { get; }

        public Rover(Position position, PlateauDimensions plateauDimensions)
        {
            Position = position;
            PlateauDimensions = plateauDimensions;
        }

        public void CompletePath(string path)
        {
            foreach (var movement in path)
            {
                switch (movement)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Move();
                        break;
                }
            }
        }

        private void Move()
        {
            switch (Position.Direction)
            {
                case Direction.E:
                    if (Position.X < PlateauDimensions.X)
                    {
                        Position.X++;
                    }
                    break;
                case Direction.W:
                    if (Position.X > 0)
                    {
                        Position.X--;
                    }
                    break;
                case Direction.N:
                    if (Position.Y < PlateauDimensions.Y)
                    {
                        Position.Y++;
                    }
                    break;
                case Direction.S:
                    if (Position.Y > 0)
                    {
                        Position.Y--;
                    }
                    break;
                default:
                    break;
            }
        }

        private void TurnLeft()
        {
            Position.Direction = (Direction) (((int) Position.Direction + 3) % 4);
        }

        private void TurnRight()
        {
            Position.Direction = (Direction) (((int) Position.Direction + 1) % 4);
        }
    }
}
