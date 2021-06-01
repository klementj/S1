using System;
using System.Collections.Generic;

namespace EX14Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            List<int> ages = new List<int>();
            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(51);

            List<string> names = new List<string>() { "Jens", "Karl", "Johannes", "Anton" };
            names.Add("Nicklas");


            // Opgave 2
            List<double> percentages = new List<double>() { 0.75, 0.23, 0.86, 0.17 };
            List<bool> areMarried = new List<bool>() { true, false, false, true, true };


            // Opgave 3
            // Udskrive opgave1 med for
            Console.WriteLine("Opgave 3.1");
            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine(ages[i]);
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            // Udskrive opgave2 med foreach
            Console.WriteLine("Opgave 3.2");
            foreach (double percentage in percentages)
            {
                Console.WriteLine(percentage);
            }

            foreach (bool foo in areMarried)
            {
                Console.WriteLine(foo);
            }


            // Opgave 4
            Console.WriteLine("Opgave 4");
            List<string> newNames = new List<string>() { "Hans", "Kristian", "Jens", "Karsten", "Ib" };

            foreach (string newName in newNames)
            {
                Console.WriteLine(newName);
            }

            newNames.Insert(3, "Anders");
            newNames.Insert(2, "Lars");


            // Opgave 5
            Console.WriteLine("Opgave 5 - fjerne elementer fra en liste");
            List<int> newAges = new List<int>() { 13, 14, 13, 15, 13, 14, 14, 15 };

            newAges.Remove(13); // Fjerne første 13
            newAges.Remove(15); // Fjerne første 15

            foreach (int age in newAges)
            {
                Console.WriteLine(age);
            }

            newAges.RemoveAt(2); // Fjerner tallet paa plads 3 [index 2]

            foreach (int age in newAges)
            {
                Console.WriteLine(age);
            }

        }
    }
}
