/*
     Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1
 */

using System;

namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] arr1 = { 1, 0, 2, 3, 0, 4, 0, 5, 8 };
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
                if (arr1[i] != 0)
                {
                    arr2[count] = arr1[i];
                    count++;
                }
            }
            for (int i = count; i < arr1.Length; i++)
            {
                arr2[i] = -1;
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
