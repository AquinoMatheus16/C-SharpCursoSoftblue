using System;

namespace Enumerations
{
    /*class Program
    {
        static void Main()
        {
            Prioridade p1 = Prioridade.Media;
            int i = (int)p1;
            Console.WriteLine(i);
            
        }
    }

    enum Prioridade
    {
        Alta,
        Media,
        Baixa

        //Alta = 100,
        //Media 70,
        //Baixa 20
    }*/

    class Program
    {
        static void Main()
        {
            Elemento.Prioridade p1 = Elemento.Prioridade.Media;
            int i = (int)p1;
            Console.WriteLine(i);

        }
    }

    class Elemento
    {
        public enum Prioridade
        {
            Alta,
            Media,
            Baixa

            //Alta = 100,
            //Media 70,
            //Baixa 20
        }
    }

}