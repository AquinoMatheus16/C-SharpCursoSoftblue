﻿using System;
using System.IO;

namespace ArquivosDiretorios
{
    class Program
    {
        static void Main()
        {
            //FileInfo file1 = new FileInfo(@"C:\Curso\arq1.txt");
            //file1.Create();

            //File.Create(@"C:\Curso\arq2.txt");

            //file1.CopyTo(@"C:\Curso\copia1.txt");
            //File.Copy(@"C:\Curso\arq2.txt", @"C:\Curso\copia@.txt");

            //Console.WriteLine("Nome: " + file1.Name);
            //Console.WriteLine("Extensão: " + file1.Extension);
            //Console.WriteLine("Diretório: " + file1.Directory);
            //Console.WriteLine("Completo: " + file1.FullName);

            //DirectoryInfo dir = new DirectoryInfo(@"C:\Curso\subdir1");
            //dir.Create();
            //Directory.CreateDirectory(@"C:\Curso\subdir2");

            //dir.MoveTo(@"C:\Curso\subdir2\subdir1");

            DirectoryInfo dir1 = new DirectoryInfo(@"C:\Curso\subdir1");
            //dir1.Create();

            //Directory.CreateDirectory(@"C:\Curso\subdir2");

            //string[] files = Directory.GetFiles(@"C:\Curso");

            //foreach (string file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //FileInfo[] files = dir1.GetFiles("c*");

            //DriveInfo[] drives = DriveInfo.GetDrives();

            //foreach (DriveInfo drive in drives)
            //{
            //    Console.WriteLine("Nome: {0}\nTipo: {1}\nPronto: {2}", drive.Name, drive.DriveType, drive.IsReady);
            //}

            //DriveInfo driveInfo = new DriveInfo(@"C:\");

            string conteudo = File.ReadAllText(@"C:\Curso\texto.txt");
            Console.WriteLine(conteudo);

            string[] linhas = { "texto da linha 1", "texto da linha 2" };
            File.WriteAllLines(@"C:\Curso\texto2.txt", linhas);
        }
    }
}
