using System;

namespace uppgift8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange triangelns sidlängd:");
            int längd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= längd; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}