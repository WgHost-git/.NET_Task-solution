using System;
using System.Linq;

namespace Task4
{
    class Task4
    {
        private readonly string fullName;
        private readonly string groups;
        private readonly int age;
        private readonly string[][] arrScores = new string[3][];
        private string score = "";
        private double[] assessment = new double[5]; 
        private double averageScore, summScore, summCol;
        private StringSplitOptions options;

        public Student(string fullName, int age, string groups)
        {
            this.fullName = fullName;
            this.age = age;
            this.groups = groups;
            arrScores[0] = new string[100];
            arrScores[1] = new string[100];
            arrScores[2] = new string[100];
            for (int i = 0; i < assessment.Length; i++)
            {
                assessment[i] = 0;
            }
            summScore = 0;
            summCol = 0;
        }

        public void EnteringRatings()
        {
            Console.WriteLine();
            Console.WriteLine($"Введите оценки студенту: {fullName}");
            Console.WriteLine();
            Console.Write("Введите через пробел 3 оценки по 5 бальной шкале по предмету программирование: ") ;
            score = Console.ReadLine();
            arrScores[0] = score.Split(' ', options = StringSplitOptions.RemoveEmptyEntries);            
            Console.Write("Введите через пробел 4 оценки по по 5 бальной шкале по предмету администрирование: ");
            score = Console.ReadLine();
            arrScores[1] = score.Split(' ', options = StringSplitOptions.RemoveEmptyEntries);            
            Console.Write("Введите через пробел 5 оценок по по 5 бальной шкале по предмету дизайн: ");
            score = Console.ReadLine();
            arrScores[2] = score.Split(' ', options = StringSplitOptions.RemoveEmptyEntries);                  
        }

        public void PrintRating()
        {
            Console.WriteLine();
            Console.WriteLine($"Оценки {fullName}");
            Console.Write($"\tОценки по программированию:  ");
            foreach (var score in arrScores[0])
            {
                Console.Write($"| {score} | ");
            }            
            Console.WriteLine();
            Console.Write($"\tОценки по администрированию:  ");
            foreach (var score in arrScores[1])
            {
                Console.Write($"| {score} | ");
            }            
            Console.WriteLine();
            Console.Write($"\tОценки по дизайну:  ");
            foreach (var score in arrScores[2])
            {
                Console.Write($"| {score} | ");
            }
            Console.WriteLine();
        }

        public double AverageScore()
        {
            foreach (var item in arrScores[0])
            {
                if (item == "5")
                    assessment[4]++;
                if (item == "4")
                    assessment[3]++;
                if (item == "3")
                    assessment[2]++;
                if (item == "2")
                    assessment[1]++;
                if (item == "1")
                    assessment[0]++;
            }
            foreach (var item in arrScores[1])
            {
                if (item == "5")
                    assessment[4]++;
                if (item == "4")
                    assessment[3]++;
                if (item == "3")
                    assessment[2]++;
                if (item == "2")
                    assessment[1]++;
                if (item == "1")
                    assessment[0]++;
            }
            foreach (var item in arrScores[2])
            {
                if (item == "5")
                    assessment[4]++;
                if (item == "4")
                    assessment[3]++;
                if (item == "3")
                    assessment[2]++;
                if (item == "2")
                    assessment[1]++;
                if (item == "1")
                    assessment[0]++;
            }

            for (int i = 0; i < 5; i++)
            {
                summScore += (i + 1) * assessment[i];
            }
            for (int i = 0; i < 3; i++)
            {
                summCol += arrScores[i].Length;
            }

           return averageScore = summScore / summCol;
        }

        public void StudentInfoPrint()
        {
            Console.WriteLine($"ФИО студента: {fullName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Группа: {groups}");            
            PrintRating();
            Console.WriteLine();
            Console.WriteLine($"Средния балл студента по всем предметам = {AverageScore()}");
        }
    }

    class ManualThreeDz8
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Студент1", 22, "Группа1");

            student1.EnteringRatings();
            Console.WriteLine();

            student1.StudentInfoPrint();
            
            Console.ReadLine();
        }
    }
}
