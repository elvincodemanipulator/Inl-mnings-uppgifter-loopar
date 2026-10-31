using System;

namespace uppgift7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en sträng:");
            string sträng1 = Console.ReadLine();

            Console.WriteLine("Skriv in exakt två tecken:");
            string sträng2 = Console.ReadLine();

            if (sträng1.Contains(sträng2[0]) && sträng1.Contains(sträng2[1]))
            {
                Console.WriteLine("Båda tecknen finns i strängen!");
            }
            else
            {
                Console.WriteLine("Båda tecknen finns inte i strängen.");
            }
        }
    }
}