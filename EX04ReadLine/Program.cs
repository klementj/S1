using System;

namespace EX04ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firstname");
            string firstName = Console.ReadLine();

            Console.WriteLine("Lastname");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Velkommen {firstName} {lastName}");


            // Udregn summen af to tal
            Console.WriteLine("Skriv det første tal");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv det andet tal");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            Console.WriteLine($"Summen af dine tal er: {sum}");
            Console.WriteLine(" ");

            // Ekstraopgave 4.4 Arealudregning
            Console.WriteLine("Udregn areal af to tal");
            Console.WriteLine("Hvor lang er side eet i meter?");
            int firstSide = int.Parse(Console.ReadLine());

            Console.WriteLine("Hvor lang er side to i meter?");
            int secondSide = int.Parse(Console.ReadLine());

            int area = firstSide * secondSide;

            Console.WriteLine(area);
        }
    }
}
