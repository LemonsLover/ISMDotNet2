using System;
using System.Threading;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a, b, y, step1, step2, step3;
            while (true)
            {
                Console.Write("Vvedite chislo x:");
                x = double.Parse(Console.ReadLine());
                Console.Write("Vvedite chislo a:");
                a = double.Parse(Console.ReadLine());
                Console.Write("Vvedite chislo b:");
                b = double.Parse(Console.ReadLine());

                step1 = 2.4f * Math.Abs((Math.Pow(x, 2) + b) / a);
                step2 = (a - b) * Math.Pow(Math.Sin(a - b), 2);
                step3 = Math.Pow(10, -2) * (x - b);
                y = step1 + step2 + step3;

                Console.WriteLine($"y = {y}");

            }
        }
    }
}
