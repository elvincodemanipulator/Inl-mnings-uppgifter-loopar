using System;

namespace uppgift9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O per grupp?");
            int o = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O-mönster per rad?");
            int mönster = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många rader?");
            int rader = int.Parse(Console.ReadLine());

            for (int i = 0; i < rader; i++)
            {
                for (int j = 0; j < mönster + 1; j++)
                {
                    for (int k = 0; k < x; k++)
                    {
                        Console.Write("X");
                    }

                    if (j < mönster)
                    {
                        Console.Write("-");

                        for (int k = 0; k < o; k++)
                        {
                            Console.Write("O");
                        }

                        Console.Write("-");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}