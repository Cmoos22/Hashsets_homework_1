using System;
// This is needed for using stack and hashSet
using System.Collections.Generic;

namespace CS_Using_HashSet_
{
    // using code frome https://www.dotnetcurry.com/csharp/1362/hashset-csharp-with-examples
    class Program
    {
        static void Main(string[] args)
        {
            // SECTION 2. " Eliminating Duplicates in C# HashSet "
            Console.WriteLine("Using HashSet");
            //1. Defining String Array (Note that the string "mahesh" is repeated) 
            string[] names = new string[] {
                "mahesh",
                "vikram",
                "mahesh",
                "mayur",
                "suprotim",
                "saket",
                "manish"
            };
            //2. Length of Array and Printing array
            Console.WriteLine("Length of Array " + names.Length);
            Console.WriteLine();
            Console.WriteLine("The Data in Array");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            //3. Defining HashSet by passing an Array of string to it
            HashSet<string> hSet = new HashSet<string>(names);
            //4. Count of Elements in HashSet
            Console.WriteLine("Count of Data in HashSet " + hSet.Count);
            Console.WriteLine();
            //5. Printing Data in HashSet, this will eliminate duplication of "mahesh" 
            Console.WriteLine("Data in HashSet");
            foreach (var n in hSet)
            {
                Console.WriteLine(n);
            }
            // I had to delete Console.ReadLine();  to be able to print section 2 also else it just prints SECTION 1.
            // NOTE I  did not undestand why Looked it up link: https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/
            // it just hides the awenser until you press enter - but for ease of use I will comment it out 
            //Console.ReadLine();

            // SECTION 3. "Modify HashSet Using UnionWith() Method"

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

            //SECTION 4. "Modify Hashset Using ExceptWith() Method "

            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Data in HashSet before using Except With");
            Console.WriteLine("_________________________________");
            //storing data of hSetN3 in temporary HashSet
            HashSet<string> hSetN3 = new HashSet<string>(names1);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using Except With");
            Console.WriteLine("_________________________________");
            // here the program gets hSetN3 witch is just the names frome names1 groupe, it then uses exceptWith() methode
            // to subtract all the names mentuned in Names2 wich contains all names from Names2
            // deleting the names : suprotim, agarwal, suprotim, vikram,pendse and mitkari. witch are all the names in Names2
            // so ExceptWith deletes all the Names2 names from the "Data After Union". 
            hSetN3.ExceptWith(hSetN2);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }

            //SECTION 5.Modify Hashset using SymmetricExceptWith() method

            // this deletes the doublecate names but keeps the rest 
            HashSet<string> hSetN4 = new HashSet<string>(names1);
            Console.WriteLine("_________________________________");
            Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("HashSet 2");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            hSetN4.SymmetricExceptWith(hSetN2);
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
        }
    }
}