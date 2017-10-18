﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string!

            string sentence = "lopadotemachoselachogaleokranioleipsanodrimhypotrimmatosilphioparaomelitokatakechymenokichlepikossyphophattoperisteralektryonoptekephalliokigklopeleiolagoiosiraiobaphetraganopterygon";

            //Query Syntax
            var letterQuery = from letter in sentence.ToLower().Replace(" ", "")
                group letter by letter
                into newletters
                select newletters;

            Console.WriteLine("Output of Query Syntax");
            foreach (var letterDictionaryElement in letterQuery)
            {
                Console.WriteLine("Letter " + letterDictionaryElement.Key + " appears " + letterDictionaryElement.Count() + " times");
            }

            Console.ReadKey();

        }
    }
}
