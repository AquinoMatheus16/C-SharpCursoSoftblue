using System;

namespace Finally
{
    class Program
    {
        static void Main()
        {
            try
            {
                Executar(true);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exceçao tratada");
            }
            finally
            {
                Console.WriteLine("Aplicação terminada");
            }
        }

        static void Executar(bool b)
        {
            if (b)
            {
                throw new ArgumentException();
            }
        }
    }
}