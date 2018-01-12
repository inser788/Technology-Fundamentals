﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sign_of_Integer_Number
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSignOfNumber(n);
        }

       static void PrintSignOfNumber(int n)
        {
            if (n>0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n<0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}