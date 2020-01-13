using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while(input != "exit")
            {
                Console.WriteLine("Skriv exit for at stoppe programmet");
                input = Console.ReadLine();
            }
        }
    }
}
