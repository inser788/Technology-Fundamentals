﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int oldOfa = a;
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            a = b;
            
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {oldOfa}");



        }
    }
}
