﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = new List<KeyValuePair<string, string>>();
            var broadcasts = new List<KeyValuePair<string, string>>();
            int counterMessages = 0;
            int counterBroadcasts = 0;
            string input = Console.ReadLine();
            try
            {



                while (input != "Hornet is Green")
                {
                    var command = input.Split(new string[] { " <-> " }, StringSplitOptions.None);
                    var queryFirst = command[0];
                    var querySecond = command[1];
                    if (queryFirst.All(d => char.IsDigit(d)) && querySecond.All(d => char.IsLetterOrDigit(d)))
                    {

                        queryFirst = new string(queryFirst.ToCharArray().Reverse().ToArray());
                        messages.Add(new KeyValuePair<string, string>(queryFirst, querySecond));
                        counterMessages++;
                        input = Console.ReadLine();

                    }
                    else if (!queryFirst.All(d => char.IsDigit(d)) && querySecond.All(d => char.IsLetterOrDigit(d)))
                    {
                        var querySecondString = string.Empty;
                        querySecond.ToCharArray();
                        for (int i = 0; i < querySecond.Length; i++)
                        {
                            char c = querySecond[i];
                            if (char.IsLetter(c))
                            {
                                if (char.IsUpper(c))
                                {
                                    querySecondString += char.ToLower(c);
                                }
                                else if (char.IsLower(c))
                                {
                                    querySecondString += char.ToUpper(c);
                                }
                            }

                            else
                            {
                                querySecondString += (c);
                            }

                        }
                        broadcasts.Add(new KeyValuePair<string, string>(querySecondString, queryFirst));
                        counterBroadcasts++;
                        input = Console.ReadLine();

                    }
                    else
                    {
                        input = Console.ReadLine();
                    }
                }
                Console.WriteLine("Broadcasts:");
                if (counterBroadcasts == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var br in broadcasts)
                    {
                        Console.WriteLine($"{br.Key} -> {br.Value}");
                    }
                }
                Console.WriteLine("Messages:");
                if (counterMessages == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var mess in messages)
                    {
                        Console.WriteLine($"{mess.Key} -> {mess.Value}");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine("None");
                Console.WriteLine("Messages:");
                Console.WriteLine("None");

            }
        }
    }
}