using System;
using System.Collections.Generic;
using System.Text;

namespace day_02.Models
{
    class SubmarineV1 : Submarine
    {
        public SubmarineV1(int depth, int distance, int aim)
            : base(depth, distance, aim) 
        { }

        public override void Down(int units) => Depth += units;

        public override void Forward(int units) => HorizontalDistance += units;

        public override void Up(int units) => Depth -= units;
    }
}
