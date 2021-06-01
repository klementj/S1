using System;

namespace TEST_Methods.Opg3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToString(new char[] { 't', 'e', 's', 't'}));
        }

        static string ToString(char[] array)
        {
            string foo = "";

            foreach (char elem in array)
            {
                foo += elem;
            }

            return foo;
        }
    }
}
