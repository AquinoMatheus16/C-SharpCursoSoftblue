using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main()
        {
            Animal a = new Cachorro();
            a.Falar();

            /*if (a is Cachorro)
            {
                Cachorro c = (Cachorro)a;
                c.Morder();
            }
            else
            {
                Console.WriteLine("O casting não pode ser feito");
            }*/

            Cachorro c = a as Cachorro;
            if (c != null)
            {
                c.Morder();
            }
            else
            {
                Console.WriteLine("O casting não pode ser feito");
            }
        }
    }

    public class Animal
    {
        public virtual void Falar()
        {
            Console.WriteLine("---");
        }
    }

    public class Cachorro : Animal
    {
        public override void Falar()
        {
            Console.WriteLine("Cachorro latindo");
        }

        public void Morder()
        {
            Console.WriteLine("Cachorro mordendo");
        }
    }

    public class Gato : Animal
    {
        public override void Falar()
        {
            Console.WriteLine("Gato miando");
        }
    }

}