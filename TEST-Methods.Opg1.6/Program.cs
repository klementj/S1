using System;

namespace TEST_Methods.Opg1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsEven(2));

            bool IsEven(int number)
            {
                if (number % 2 == 0)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
