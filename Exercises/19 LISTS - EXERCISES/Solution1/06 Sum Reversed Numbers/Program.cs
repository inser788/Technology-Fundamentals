﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                var currentNumberString = currentNumber.ToString();
                var reversedNumberArray = currentNumberString.Reverse().ToArray();
                var reversedNumberString = new string(reversedNumberArray);
                numbers[i] = int.Parse(reversedNumberString);
            }
            Console.WriteLine(numbers.Sum());
            
        }
    }
}
