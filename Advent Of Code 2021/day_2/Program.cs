using day_02.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Instruction> instructions = new List<Instruction>();
            string[] input = File.ReadAllLines("../../../Input/instructions.txt");
            foreach (string strInt in input)
                instructions.Add(new Instruction(strInt));

            Submarine sub = new SubmarineV1(0, 0, 0);
            sub.Move(instructions);
            DisplayResults("Submarine v1", sub);

            Console.WriteLine();

            Submarine subV2 = new SubmarineV2(0, 0, 0);
            subV2.Move(instructions);
            DisplayResults("Submarine v2", subV2);

        }

        private static void DisplayResults(string title, Submarine sub)
        {
            Console.WriteLine($"### {title} ###");
            Console.WriteLine($"Distance: {sub.HorizontalDistance}");
            Console.WriteLine($"Depth:    {sub.Depth}");
            Console.WriteLine($"Answer:   {sub.HorizontalDistance * sub.Depth}");
        }
    }
}
