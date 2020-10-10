using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n;
            double a;
            while (true)
            {
                double otvet = 1;
                Console.Write("Vvedite chislo n: ");
                n = ulong.Parse(Console.ReadLine());
                Console.Write("Vvedite chislo a: ");
                a = double.Parse(Console.ReadLine());

                for (ulong i = 0; i < n; i++)
                {
                    otvet *= a;
                }
                Console.WriteLine($"a^n = {otvet}\n");
            }
        }
    }
}
