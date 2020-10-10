using System;

namespace Task9
{
    class Program
    {
        static ulong fact(ulong n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return n * fact(n - 1);
        }
        static void Main(string[] args)
        {
            while (true){
                ulong n, otvet = 0;
                Console.Write("Vvedite chislo n: ");
                n = ulong.Parse(Console.ReadLine());
                while (n > 0)
                {
                    otvet += fact(n);
                    n--;
                }
                Console.WriteLine($"Otvet = {otvet}\n");
            }
        }
    }
}
