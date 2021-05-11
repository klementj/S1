using System;

namespace EX07SelectionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {

            // 7.1 Rabat ved mere end 1000kr i salg.
            Console.Write("Skriv hvad du ønsker at handle for");
            double price = double.Parse(Console.ReadLine());

            double discount = 0;

            if (price > 1000)
            {
                discount = price * 0.05;
                //{discount:C2} Ny ting i VS. format specifier. <---------------------- God viden!
                Console.WriteLine($"Du får {discount:C2} i rabat!");
            } 
            else
            {
                Console.WriteLine($"Du får ingen rabat, din fattiglus");
            }

            
             
            // 7.2 To tal der er ens
            Console.WriteLine("Indtast første tal");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast andet tal");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("Tillykke!!! De to tal parset til int er ens");
            }
            else
            {
                Console.WriteLine("De to tal er ikke ens");
            }



            // 7.3 Beregn division. Når der ikke divideres med 0
            Console.Write("Indtast første tal");
            int inputOne = int.Parse(Console.ReadLine());
            Console.Write("Indtast andet tal");
            int inputTwo = int.Parse(Console.ReadLine());

            if (inputTwo == 0)
            {
                Console.WriteLine("FEJL! Det andet tal må ikke være 0");
            }
            else
            {
                double division = (double)inputOne / (double)inputTwo;
                Console.WriteLine($"De to tal divideret med hinanden er {division}");
            }



            // 7.4 Udskriv det højeste tal af to
            Console.Write("Indtast et heltal");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Indtast et andet heltal");
            int numberTwo = int.Parse(Console.ReadLine());



        }
    }
}
