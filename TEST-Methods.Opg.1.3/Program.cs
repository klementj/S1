using System;

namespace TEST_Methods.Opg1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(20, 20);

            void Calculate(int firstNumber, int secondNumber)
            {
                Console.WriteLine($"Addition af {firstNumber} og {secondNumber} er: {firstNumber + secondNumber}");
                Console.WriteLine($"Subtraction af {firstNumber} og {secondNumber} er: {firstNumber - secondNumber}");
                Console.WriteLine($"Multiplication af {firstNumber} og {secondNumber} er: {firstNumber * secondNumber}");
                Console.WriteLine($"Division af {firstNumber} og {secondNumber} er: {firstNumber / secondNumber}");
            }
        }
    }
}
