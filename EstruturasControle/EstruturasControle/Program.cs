using System;

namespace EstruturasControle
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 5;

            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("31 dias");
                    break;

                case 2:
                    Console.WriteLine("28 dias");
                    break;

                case 4:
                    Console.WriteLine("30 dias");
                    break;
            }
        }
    }
}
