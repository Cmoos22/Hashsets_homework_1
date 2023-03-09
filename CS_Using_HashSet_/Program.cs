using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CS_Using_HashSet
{
    class Program
    {

        static string[] names = new string[]
        {
         "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
         "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
         "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
         "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
         "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
         "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
         "Leena", "Neema", "Sita",
         "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis"

        };

        static void Main(string[] args)
        {
            // SECTION 2. " Eliminating Duplicates in C# HashSet "

            Console.WriteLine("Using HashSet");
            //1. Defining String Array (Note that the string "mahesh" is repeted) 
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

            //1.
            string[] names1 = new string[] {
                "mahesh","sabnis","manish","sharma","saket","karnik"
            };

            string[] names2 = new string[] {
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
            HashSet<string> hSetN2 = new HashSet<string>(names2);
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

            //SECTION 5. "Modify Hashset using SymmetricExceptWith() method"

            // this deletes the doublecate names but keeps the rest 
            HashSet<string> hSetN4 = new HashSet<string>(names1);
            Console.WriteLine("_________________________________");
            Console.WriteLine("Elements in both HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("HashSet 4");
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
            // I need to call this in main for it to work - like calling something in awake 

            Get_Add_Performance_HashSet_vs_List();
            Get_Contains_Performance_HashSet_vs_List();
            Get_Remove_Performance_HashSet_vs_List();

        }
        static void Get_Add_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while Adding Item");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Add(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while Adding Item");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Add(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

            /*List Performance while Adding Item 0.602 msEnds Here
            ____________________________________
            HashSet Performance while Adding Item
            0.155 ms
            Ends Here
            ____________________________________*/
            // so here hash set are faster then lists I dont know why as this should be the rewerse as the hashset have to compaire them all

        }
        static void Get_Contains_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while checking Contains operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Contains(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while checking Contains operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Contains(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        } /*List Performance while checking Contains operation
          0.020 ms
          Ends Here
        ____________________________________
        HashSet Performance while checking Contains operation
        0.037 ms
        Ends Here
        ____________________________________   */
        // here list out preforms hashsets IDK why its turned arround ? I cant figure it out.

        static void Get_Remove_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while performing Remove item operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Remove(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while performing Remove item operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Remove(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();
            /*List Performance while performing Remove item operation
            0.610 ms
            Ends Here
            ____________________________________
            HashSet Performance while performing Remove item operation
            0.001 ms
            Ends Here
            ____________________________________ */
        }
        // now it finaly makes sence again 
    }
}