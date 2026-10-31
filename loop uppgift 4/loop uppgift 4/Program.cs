
using System;

namespace Uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "";

            while (val != "3")
            {
                Console.WriteLine("Välj ett av följande alternativ");
                Console.WriteLine("[1] Subtrahera ett tal med ett annat");
                Console.WriteLine("[2] Dividera ett tal med ett annat");
                Console.WriteLine("[3] Avsluta programmet");

                val = Console.ReadLine();

                if (val == "1")
                {
                    Console.WriteLine("Skriv ett tal");
                    int term1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv ett tal att subtrahera med");
                    int term2 = int.Parse(Console.ReadLine());

                    int summa = term1 - term2;

                    Console.WriteLine(term1 + " - " + term2 + " = " + summa);
                }
                else if (val == "2")
                {
                    Console.WriteLine("Skriv ett tal");
                    int täljare = int.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv ett tal att dividera med");
                    int nämnare = int.Parse(Console.ReadLine());

                    if (nämnare != 0)
                    {
                        int kvot = täljare / nämnare;
                        Console.WriteLine(täljare + " / " + nämnare + " = " + kvot);
                    }
                    else
                    {
                        Console.WriteLine("Du kan inte dividera med noll");
                    }
                }
                else if (val == "3")
                {
                    Console.WriteLine("Programmet avslutas.");
                }
                else
                {
                    Console.WriteLine("Ogiltigt svar, försök igen.");
                }
            }
        }
    }
}
