using System;
using System.IO;

namespace ArquivosDiretorios
{
    class Program
    {
        static void Main()
        {
            FileInfo file1 = new FileInfo(@"C:\Curso\arq1.txt");
            //file1.Create();

            //File.Create(@"C:\Curso\arq2.txt");

            //file1.CopyTo(@"C:\Curso\copia1.txt");
            //File.Copy(@"C:\Curso\arq2.txt", @"C:\Curso\copia@.txt");

            Console.WriteLine("Nome: " + file1.Name);
            Console.WriteLine("Extensão: " + file1.Extension);
            Console.WriteLine("Diretório: " + file1.Directory);
            Console.WriteLine("Completo: " + file1.FullName);

        }
    }
}
