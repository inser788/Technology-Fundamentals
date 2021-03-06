﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            decimal totalSum = 0.0m;
            for (int i = 0; i < numberOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var dateInput = Console.ReadLine().Split('/').ToList();
                int capsulesCount = int.Parse(Console.ReadLine());
                int month = int.Parse(dateInput.Skip(1).First());
                int year = int.Parse(dateInput.Last());
                var countDays = DateTime.DaysInMonth(year, month);
                decimal priceForCurrentOrder = (pricePerCapsule * countDays) * capsulesCount;
                Console.WriteLine($"The price for the coffee is: ${priceForCurrentOrder:f2}");
                totalSum += priceForCurrentOrder;
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
