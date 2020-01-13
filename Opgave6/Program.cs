using System;

namespace Opgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Indtast 1 for at høre noget om køer");
                Console.WriteLine("Indtast 2 for at få rasultatet at 2*4");
                Console.WriteLine("Indtast 3 for at afslutet programmet");
                string input = Console.ReadLine();
                int numberInput = Int32.Parse(input);
                if (numberInput == 1)
                {

                }
                if (numberInput == 2)
                {
                    Console.WriteLine("2*4 = 8");
                }
                if (numberInput == 3)
                {
                    break;
                }
            }
        }
    }
}
