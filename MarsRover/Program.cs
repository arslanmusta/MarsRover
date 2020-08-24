using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var line = "";
                var rovers = new List<Rover>();

                var plateauDimensions = new PlateauDimensions();
                var plateau = Console.ReadLine();
                var plateauDimensionsValues = plateau.Split(' ');
                plateauDimensions.X = int.Parse(plateauDimensionsValues[0]);
                plateauDimensions.Y = int.Parse(plateauDimensionsValues[1]);


                line = Console.ReadLine();
                do
                {
                    var roverString = line.Split(' ');
                    var rover = new Rover(new Position(int.Parse(roverString[0]), int.Parse(roverString[1]), Enum.Parse<Direction>(roverString[2])), plateauDimensions);
                    rovers.Add(rover);

                    var path = Console.ReadLine();
                    rover.CompletePath(path);

                    line = Console.ReadLine();
                } while (!string.IsNullOrEmpty(line));

                rovers.ForEach(r => r.Position.Print());

                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Format is wrong.");
            }
            
        }
    }
}
