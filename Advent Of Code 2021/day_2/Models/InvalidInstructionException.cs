using System;
using System.Collections.Generic;
using System.Text;

namespace day_02.Models
{
    public class InvalidInstructionException : Exception
    {
        public Instruction Instruction { get; set; }

        public InvalidInstructionException(string message, Instruction instruction)
            : base(message)
        {
            Instruction = instruction;
        }
    }
}
