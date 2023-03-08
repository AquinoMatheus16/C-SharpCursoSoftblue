using System;

namespace Exceptions
{
    class Prgram
    {
        static void Main()
        {
            try
            {
                object o = null;
                o.ToString();

                double r = Matematica.Dividir(10, 0);
                Console.WriteLine(r);
            }
            catch (ArgumentException ex)
            {
                //throw new ArgumentException(ex.Message);
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Referência null");
            }

            Console.WriteLine("FIM");

        }
    }

    public class Matematica
    {
        public static double Dividir(double n, double d)
        {
            if (d == 0)
            {
                throw new ArgumentException("O denominador não pode ser zero");
            }
            return n / d;
        }
    }
}