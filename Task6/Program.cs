using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                long a, b, dobutok = 1;
                Console.Write("Vvedite chislo a:");
                a = long.Parse(Console.ReadLine());
                Console.Write("Vvedite chislo b:");
                b = long.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine("Chislo a doljno bit menhe b!\n");
                }
                else
                {
                    while (a <= b)
                    {
                        if ( a != 0) 
                        dobutok *= a;
                        a++;
                    }
                    Console.WriteLine($"Dobutok = {dobutok}\n");
                }
            }
        }
    }
}
