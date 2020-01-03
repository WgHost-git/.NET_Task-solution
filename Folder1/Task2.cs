/*
 Начальный вклад в банке равен 10000 руб. Через каждый месяц размер вклада увеличивается на P процентов 
 от имеющейся суммы (P — вещественное число, 0 < P < 25) . Значение Р программа должна получать у пользователя . 
 По данному P определить через сколько месяцев размер вклада превысит 11000 руб., и вывести найденное 
 количество месяцев K (целое число) и итоговый размер вклада S (вещественное число).
 */

using System;

namespace Task2
{
    class Task2
    {
        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            double bankDeposit = 10000;
            double rate, monthRate;
            string yesNo = "y";
            double[] arrDeposit = new double[120];

            do
            {
                Console.WriteLine();
                Console.WriteLine($"Начальный вклад: {bankDeposit} на 120 месяцев.");
                Console.WriteLine();
                Console.Write("Введите процентную ставку за месяц до 25%: ");
                rate = GetInt();
                Console.WriteLine();

                if (0 < rate && rate < 25)
                {
                    arrDeposit[0] = bankDeposit;
                    monthRate = bankDeposit * (rate / 100);

                    for (int i = 1; i < arrDeposit.Length; i++)
                    {
                        arrDeposit[i] = arrDeposit[i-1] + monthRate;
                    }

                    for (int i = 0; i < arrDeposit.Length; i++)
                    {
                        if (arrDeposit[i] > 11000)
                        {
                            Console.WriteLine($"Через {i} месяцев(месяца) депозит привысит 11000р");
                            break;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Через 120 месяцев при ставке {rate}% в месяц ваша сумма будет равна {arrDeposit[119]}р");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели процентную ставку меньше 0 или больше 25%");
                    Console.Write("Если хотите повторить ввод введите 'y': ");
                    yesNo = Console.ReadLine();
                }

            } while (yesNo == "Y" || yesNo == "y");
        }
    }
}
