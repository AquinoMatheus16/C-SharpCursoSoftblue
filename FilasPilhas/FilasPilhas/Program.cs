using System;

namespace FilasPilhas
{
    class Program
    {
        static void Main()
        {
            Stack<char> stack = new Stack<char>();

            while (true)
            {
                Console.Write("Elemento: ");
                string s = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(s))
                {
                    break;
                }

                char c = s[0];

                stack.Push(c);
            }

            while(true)
            {
                char c = stack.Pop();
                Console.WriteLine(c);

                if (stack.Count == 0)
                {
                    break;
                }
            }

            //Queue<char> queue = new Queue<char>();

            //while (true)
            //{
            //    Console.Write("Elemento: ");
            //    string s = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(s))
            //    {
            //        break;
            //    }

            //    char c = s[0];

            //    queue.Enqueue(c);
            //}

            //while (true)
            //{
            //    char c = queue.Dequeue();
            //    Console.WriteLine(c);

            //    if (queue.Count == 0)
            //    {
            //        break;
            //    }
            //}
        }
    }
}