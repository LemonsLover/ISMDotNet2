using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, dis, x1, x2;
            while (true)
            {
                Console.Write("Vvedite chislo a:");
                a = double.Parse(Console.ReadLine());
                Console.Write("Vvedite chislo b:");
                b = double.Parse(Console.ReadLine());
                Console.Write("Vvedite chislo c:");
                c = double.Parse(Console.ReadLine());

                dis = Math.Pow(b, 2) - (4 * a * c);

                if (a == 0) { x1 = -c / b; Console.WriteLine($"Eto ne kvadratichne rivnana, no x = {x1}\n"); }

                else if (dis > 0) { x1 = (-b + Math.Sqrt(dis)) / (2 * a); x2 = (-b - Math.Sqrt(dis)) / (2 * a); Console.WriteLine($"discrimenant = {dis}, x1 = {x1}, x2 = {x2}\n");}

                else if (dis == 0) { x1 = -b / (2 * a); Console.WriteLine($"discrimenant = {dis}, x = {x1}\n"); }

                else Console.WriteLine("Coreniv ne mae!\n");

            }
        }
    }
}
