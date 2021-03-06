﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var inputText = Console.ReadLine();
            var listOfElements = new List<string>();
            var elementsForSkip = inputNumbers[0];
            var elementsForTake = inputNumbers[1];
            Regex pattern = new Regex(@"\|<(\w{" + elementsForSkip + @"})(?<takedElements>\w{0," + elementsForTake + @"})");
            var solution = pattern.Matches(inputText);
            foreach (Match item in solution)
            {
                listOfElements.Add(item.Groups["takedElements"].Value);
            }
            Console.WriteLine(string.Join(", ", listOfElements));


        }
    }
}
