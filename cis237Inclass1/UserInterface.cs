﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    static class UserInterface
    {
        public static int GetUserInput()
        {
            printMenu();

            string input = Console.ReadLine();

            while(input != "1" && input != "2")
            {
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();
                printMenu();
                input = Console.ReadLine();
            }

            return Int32.Parse(input);
        }

        public static void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        private static void printMenu()
        {
            Console.WriteLine("Whould would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }
    }
}
