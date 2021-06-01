using System;

namespace TEST_Methods.Opg1._8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(HasEqualLength(new int[] { 10, 3, 4 }, new string[] { "Niels", "Sveskehud", "People" }));

            bool HasEqualLength(int[] numbersArr, string[] stringsArr)
            {
                if (numbersArr.Length == stringsArr.Length)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
