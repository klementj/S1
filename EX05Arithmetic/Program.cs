using System;

namespace EX05Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.1 Lommeregner v.1 
            Console.WriteLine("Indtast et tal, efterfulgt af enter: ");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Indtast endnu et tal, efterfulgt af enter: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            double addition = firstNumber + (double)secondNumber;
            Console.WriteLine($"Resultatet af de to tal lagt sammen er: {addition}");


            // 5.1 Lommeregner v.2 
            double subtraction = firstNumber - (double)secondNumber;
            Console.WriteLine($"Resultatet af de to tal trukket fra hinanden: {subtraction}");

            double multiplication = firstNumber * (double)secondNumber;
            Console.WriteLine($"Resultatet af de to tal ganget sammen: {multiplication}");

            if (secondNumber != 0)
            {
                double division = firstNumber / (double)secondNumber;
                Console.WriteLine($"Resultatet af de to tal divideret med hinanden : {division}");
            }


            // 5.1 Lommeregner v.3 
            double modulo = firstNumber % secondNumber;
            Console.WriteLine($"Resultatet af de to tal modulo med hinanden: {modulo}");

        }
    }
}
