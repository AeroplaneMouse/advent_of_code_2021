using System;
using System.Collections.Generic;
using System.Text;

namespace day_02.Models
{
    public class SubmarineV2 : Submarine
    {
        public SubmarineV2(int depth, int distance, int aim)
            :base(depth, distance, aim)
        { }

        public override void Down(int units) => Aim += units;

        public override void Up(int units) => Aim -= units;

        public override void Forward(int units)
        {
            HorizontalDistance += units;
            Depth += Aim * units;
        }
    }
}
