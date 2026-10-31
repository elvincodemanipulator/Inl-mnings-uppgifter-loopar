
using System;
namespace Uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string heltal = Console.ReadLine();

            for (int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);

                siffra++;

                if (siffra == 10)
                {
                    siffra = 0;
                }

                Console.Write(siffra);
            }
        }
    }
}
