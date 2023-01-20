using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 2 tal. ");
            Console.Write("Tal 1: ");
            int Tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tal 2: ");
            int Tal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Tal1 + " + " + Tal2 + " = " + (Tal1+Tal2));
            Console.WriteLine(Tal1 + " * " + Tal2 + " = " + (Tal1*Tal2));

        }
    }
}
