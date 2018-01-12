﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho = 100;

            

            for (int i = 1; i <=int.MaxValue; i++)
            {

               

                if (i%2!=0)
                {
                    healthGosho -= damagePesho;
                    if (healthGosho <= 0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");


                }
                else
                {
                    healthPesho -= damageGosho;
                    if (healthPesho <= 0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");


                }

                if (i % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
                
               
            }


        }
    }
}
