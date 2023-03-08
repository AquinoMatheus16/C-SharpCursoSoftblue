using System;
using System.Data;

namespace Datas
{
    class Program
    {
        static void Main()
        {
            //DateTime d = DateTime.Now;
            DateTime d = new DateTime(1970, 10, 2);
            Console.WriteLine(d);

            DayOfWeek dow = d.DayOfWeek;
            Console.WriteLine(dow);

            DateTime d2 = DateTime.Now;
            Console.WriteLine(d2);
            DateTime d3 = DateTime.Today;
            Console.WriteLine(d3);

            DateTime d4 = d.AddMonths(5);
            Console.WriteLine(d4);
            DateTime d5 = d.AddMonths(-5);
            Console.WriteLine(d5);

            TimeSpan ts = new TimeSpan(3, 25, 10);
            DateTime d6 = new DateTime(1980, 2, 3, 10, 0, 0);
            DateTime d7 = d6.Add(ts);
            Console.WriteLine(d7);
            DateTime d8 = d6.Subtract(ts);
            Console.WriteLine(d8);
        }
    }
}