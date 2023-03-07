using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.Peso = 4;
            a.Altura = 0.8;

            a.Mover();
            a.MostrarDados();


            Cachorro c = new Cachorro();
            c.Peso = 7.5;
            c.Altura = 1.1;

            c.Mover();
            c.MostrarDados();
            c.Latir();
        }
    }
}