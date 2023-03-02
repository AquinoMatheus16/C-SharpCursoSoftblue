using System;

namespace Parametros1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();

            int i = 5;
            m.Trocar(ref i);
            Console.WriteLine(i);

            Numero num = new Numero();
            num.n = 5;
            m.Mudar(num);

            Console.WriteLine(num.n);
        }

        class MyClass
        {
            public void Trocar(ref int x)
            {
                x = 10;
            }

            public void Mudar(Numero x)
            {
                x.n = 10;
            }
        }

        class Numero
        {
            public int n;
        }
    }
}