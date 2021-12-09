using System;
using System.Collections.Generic;
using System.Text;

namespace day_02.Models
{
    public abstract class Submarine
    {
        public int Depth { get; set; }
        public int Aim { get; set; }
        public int HorizontalDistance { get; set; }

        public Submarine(int depth, int distance, int aim)
        {
            Depth = depth;
            HorizontalDistance = distance;
            Aim = aim;
        }

        public void Move(List<Instruction> instructions)
        {
            foreach (var instruction in instructions)
            {
                switch (instruction.Direction)
                {
                    case Instruction.Dir.Forward:
                        Forward(instruction.Distance);
                        break;
                    case Instruction.Dir.Down:
                        Down(instruction.Distance);
                        break;
                    case Instruction.Dir.Up:
                        Up(instruction.Distance);
                        break;
                    default:
                        throw new InvalidInstructionException("The given instruction is invalid", instruction);
                }
            }
        }

        public abstract void Forward(int units);

        public abstract void Up(int units);

        public abstract void Down(int units);
    }
}
