using System;

namespace EX02Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Karsten";
            string lastName = "Hansen";
            int age = 35;

            Console.WriteLine($"{firstName} {lastName} er {age}år gammel");


            // Titel paa en bog
            string title = "Lord of the Rings - The Two Towers";
            // ISBN nummer
            long isbn = 978277391188;
            // Antal sider
            int pages = 400;
            // Pris
            double price = 249.95;

            Console.WriteLine($"title: {title}, ISBN: {isbn}, pages: {pages}, price: {price}.");
            Console.WriteLine(" ");


            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            Console.WriteLine($"MaxInt: {maxInt}");
            Console.WriteLine($"MinInt: {minInt}");
            Console.WriteLine("--------------------");

            uint maxUint = uint.MaxValue;
            uint minUint = uint.MinValue;
            Console.WriteLine($"MaxUint: {maxUint}");
            Console.WriteLine($"MinUint: {minUint}");
            Console.WriteLine("--------------------");

            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine($"MaxLong: {maxLong}");
            Console.WriteLine($"MinLong: {minLong}");
            Console.WriteLine("--------------------");

            byte maxByte = byte.MaxValue;
            byte minByte = byte.MinValue;
            Console.WriteLine($"MaxByte: {maxByte}");
            Console.WriteLine($"MinByte: {minByte}");
            Console.WriteLine("--------------------");

            short maxShort = short.MaxValue;
            short minShort = short.MinValue;
            Console.WriteLine($"MaxShort: {maxShort}");
            Console.WriteLine($"MinShort: {minShort}");
            Console.WriteLine("--------------------");
        }
    }
}
