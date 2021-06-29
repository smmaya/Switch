using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Znajdujesz sie przed zamkiem z wieżą i fosą. Co robisz?");
            Console.WriteLine("W - wchodzisz do zamku");
            Console.WriteLine("F - wskakuejsz do fosy");
            Console.WriteLine("Z - wspinasz się na wieżę");
            string odp = Console.ReadLine();

            switch (odp)
            {
                case "W":
                    Console.WriteLine("Atakuje cię minotaur. Umierasz.");
                    break;
                case "F":
                    Console.WriteLine("Topisz się");
                    break;
                case "Z":
                    Console.WriteLine("Znajdujesz skarb!");
                    break;
                default:
                    Console.WriteLine("Błędne polecenie!");
                    break;
            }
            Console.ReadLine();

        }
    }
}
