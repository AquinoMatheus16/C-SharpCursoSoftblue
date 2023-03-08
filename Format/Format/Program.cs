using System;

namespace Format
{
    class Program
    {
        static void Main()
        {
            //string cidade = "Manaus";
            //string estado = "Amazonas";

            //Console.WriteLine("Cidade: " + cidade + ", Estado: " + estado);
            //Console.WriteLine("Cidade: {0}, Estado: {1}", cidade, estado);

            //Console.WriteLine("{0, -10}{1,-15}", "Cidade", "Estado");
            //Console.WriteLine("{0, -10}{1,-15}", cidade, estado);

            //Console.WriteLine("Valor: {0:C}", 2534.30);
            //Console.WriteLine("Quntidade: {0:D5}", 35);
            //Console.WriteLine("Peso: {0:N2}", 56.21322);

            //Console.WriteLine("{0:0000000000}", 345);
            //Console.WriteLine("Telefone: {0:\\(##\\) ####-####}", 2299932302);

            string s = string.Format("Telefone: {0:\\(##\\) ####-####}", 2299932302);
            Console.WriteLine(s);
        }
    }
}