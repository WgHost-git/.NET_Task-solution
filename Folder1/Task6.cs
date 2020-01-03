/*
  Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные (0 считать положительным)
 */

using System;

namespace Task6
{
    class Task6
    {
        static void Main(string[] args)
        {
            int count = 0;

            int[] arr1 = { 1, -9, 2, 3, -3, 4, 0, 5, -5 };
            int[] arr2 = new int[arr1.Length];

            Console.WriteLine("Изначальный массив: ");
            Console.WriteLine();
            Console.Write("\t| ");

            foreach (int item in arr1)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < 0)
                {
                    arr2[count] = arr1[i];
                    count++;
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] >= 0)
                {
                    arr2[count] = arr1[i];
                    count++;
                }               
            }

            arr2.CopyTo(arr1, 0);

            Console.WriteLine();
            Console.WriteLine("Преобразованный массив массив: ");
            Console.WriteLine();
            Console.Write("\t| ");
            foreach (int item in arr1)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
