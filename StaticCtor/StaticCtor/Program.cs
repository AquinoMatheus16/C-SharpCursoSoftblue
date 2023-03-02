using System;

namespace StaticCtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cambio.cotacaoDolar);
            Console.WriteLine(Cambio.cotacaoDolar);
        }

        class Cambio
        {
            public static double cotacaoDolar;

            static Cambio()
            {
                Console.WriteLine("GG");
                cotacaoDolar = 2.1;
            }
        }
    }
}