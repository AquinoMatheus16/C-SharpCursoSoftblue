using System;

namespace GenericsMetodos
{
    class Program
    {
        static void Main()
        {
            Creator c = new Creator();
            int i = c.Create<int>();
        }
    }

    public class Creator
    {
        public T Create<T>() where T : new()
        {
            return new T();
        }
    }
}