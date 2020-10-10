using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                byte day;
                Console.Write("Vvedite den nedeli chislom(1-7):");
                day = byte.Parse(Console.ReadLine());

                switch (day)
                {
                    case 1: Console.WriteLine("Ponedilok\n"); break;
                    case 2: Console.WriteLine("Vivtorok\n"); break;
                    case 3: Console.WriteLine("Sereda\n"); break;
                    case 4: Console.WriteLine("Chetverg\n"); break;
                    case 5: Console.WriteLine("Piatnitsa\n"); break;
                    case 6: Console.WriteLine("Subota\n"); break;
                    case 7: Console.WriteLine("Nedila\n"); break;
                    default: Console.WriteLine("Vi vveli ne vernoe znachenie!\n"); break;
                }
            }
        }
    }
}
