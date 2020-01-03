/*
 В двумерном массиве порядка M на N поменяйте местами заданные столбцы .
 */

using System;

namespace Task8
{
    class Task8
    {
        static void Main(string[] args)
        {
            int row = 5;
            int col = 5;
            Random rnd = new Random();
            int[,] arr = new int[row,col];
            int col1 = 0, col2 = 0, temp = 0;

            Console.WriteLine();
            Console.WriteLine("\tПрограмма меняющая столбцы в массиве местами.");
            Console.WriteLine();
            Console.Write("Введите первый столбец от 1 до 5: ");
            col1 = int.Parse(Console.ReadLine());  
            Console.Write("Введите второй столбец от 1 до 5: ");
            col2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                }
            }

            Console.WriteLine("Вывод изначального массива:");
            Console.WriteLine();
          
            for (int i = 0; i < row; i++)
            {
                Console.Write("\t| ");
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i,j] + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j == col1 - 1)
                    {
                        temp = arr[i,j];
                        arr[i, j] = arr[i, col2 - 1];
                        arr[i, col2 - 1] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Вывод изменненого массива:");
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                Console.Write("\t| ");
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
