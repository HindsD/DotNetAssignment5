﻿using System;
using System.IO;

namespace DotNetTicketSysCLASSES
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Tickets.csv";
            string choice;
            do
            {
                Console.WriteLine("1) List all tickets.");
                Console.WriteLine("2) Create new ticket.");
                Console.WriteLine("Enter any other key to exit.");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (File.Exists(file))
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                }
                else if (choice == "2")
                {

                }
            } while (choice == "1" || choice == "2");
        }
    }
}
