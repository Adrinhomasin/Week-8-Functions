using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi:");
            string username = Console.ReadLine();
            Console.WriteLine("sisestage oma perekonnanimi");
            string userlastname = Console.ReadLine();
            Console.WriteLine("sisestage oma sünniaasta");
            int userage = Convert.ToInt32(Console.ReadLine());
            
            Greetings(username, userlastname, userage);  
        }

        private static void Greetings(string someString, string anotherstring, int someint)
        {
            Console.WriteLine($"Tere, {someString} {anotherstring}!");
            Console.WriteLine($"oled {2021 - someint}");
        }
    }
}
