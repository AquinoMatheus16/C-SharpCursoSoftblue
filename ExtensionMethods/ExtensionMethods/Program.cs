using System;

namespace ExtensionMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente(2132, 4324);
            c1.Titular = "Matheus Aquino";
            c1.Depositar(200);
            c1.Sacar(50);
            c1.MostrarSaldo();

            ContaCorrente c2 = new ContaCorrente(2387, 9864);
            c1.Transferir(100, c2 );
            c2.MostrarSaldo();

        }
    }
}