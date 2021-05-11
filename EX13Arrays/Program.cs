using System;

namespace EX13Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            int[] ages = new int[5] { 25, 28, 15, 35, 14 };

            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }

            
            // Opgave 2
            string[] names = new string[4] { "Sveskehud", "Discoørn", "Preben", "Daniel" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names[3] = "Kong Daniel"; 
            Console.WriteLine(names[3]);

            
            // Opgave 3
            int[] numbers = new int[10] { 7, 79, 95, 73, 78, 18, 76, 80, 60, 21 };
            
            foreach (int number in numbers)
            {
                Console.Write($"{number}, ");
            }

            Console.WriteLine("");
            Console.WriteLine("Sortered liste: ");
            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (int number in numbers)
            {
                Console.Write($"{number}, ");
            }


            // Opgave 4
            int[] randomNumbers = new int[10] { 3, 6, 9, 12, 15, 18, 21, 24, 100, 200 };

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] += 5;
                Console.WriteLine(randomNumbers[i]);
            }

            //foreach (int number in randomNumbers)
            //{
            //    Console.WriteLine(number + 5);
            //}

        }
    }
}
