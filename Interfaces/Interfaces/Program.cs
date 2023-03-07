using System;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            Carro c = new Carro();
            c.Ligar();
            c.Roubar();
        }
    }

    public interface IMotorizado
    {
        void Ligar();
        string NomeMotor { get; set; }
    }

    public interface IRoubavel
    {
        void Roubar();
    }

    class Carro : IMotorizado, IRoubavel
    {
        private string nomeMotor;

        public string NomeMotor
        {
            get
            {
                return nomeMotor;
            }

            set
            {
                this.nomeMotor = value;
            }
        }

        public void Ligar()
        {
            Console.WriteLine("Carro ligado");
        }

        public void Roubar()
        {
            Console.WriteLine("Carro roubado");
        }
    }
}