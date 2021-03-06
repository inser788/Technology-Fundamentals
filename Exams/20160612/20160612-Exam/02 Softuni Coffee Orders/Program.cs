﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            var priceCoffee = 0.0m;
            var pricecoffeTotal = 0.0m;
            for (int i = 0; i < numberOfOrders; i++)
            {
                decimal pricePercapsule = decimal.Parse(Console.ReadLine());
                var orderDate = Console.ReadLine().Split('/').ToArray();
                int capsulesCount = int.Parse(Console.ReadLine());
                var day = orderDate.First();
                var month = int.Parse(orderDate.Skip(1).First());
                var year = int.Parse(orderDate.Last());
                decimal countDays =DateTime.DaysInMonth(year, month);
                priceCoffee = countDays * pricePercapsule * capsulesCount;
                Console.WriteLine($"The price for the coffee is: ${priceCoffee:f2}");
                pricecoffeTotal += priceCoffee;
            }
            Console.WriteLine($"Total: ${pricecoffeTotal:f2}");
        }
    }
}
