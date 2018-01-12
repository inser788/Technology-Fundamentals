﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int callories = 0;

            for (int i = 1; i <=rows; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                switch (ingredients)
                {
                    case "cheese": callories += 500; break;
                    case "tomato sauce": callories += 150; break;
                    case "salami": callories += 600; break;
                    case "pepper": callories += 50; break;

                }
            }
           
            Console.WriteLine($"Total calories: {callories}");
        }
    }
}
