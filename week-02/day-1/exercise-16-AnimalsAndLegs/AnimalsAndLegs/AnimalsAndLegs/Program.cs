﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have

            Console.WriteLine("ALL LEGS CALCULATOR\n\n");

            Console.WriteLine("Please give me how many chickens are had by the farm: ");
            int ChickensNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease give me how many pigs are had by the farm: ");
            int PigsNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many legs all the animals have: " + (ChickensNumber * 2 + PigsNumber * 4));

            Console.ReadKey();
            
        }
    }
}
