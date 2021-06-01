using System;

namespace TEST_Methods.Opg1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(new int[] { 2, 3, 5, 7, 8, 20 });

            void Print(int[] numbersArr) {
                foreach (int number in numbersArr)
                {
                    Console.WriteLine($"index: {number}");
                }

                for (int i = 0; i < numbersArr.Length; i++)
                {
                    Console.WriteLine($"On index: {i}, is the number: {numbersArr[i]}");
                }
            }
        }
    }
}
