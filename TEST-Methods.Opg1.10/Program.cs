using System;

namespace TEST_Methods.Opg1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Median(new int[] { 2, 4, 100, 5, 10, 80 }));
        }
        
        static int Median(int[] array)
        {
            Array.Sort(array);
            // 2, 4, 5, 10, 80, 100

            if (IsEven(array.Length))
            {
                int firstNumber = array[(array.Length / 2) - 1];
                int secondNumber = array[array.Length / 2];
                return (firstNumber + secondNumber) / 2;
            }
            else
            {
                return array[array.Length / 2];
            }
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
