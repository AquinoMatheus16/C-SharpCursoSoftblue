using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main()
        {
            //HashSet<string> dias = new HashSet<string>();
            //dias.Add("Segunda");
            //dias.Add("Terça");
            //dias.Add("Quarta");
            //dias.Add("Quinta");
            //dias.Add("Sexta");

            ////dias.Remove("Terça");


            //foreach (string dia in dias)
            //{
            //    Console.WriteLine(dia);
            //}

            SortedSet<string> dias = new SortedSet<string>();
            dias.Add("Segunda");
            dias.Add("Terça");
            dias.Add("Quarta");
            dias.Add("Quinta");
            dias.Add("Sexta");

            //dias.Remove("Terça");


            foreach (string dia in dias)
            {
                Console.WriteLine(dia);
            }


            //HashSet<Conta> contas = new HashSet<Conta>();
            //contas.Add(new Conta(3456));
            //contas.Add(new Conta(5681));
            //contas.Add(new Conta(2121));
            //contas.Add(new Conta(1279));
            //contas.Add(new Conta(1279));

            //foreach (Conta conta in contas)
            //{
            //    Console.WriteLine(conta.Numero);
            //}
        }
    }

    public class Conta : IEquatable<Conta>
    {
        public int Numero { get; set; }

        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Conta);
        }

        public bool Equals(Conta other)
        {
            if (other == null) return false;

            return this.Numero == other.Numero;
        }

        public override int GetHashCode()
        {
            int hash = 27;
            hash = (7 * hash) + Numero.GetHashCode();
            return hash;
        }
    }
}