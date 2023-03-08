using System;

namespace NumerosRandomicos
{
    class Program
    {
        static void Main()
        {
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                int n = r.Next(9);
                Console.WriteLine(n);
            }
        }
    }
}