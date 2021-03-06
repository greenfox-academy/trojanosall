﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_V2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create Animal class
            // Every animal has a hunger value, which is a whole number
            // Every animal has a thirst value, which is a whole number
            // when creating a new animal object these values are created with the default 50 value
            // Every animal can eat() which decreases their hunger by one
            // Every animal can drink() which decreases their thirst by one
            // Every animal can play() which increases both by one

            var dog = new Animal("dog", 50, 50);

            dog.Play();

            Console.WriteLine(dog.GetHunger());
            Console.WriteLine(dog.GetThirst());

            Console.ReadKey();

        }
    }
}
