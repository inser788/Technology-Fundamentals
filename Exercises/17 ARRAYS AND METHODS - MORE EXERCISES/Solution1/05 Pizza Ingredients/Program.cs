﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var allIngredients = Console.ReadLine().Split().ToArray();
            int lengthOfMyIngredients = int.Parse(Console.ReadLine());
            int counter = 0;
            var myIngredient = new List<string>();
            for (int i = 0; i < allIngredients.Length && counter < 10; i++)
            {


                if (allIngredients[i].Length == lengthOfMyIngredients)
                {

                    Console.WriteLine($"Adding {allIngredients[i]}.");
                    myIngredient.Add(allIngredients[i]);
                    counter++;


                }
            }
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine("The ingredients are: " + string.Join(", ", myIngredient) + ".");

        }
    }
}
