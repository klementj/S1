using System;

namespace TEST_Methods.Opg2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in Generate(10))
            {
                Console.WriteLine(number);
            }
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
    }
}
