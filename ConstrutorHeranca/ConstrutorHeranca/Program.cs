using System;

namespace ConstrutorHeranca
{
    class Program
    {
        static void Main()
        {
            Passaro p = new Passaro();
        }
    }

    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal()");
        }
    }

    class AnimalAlado : Animal
    {
        public AnimalAlado()
        {
            Console.WriteLine("AnimalAlado()");
        }
    }

    class Passaro : AnimalAlado
    {
        public Passaro() 
        {
            Console.WriteLine("Passaro()");
        }
    }
}