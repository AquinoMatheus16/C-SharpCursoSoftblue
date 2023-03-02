using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? n = null;

            if (n == null)
            {
                Console.WriteLine("Valor nulo");
            }

            if (!n.HasValue)
            {
                Console.WriteLine("Valor nulo 2");
            }

            int x = n ?? 0;
            Console.WriteLine(x);
        }
    }
}