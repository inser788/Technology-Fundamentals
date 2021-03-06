﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var listOfTop5Numbers = new List<int>();
            var averageNumber = numbersInput.Average();
            for (int i = 0; i < numbersInput.Length; i++)
            {
                var currentNumber = numbersInput[i];
                if (currentNumber>averageNumber)
                {
                    listOfTop5Numbers.Add(currentNumber);
                }
            }
           listOfTop5Numbers= listOfTop5Numbers.OrderByDescending(x => x).ToList();
            var output = listOfTop5Numbers.Take(5).ToList();
            if (output.Any())
            {
                Console.WriteLine(string.Join(" ",output));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
