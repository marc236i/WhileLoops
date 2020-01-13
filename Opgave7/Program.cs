using System;

namespace Opgave7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
            int i2 = 10;
            do
            {
                Console.WriteLine(i2);
                i2--;
            } while (i2 < 11 && i2 > 0);
        }
    }
}
