using System;

namespace EX06bComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            // View -> Other Windows -> C# Interactive
            // Leg med de forskellige operatorer i det interactive vindue

            // Opgave 2
            bool i = 17 < 10;
            Console.WriteLine($"17 < 20 = {i}");

            bool ii = 20 < 20;
            Console.WriteLine($"20 < 20 = {ii}");

            bool iii = 20 <= 20;
            Console.WriteLine($"20 <= 20 = {iii}");

            bool iv = 50 != 10 * 5;
            Console.WriteLine($"50 != 10 * 5 = {iv}");

            bool v = 27 - 0.15 >= 29 - 1.15;
            Console.WriteLine($"27 - 0.15 >= 29 - 1.15 = {v}");

            bool vi = 5 * 3 == 15;
            Console.WriteLine($"5 * 3 == 15 = {vi}");

            bool vii = 5 / 5 == 1;
            Console.WriteLine($"5 / 5 == 1 = {vii}");
        }
    }
}
