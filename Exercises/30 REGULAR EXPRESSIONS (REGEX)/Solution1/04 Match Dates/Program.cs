﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})(\/|\-|\.)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string text = Console.ReadLine();
            MatchCollection collectionDates = Regex.Matches(text, regex);
            foreach (Match date in collectionDates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
