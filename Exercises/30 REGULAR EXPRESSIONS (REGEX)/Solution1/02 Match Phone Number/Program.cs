﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359( |\-)[2]\1\d{3}\1\d{4}\b";
            string phones = Console.ReadLine();
            MatchCollection matchedPhones = Regex.Matches(phones, regex);
            var collection = matchedPhones.Cast<Match>().Select(a => a.Value).ToArray();
            Console.WriteLine(string.Join(", ",collection));
        }
    }
}
