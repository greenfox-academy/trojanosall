﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumList
{
    public class Sum
    {
        public static int SumListElement(List<int> MyList)
        {
            if (MyList != null)
            {
                return MyList.Sum();
            }
            return 0;
        }

        // Sum

        //Create a sum method in your class which takes a List of integers as parameter
        //It should return the sum of the elements in the list
        //Follow these steps:
        //Add NUnit with NuGet to your project
        //Add NUnit Adapter also to your project
        //Add a Test class to your project
        //Add a new Test case in it
        //Instantiate your class (arrange, act, assert)
        //create a list of integers
        //use the Assert.AreEqual() to test the result of the created sum method
        //Run them
        //Create different tests where you
        //test your method with an empyt list
        //with a list with one element in it
        //with multiple elements in it
        //with a null
        //Run them
        //Fix your code if needed

    }
    
}
