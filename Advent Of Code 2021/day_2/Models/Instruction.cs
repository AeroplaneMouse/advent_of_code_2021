using System;
using System.Collections.Generic;
using System.Text;

namespace day_02.Models
{
    public partial class Instruction
    {
        public enum Dir
        {
            Forward,
            Up,
            Down
        }

        public Dir Direction { get; }

        public int Distance { get; }

        public Instruction(string stringInstruction)
        {
            string[] instruction = stringInstruction.Split(' ');

            Direction = instruction[0].ToLower() switch
            {
                "forward" => Dir.Forward,
                "up" => Dir.Up,
                "down" => Dir.Down,
                _ => throw new InvalidDirectionException("The provided string direction is invalid", instruction[0].ToLower())
            };
            Distance = int.Parse(instruction[1]);
        }

        public Instruction(Dir direction, int distance)
        {
            Direction = direction;
            Distance = distance;
        }
    }
}
