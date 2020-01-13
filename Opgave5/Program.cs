using System;

namespace Opgave5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Indtast et tal mellem 1 og 10");
                string input = Console.ReadLine();
                int numberInput = Int32.Parse(input);
                if (numberInput > 0 || numberInput < 11)
                {
                    break;
                }
            }
        }
    }
}
