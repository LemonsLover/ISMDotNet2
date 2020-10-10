using System;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float a, b, plocha, perimetr;
                Console.Write("Vvedite storony a:");
                a = float.Parse(Console.ReadLine());
                Console.Write("Vvedite storony b:");
                b = float.Parse(Console.ReadLine());
                plocha = a * b; perimetr = (2 * a) + (2 * b);
                Console.WriteLine($"Perimetr = {perimetr}, plocha = {plocha}\n");
            }
        }
    }
}
