using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ulong n;
                double sum = 0;
                Console.Write("Vvedite chislo n: ");
                n = ulong.Parse(Console.ReadLine());
                if (n > 0)
                {
                    while (n > 0)
                    {
                        sum += (1.0 / n);
                        n--;
                    }
                    Console.WriteLine($"Summa = {sum}\n");
                }
                else Console.WriteLine("n ne mojet bit ravno 0!\n");
            }
        }
    }
}
