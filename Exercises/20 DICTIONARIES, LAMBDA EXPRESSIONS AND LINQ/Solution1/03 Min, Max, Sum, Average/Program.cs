﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            var listOfNumbers = new List<int>();
            for (int i = 0; i < countNumbers; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                listOfNumbers.Add(currentNumber);
            }
            Console.WriteLine($"Sum = {listOfNumbers.Sum()}");
            Console.WriteLine($"Min = {listOfNumbers.Min()}");
            Console.WriteLine($"Max = {listOfNumbers.Max()}");
            Console.WriteLine($"Average = {listOfNumbers.Average()}");

        }
    }
}
