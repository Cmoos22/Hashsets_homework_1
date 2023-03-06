using System;
// This is needed for using stack and hashSet
using System.Collections.Generic;

namespace CS_Using_HashSet_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Using HashSet");
            ////1. Defining String Array (Note that the string "mahesh" is repeated) 
            //string[] names = new string[] {
            //    "mahesh",
            //    "vikram",
            //    "mahesh",
            //    "mayur",
            //    "suprotim",
            //    "saket",
            //    "manish"
            //};
            ////2. Length of Array and Printing array
            //Console.WriteLine("Length of Array " + names.Length);
            //Console.WriteLine();
            //Console.WriteLine("The Data in Array");
            //foreach (var n in names)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.WriteLine();
            ////3. Defining HashSet by passing an Array of string to it
            //HashSet<string> hSet = new HashSet<string>(names);
            ////4. Count of Elements in HashSet
            //Console.WriteLine("Count of Data in HashSet " + hSet.Count);
            //Console.WriteLine();
            ////5. Printing Data in HashSet, this will eliminate duplication of "mahesh" 
            //Console.WriteLine("Data in HashSet");
            //foreach (var n in hSet)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.ReadLine();
            string[] names1 = new string[] {
             "mahesh","sabnis","manish","sharma","saket","karnik"
            };

            string[] Names2 = new string[] {
             "suprotim","agarwal","vikram","pendse","mahesh","mitkari"
            };
            //2.

            HashSet<string> hSetN1 = new HashSet<string>(names1);
            Console.WriteLine("Data in First HashSet");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_______________________________________________________________");
            HashSet<string> hSetN2 = new HashSet<string>(Names2);
            Console.WriteLine("Data in Second HashSet");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("________________________________________________________________");
            //3.
            Console.WriteLine("Data After Union");
            hSetN1.UnionWith(hSetN2);
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
        }
    }
}