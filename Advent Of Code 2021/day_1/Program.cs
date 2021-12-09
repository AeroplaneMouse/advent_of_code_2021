using System;
using System.Collections.Generic;
using System.IO;

namespace day_01
{
    public partial class Program
    {
        public enum Depth
        {
            Increased,
            Decreased,
            Nothing
        }

        static void Main(string[] args)
        {
            // Get input
            var input = File.ReadAllLines("../../../input/readings.txt");

            // Compute changes for window of size 1
            DisplayResult(input, windowSize: 1);
            Console.WriteLine();
            DisplayResult(input, windowSize: 3);
        }

        private static void DisplayResult(string[] input, int windowSize)
        {
            var changes = ComputeChanges(input, windowSize);
            Console.WriteLine($"Window size: { windowSize }");
            foreach (Depth key in changes.Keys)
                Console.WriteLine($"{key}: {changes[key]}");
        }
        
        private static Dictionary<Depth, int> ComputeChanges(string[] input, int windowSize)
        {
            // Initialize
            var changes = new Dictionary<Depth, int>
            {
                { Depth.Increased, 0 },
                { Depth.Decreased, 0 },
                { Depth.Nothing, 0 }
            };

            // Compute
            int limit = input.Length - windowSize + 1;
            for (int index = 1; index < limit; index++)
            {
                int previous = ComputeWindow(input, index - 1, windowSize);
                int current = ComputeWindow(input, index, windowSize);
                float diff = previous - current;

                if (diff < 0f)
                    changes[Depth.Increased]++;
                else if (diff == 0f)
                    changes[Depth.Nothing]++;
                else
                    changes[Depth.Decreased]++;
            }

            return changes;
        }

        private static int ComputeWindow(string[] input, int startIndex, int size)
        {
            int result = 0;
            for(int index = startIndex; index < startIndex + size; index++)
            {
                result += int.Parse(input[index]);
            }

            return result;
        }
    }
}
