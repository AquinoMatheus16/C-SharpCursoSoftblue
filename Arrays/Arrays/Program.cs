using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            //double[] notas = new double[3];
            //notas[0] = 6.5;
            //notas[1] = 9.0;
            //notas[2] = 8.5;
            //Console.WriteLine(notas[0]);

            //double[] notas = { 6.5, 8.4, 10.9 };

            //Console.WriteLine(notas[0]);
            //Console.WriteLine(notas[1]);
            //Console.WriteLine(notas[2]);

            //Contato[] contatos = new Contato[10];
            //Contato c1 = new Contato();
            //c1.Nome = "José Silva";
            //c1.Telefone = "9932-3293";
            //contatos[0] = c1;

            char[,] tabuleiro = new char[3, 3];
            tabuleiro[0, 0] = 'X';
            tabuleiro[1, 0] = 'O';
        }
    }

    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
