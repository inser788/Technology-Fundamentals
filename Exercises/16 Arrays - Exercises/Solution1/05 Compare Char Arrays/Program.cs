﻿using System;
using System.Linq;


namespace _05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var arrayTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            string[] arrays = { new string(arrayOne), new string(arrayTwo) };
            Console.WriteLine(string.Join("\n",arrays.OrderBy(str => str)));



        }
    }
}
