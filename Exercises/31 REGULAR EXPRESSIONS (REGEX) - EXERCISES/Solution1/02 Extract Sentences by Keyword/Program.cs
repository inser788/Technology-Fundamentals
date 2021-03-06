﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordForMatch = Console.ReadLine().Trim();
            wordForMatch = $@"\b{wordForMatch}\b";
            var text = Console.ReadLine().Split(new char[] { '.', '?', '!' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in text)
            {
                Match match = Regex.Match(item, wordForMatch);
                if (match.Success)
                {
                    Console.WriteLine(item.Trim());
                }

            }
        }
    }
}
