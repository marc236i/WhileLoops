using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast skole og by");
            int i = 0;
            string userInput = Console.ReadLine();
            while (i < userInput.Length)
            {
                string letter = userInput.Substring(i, 1);
                i++;
                Console.WriteLine($"{letter}");
            }
        }
    }
}
