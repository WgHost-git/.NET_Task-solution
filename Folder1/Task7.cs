/*
    Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число 
    встречается в массиве .
 */

using System;

namespace Task7
{
    class Task7
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number, count = 0;
            int[] arr = new int[10000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 101);
            }

            Console.Write("Введите число от 1 до 100: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            Console.WriteLine($"Ваше число {number} встречается в массиве {count} раз(а).");

            Console.ReadLine();
        }
    }
}
