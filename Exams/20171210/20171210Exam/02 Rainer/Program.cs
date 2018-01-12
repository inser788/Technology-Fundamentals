﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequance = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int startIndex = sequance.Last();
            sequance.RemoveAt(sequance.Count - 1);

            var originalValues = sequance.ToArray();
            int steps = 0;
            while (true)
            {
                for (int i = 0; i < sequance.Count; i++)
                {
                    sequance[i]--;
                }
                if (sequance[startIndex]==0)
                {
                    break;
                }
                for (int i = 0; i < sequance.Count; i++)
                {
                    if (sequance[i] == 0)
                    {
                        sequance[i] = originalValues[i];
                    }
                }
                int nextIndex = int.Parse(Console.ReadLine());
                startIndex = nextIndex;
                steps++;
            }
            Console.WriteLine(string.Join(" ",sequance));
            Console.WriteLine(steps);
        }
    }
}