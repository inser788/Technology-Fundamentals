﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameBevarage = Console.ReadLine();
            double volumeProduct = double.Parse(Console.ReadLine());
            double energyProduct100ml = double.Parse(Console.ReadLine());
            double sugarProduct100ml = double.Parse(Console.ReadLine());

            double volumeCalculating = volumeProduct / 100.0;

            double energyAll = energyProduct100ml * volumeCalculating;
            double sugarAll = sugarProduct100ml * volumeCalculating;

            Console.WriteLine($"{volumeProduct}ml {nameBevarage}:");
            Console.WriteLine($"{energyAll}kcal, {sugarAll}g sugars");


        }
    }
}
