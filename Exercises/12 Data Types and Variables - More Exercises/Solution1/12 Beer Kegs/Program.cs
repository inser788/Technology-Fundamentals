﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            double volumeOfKeg = 0.0;
            string biggestKeg = String.Empty;
            for (int i = 0; i < numberOfLines; i++)
            {
                string kegModel = Console.ReadLine();
                float radiusOfKeg = float.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());

               double volumeOfKegNew = radiusOfKeg * radiusOfKeg * heightOfKeg * Math.PI;
                if (volumeOfKegNew>volumeOfKeg)
                {
                    volumeOfKeg = volumeOfKegNew;
                    biggestKeg = kegModel;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
