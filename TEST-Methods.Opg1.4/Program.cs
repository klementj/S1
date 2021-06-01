using System;

namespace TEST_Methods.Opg1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPositive(100));

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

