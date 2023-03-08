using System;

namespace ApplicationExceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                ContaCorrente c = new ContaCorrente();
                c.Depositar(200);
                c.Sacar(400);
            }
            catch (ContaCorrenteException e)
            {
                Console.WriteLine("Erro");
                Console.WriteLine("Mensagem: " + e.Message);
                Console.WriteLine("Local: " + e.TargetSite);
                Console.WriteLine("Stacktrace: " + e.StackTrace);
            }
        }
    }
}