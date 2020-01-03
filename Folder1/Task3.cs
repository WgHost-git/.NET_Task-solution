/*
 Даны целые положительные числа A и B (A < B) . Вывести все целые числа от A до B включительно; каждое 
число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, 
равное его значению. Например: если А = 3, а В = 7, то программа  должна сформировать в консоли следующий вывод:
            3 3 3
            4 4 4 4 
            5 5 5 5 5
            6 6 6 6 6 6
            7 7 7 7 7 7 7
 */

using System;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {           
            int numA, numB;
            Console.Write("Введите число 'А': ");
            numA = GetInt();       
            Console.Write("Введите число 'B': ");
            numB = GetInt();
            Console.WriteLine();

            if (numA < numB)
            {
                FormatformattedOutput( numA, numB);
            }
            else
            {
                FormatformattedOutput(numB, numA);
            }

            Console.WriteLine();
        }

        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public static void FormatformattedOutput(int numA, int numB)
        {
            int[] arrAB;
            int range;

            range = numB - numA;

            arrAB = new int[range];

            for (int i = 0; i < range; i++)
            {
                arrAB[i] = numA++;

                for (int j = 0; j < arrAB[i]; j++)
                {
                    Console.Write(arrAB[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
