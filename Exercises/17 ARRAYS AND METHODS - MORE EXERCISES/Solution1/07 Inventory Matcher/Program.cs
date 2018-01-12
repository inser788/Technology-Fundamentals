﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameOfProducts = Console.ReadLine().Split().ToArray();
            long[] quantityOfProducts = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] priceOfProducts = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            for (int i = 0; i < int.MaxValue; i++)
            {
                string currentProduct = Console.ReadLine();
                if (currentProduct=="done")
                {
                    return;
                }
                int index = Array.IndexOf(nameOfProducts, currentProduct);
                Console.WriteLine($"{currentProduct} costs: {priceOfProducts[index]}; Available quantity: {quantityOfProducts[index]}");
            }
        }
    }
}