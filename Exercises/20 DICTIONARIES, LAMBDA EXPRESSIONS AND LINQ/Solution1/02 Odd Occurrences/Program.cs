﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split().ToArray();
            var dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary[word] = 1;
                }
            }
            var output = new List<string>();
            foreach (var item in dictionary)
            {
                if (item.Value % 2 == 1)
                {
                    output.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
