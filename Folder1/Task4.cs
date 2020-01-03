/*
 Дано целое число N большее 0, найти число, получен-
ное при прочтении числа N справа налево . Например, 
если было введено число 345, то программа должна 
вывести число 543 .
 */

using System;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            string num, reversNum;
            char[] arrNum;

            Console.Write("Введите число больше 0: ");
            num = Console.ReadLine();
            arrNum = num.ToCharArray();
            Array.Reverse(arrNum);
            reversNum = new string(arrNum);

            Console.WriteLine();
            Console.WriteLine($"Изначальный ввод: {num}");
            Console.WriteLine($"Результат реверса: {reversNum}");

        }
    }
}
