using System;

namespace ObjectInitializar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contato c = new Contato();
            //c.Nome = "Matheus Aquino";
            //c.Telefone = "99924-3318";
            //c.Email = "matheus@gamil.com";
            //c.Endereco = "R. dos Limôes, 122";
            //c.MostrarInfo();

            Contato c = new Contato() { Nome = "Matheus Aquino", Telefone = "99924-3318", Email = "matheus@gamil.com", Endereco = "R. dos Limôes, 122" };
            c.MostrarInfo();

            Contato c2 = new Contato("Matheus Aquino") { Telefone = "99924-3318", Email = "matheus@gamil.com", Endereco = "R. dos Limôes, 122" };
            c2.MostrarInfo();
        }

    }

    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public Contato()
        {
            Console.WriteLine("Contato()");
        }

        public Contato(string nome)
        {
            Console.WriteLine("Contato(string)");
            this.Nome = nome;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Telefone: " + Telefone);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Endereço: " + Endereco);
        }
    }
}
