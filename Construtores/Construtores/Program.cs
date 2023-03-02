using System;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario s = new Salario(2000, 0.3);

        }

        class Salario
        {
            public double valor;
            public int mes;

            public Salario(double valor, double bonus)
            {
                this.valor = valor + valor * bonus;
            }

            public Salario(double valor, double bonus, int mes) : this(valor, bonus)
            {
                this.mes = mes;
            }

            public Salario()
            {
            }


            public void MostrarValor()
            {
                Console.WriteLine(valor);
            }
        }
    }
}