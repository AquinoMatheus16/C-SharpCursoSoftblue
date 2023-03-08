using System;

namespace ClassesAbstratas
{
    public abstract class Bebida
    {
        public void Preparar()
        {
            Console.WriteLine("Início");
            AdicionarAgua();
            AdicionarSubstania();
            AdicionarAcucar();
            Console.WriteLine("Bebida preparada");
        }

        public abstract void AdicionarAgua();
        public abstract void AdicionarSubstania();
        public abstract void AdicionarAcucar();
    }

    public class Cafe : Bebida
    {
        public override void AdicionarAcucar()
        {
            Console.WriteLine("áqua quente");
        }

        public override void AdicionarAgua()
        {
            Console.WriteLine("Café");
        }

        public override void AdicionarSubstania()
        {
            Console.WriteLine("Uma colher de açucar");
        }
    }

    public class Cha : Bebida
    {
        public override void AdicionarAcucar()
        {
            Console.WriteLine("áqua quente");
        }

        public override void AdicionarAgua()
        {
            Console.WriteLine("Chá");
        }

        public override void AdicionarSubstania()
        {
            Console.WriteLine("Uma colher de açucar");
        }
    }
}
