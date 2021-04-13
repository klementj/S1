using System;

namespace EX01HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string schoolName = "AspIT";

            Console.WriteLine(schoolName);

            schoolName = "Campus Vejle";
            Console.WriteLine(schoolName);

            string motto = "Fokuseret Talent";

            Console.WriteLine(schoolName);
            Console.WriteLine(" ");
            Console.WriteLine(motto);

            Console.WriteLine("--------------");

            Console.WriteLine($"{schoolName} er en skole i danmark hvor mottoet er: {motto}");
        }
    }
}
