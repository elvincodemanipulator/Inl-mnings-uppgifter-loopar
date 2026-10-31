using System;
namespace loopuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 10;
            while (tal1 < 31)
            {
                Console.WriteLine(tal1);
                tal1 ++;
            }

            int tal2 = 200;
            while (tal2 > 179)
            {
                Console.WriteLine(tal2);
                tal2--;
            }

            int tal3 = 1000;
            while (tal3 < 1450)
            {
                Console.WriteLine(tal3);
                tal3 +=50;
            }
        }
    }
}