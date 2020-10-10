using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, n, z1, z2;
            while (true)
            {
                Console.Write("Vvedite chislo m:");
                m = double.Parse(Console.ReadLine());
                Console.Write("Vvedite chislo n:");
                n = double.Parse(Console.ReadLine());

                z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m, 3) * n) + (m * n) + Math.Pow(m, 2) - m);

                z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

                Console.WriteLine($"z1 = {z1}, z2 = {z2}\n");
            }
        }
    }
}
