﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            switch (imperialUnit)
            {
                case "miles": double kilometers = value * 1.6; Console.WriteLine($"{value} {imperialUnit} = {kilometers:f2} kilometers");break;
                case "inches": double centimeters = value * 2.54; Console.WriteLine($"{value} {imperialUnit} = {centimeters:f2} centimeters"); break;
                case "feet": double centimeter = value * 30.0; Console.WriteLine($"{value} {imperialUnit} = {centimeter:f2} centimeters"); break;
                case "yards": double meters = value * 0.91; Console.WriteLine($"{value} {imperialUnit} = {meters:f2} meters"); break;
                case "gallons": double liters = value * 3.80; Console.WriteLine($"{value} {imperialUnit} = {liters:f2} liters"); break;





            }
        }
    }
}
