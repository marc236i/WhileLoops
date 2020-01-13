using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Indtast et tal");
                string userInput = Console.ReadLine();
                int numberInput = Int32.Parse(userInput);
                sum = sum + numberInput;
                i++;
            }
            
            Console.WriteLine($"Resultatet af tallene er {sum}");
        }
    }
}
