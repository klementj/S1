using System;

namespace TEST_Methods.Opg1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(100);

            void Calculate(int number)
            {
                if (IsPositive(number))
                {
                    Console.WriteLine(Math.Sqrt(number));
                }
                else
                {
                    Console.WriteLine("Add a positive number to calculate square root.");
                }
            }

            bool IsPositive(int number)
            {
                if (number > 0)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
