using System;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Matematica.PI);

            Console.WriteLine(Matematica.E);
        }

        class Matematica
        {
            public const double PI = 3.1416;

            //public static readonly double E = 2.71828;

            //public static int x = 2;
            //public static readonly double E = 3 * x;

            public static readonly double E;

            static Matematica()
            {
                E = 2.71828;
            }
        }
    }
}