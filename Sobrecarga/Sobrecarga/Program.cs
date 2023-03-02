using System;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematica m = new Matematica();
            int r1 = m.Somar(10, 5, 6);

            Console.WriteLine(r1);
        }

        class Matematica
        {
            public int Somar(int a, int b)
            {
                Console.WriteLine("Int");
                return a + b;
            }

            public int Somar(int a, int b, int c)
            {
                Console.WriteLine("Int");
                return a + b + c;
            }

            public double Somar(double a, double b)
            {
                Console.WriteLine("double");
                return a + b;
            }

            public long Somar(long a, long b)
            {
                Console.WriteLine("long");
                return a + b;
            }
        }
    }
}