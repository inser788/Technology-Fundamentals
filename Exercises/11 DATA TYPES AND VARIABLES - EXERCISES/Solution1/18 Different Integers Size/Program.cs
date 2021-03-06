﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            long number;
            var line = Console.ReadLine();
            var canFitInLong = long.TryParse(line, out number);

            if (!canFitInLong)
            {
                Console.WriteLine($"{line} can't fit in any type");
                return;
            }

            


            Console.WriteLine($"{number} can fit in:");
            if (number >=sbyte.MinValue&&number<=sbyte.MaxValue)
            {
                Console.WriteLine("* sbyte");
            }
            if (number >= byte.MinValue && number <= byte.MaxValue)
            {
                Console.WriteLine("* byte");
            }
            if (number >= short.MinValue && number <= short.MaxValue)
            {
                Console.WriteLine("* short");
            }
            if (number >= ushort.MinValue && number <= ushort.MaxValue)
            {
                Console.WriteLine("* ushort");
            }
            if (number >= int.MinValue && number <= int.MaxValue)
            {
                Console.WriteLine("* int");
            }
            if (number >= uint.MinValue && number <= uint.MaxValue)
            {
                Console.WriteLine("* uint");
            }
            if (number >= long.MinValue && number <= long.MaxValue)
            {
                Console.WriteLine("* long");
            }
        }
    }
}
