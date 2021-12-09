using System;
using System.Collections.Generic;
using System.Text;

namespace day_02.Models
{
    class InvalidDirectionException : Exception
    {
        public string Direction { get; set; }

        public InvalidDirectionException(string message, string direction)
            : base(message)
        {
            Direction = direction;
        }
    }
}
