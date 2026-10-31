using System;

namespace Uppgift4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal:");
            int tal = int.Parse(Console.ReadLine());

            int storsta = tal;

            Console.WriteLine("Vill du skriva in ett heltal till? (ja/nej)");
            string svar = Console.ReadLine();

            while (svar == "ja")
            {
                Console.WriteLine("Skriv in ett heltal:");
                tal = int.Parse(Console.ReadLine());

                if (tal > storsta)
                {
                    storsta = tal;
                }

                Console.WriteLine("Vill du skriva in ett heltal till? (ja/nej)");
                svar = Console.ReadLine();
            }

            Console.WriteLine("Det största talet var " + storsta);
        }
    }
}