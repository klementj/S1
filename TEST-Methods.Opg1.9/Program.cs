using System;

namespace TEST_Methods.Opg1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Average(new int[] { 2, 4, 6, 8, 10 }));

            int Average(int[] numbersArr)
            {
                int sum = 0;

                foreach (int number in numbersArr)
                {
                    sum += number;
                }

                return sum / numbersArr.Length;
            }
        }
    }
}
