using System;
using System.Linq;

namespace Task6
{
    class Task6
    {
        static void Main(string[] args)
        {           
            int[] Cyties = { Russia.Moscow.population, USA.Washington.population, China.Bejing.population };


            if (Cyties.Max() == Russia.Moscow.population)
            {
                Console.Write($"The largest city has: ");
                Console.WriteLine(Russia.Moscow.Population());

                if (Cyties.Min() == USA.Washington.population)
                {
                    Console.Write($"The smallest city has: ");
                    Console.WriteLine(USA.Washington.Population());
                }
                else
                {
                    Console.Write($"The smallest city has: ");
                    Console.WriteLine(China.Bejing.Population());
                }

            }
            else if (Cyties.Max() == USA.Washington.population)
            {
                Console.Write($"The largest city has: ");
                Console.WriteLine(USA.Washington.Population());

                if (Cyties.Min() == Russia.Moscow.population)
                {
                    Console.Write($"The smallest city has: ");
                    Console.WriteLine(Russia.Moscow.Population());
                }
                else
                {
                    Console.Write($"The smallest city has: ");
                    Console.WriteLine(China.Bejing.Population());
                }
            }
            else
            {
                Console.Write($"The largest city has: ");
                Console.WriteLine(China.Bejing.Population());

                if (Cyties.Min() == Russia.Moscow.population)
                {
                    Console.Write($"The smallest city has: ");
                    Console.WriteLine(Russia.Moscow.Population());
                }
                else
                {
                    Console.Write($"The smallest city has: ");
                    Console.WriteLine(USA.Washington.Population());
                }


                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }

    namespace Russia
    {
        class Moscow
        {
            private static string populationPrint;
            public static int population = 12615882;
            public static string Population() => populationPrint = $"Population of Moscow = {population}";

        }
    }

    namespace USA
    {
        class Washington
        {
            private static string populationPrint;
            public static int population = 7666343;
            public static string Population() => populationPrint = $"Population of Washington = {population}";

        }
    }

    namespace China
    {
        class Bejing
        {
            private static string populationPrint;
            public static int population = 1404328611;
            public static string Population() => populationPrint = $"Population of Bejing = {population}";
        }
    }
}