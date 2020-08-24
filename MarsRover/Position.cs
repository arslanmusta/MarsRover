using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Position
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Direction Direction { get; set; }

        public Position(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public void Print()
        {
            Console.WriteLine($"{X} {Y} {Direction}");
        }
    }

    public enum Direction
    {
        N,
        E,
        S,
        W
    }
}
