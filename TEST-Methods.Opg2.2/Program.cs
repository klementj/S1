using System;

namespace TEST_Methods.Opg2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(Generate(10));
        }

        static int[] Generate(int amountOfNumbers)
        {
            int[] randomNumbers = new int[amountOfNumbers];

            for (int i = 0; i < amountOfNumbers; i++)
            {
                randomNumbers[i] = new Random().Next();
            }
            return randomNumbers;
        }

        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"index {i}: {array[i]}");
            }
        }
    }
}
