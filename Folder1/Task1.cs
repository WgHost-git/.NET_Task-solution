/*
  Даны целые положительные числа A, B, C . Значение этих чисел программа должна запрашивать у пользо-
  вателя . На прямоугольнике размера A*B размещено максимально возможное количество квадратов со 
  стороной C . Квадраты не накладываются друг на друга . Найти количество квадратов, размещенных на 
  прямоугольнике, а также площадь незанятой части прямоугольника .
  Необходимо предусмотреть служебные сообщения в случае, если в прямоугольнике нельзя разместить ни 
  одного квадрата со стороной С (например, если зна-чение С превышает размер сторон прямоугольника) .
 */

using System;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            string flag = "n";
            int a, b, c, areaRectangle, areaSquare, numSquaresInRectangle, areaUnoccupiedRectangle, areaAllSquares;
            bool error = true;

            Console.WriteLine();
            do
            {
                Console.Write("Введите первую сторону прямоугольника в 'см': ");               
                if (GetInt(out a))
                {
                    Console.Write("Введите вторую сторону прямоугольника в 'см': ");
                    if (GetInt(out b))
                    {
                        Console.WriteLine();
                        areaRectangle = a * b;
                        Console.WriteLine($"Площадь прямоугольника S = {areaRectangle}см2.");

                        Console.WriteLine();
                        Console.Write("Введите сторону квадрата в 'см': ");
                        if (GetInt(out c))
                        {
                            if (c < a && c < b)
                            {                           
                                areaSquare = c * c;
                                numSquaresInRectangle = areaRectangle / areaSquare;
                                areaAllSquares = areaSquare * numSquaresInRectangle;
                                areaUnoccupiedRectangle = areaRectangle - areaAllSquares;
                                Console.WriteLine($"Кол-во квадратов в прямоугольнике: {numSquaresInRectangle}шт.");
                                Console.WriteLine($"Площадь незанятой части прямоугольника: {areaUnoccupiedRectangle}см2");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Квадрат больше прямоугольника.");                              
                                error = false;
                            }
                        }
                    }
                }

                if (error)
                {
                    Console.WriteLine();
                    Console.Write($"Вы ввели не целое число. Если хотите повторить ввод введите 'Y': ");
                    flag = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.Write($"Если хотите повторить ввод введите 'Y': ");
                    flag = Console.ReadLine();
                }
                Console.WriteLine();

            } while (flag == "Y" || flag == "y");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку для выхода.");
            Console.ReadLine();
        }
        static bool GetInt(out int num)
        {          
            bool check = int.TryParse(Console.ReadLine(), out num);

            if (check)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}
