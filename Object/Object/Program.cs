using System;

namespace Object
{
    class Program
    {
        static void Main()
        {
            Carro c = new Carro();
            c.Marca = "Ferrari";
            c.Ano = 2010;
            //string r = c.ToString();
            Console.WriteLine(c);

            int x = 10;
            string s = x.ToString();
            Console.WriteLine(s);

            string s2 = 10.ToString();
            true.Equals(true);
            21.3.Equals(21.3);
        }
    }

    public class Carro
    {
        public string Marca { get; set; }
        public int Ano { get; set; }

        public override string ToString()
        {
            return Marca + ", " + Ano;
        }
    }
}