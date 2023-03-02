using System;

namespace EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*====== while ======*/
            /*	int x = 0;

                while (x<=10)
                {
                    Console.WriteLine(x);
                    x++;
                }*/

            /*====== do while ======*/
            /* int x = 0;

            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x <= 10); */

            /*====== FOR ======*/
            /*for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/

            /*for (int i = 0, y = 10; i <= 10; i++, y--)
            {
                Console.WriteLine( i + " " + y);
            }*/

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}