using System;

namespace ManualFourDz1
{      
    class Task1_Main
    {
        static void Main(string[] args)
        {
            double sideA, sideB, hight, numberMenu, r, r2; 
              bool yesNo = true;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\tВыберете для какой фигуры необходимо рассчитать периметр и площадь.");
                Console.WriteLine();
                Console.WriteLine("\t1) Квадрат;\n" +
                    "\t2) Треугольник;\n" +
                    "\t3) Ромб;\n" +
                    "\t4) Прямоугольник;\n" +
                    "\t5) Параллелограмм;\n" +
                    "\t6) Трапеция;\n" +
                    "\t7) Круг;\n" +
                    "\t8) Эллипс;\n" +
                    "\t9) Составная Фигура;\n" +
                    "\t10) Выход.\n");               
                Console.Write($"Введите номер меню: ");
                numberMenu = int.Parse(Console.ReadLine());

                if (numberMenu == 1)
                {
                    Console.Write($"Введите сторону квадрата: ");
                    sideA = Square.GetDouble();
                    sideB = sideA;
                    Square oneSquare = new Square(sideA, sideB);
                    Console.WriteLine();
                    oneSquare.Print();


                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую кнопку для возврата в меню.");
                    Console.ReadLine();
                    continue;
                }                
                if (numberMenu == 2)
                {
                    Console.Write($"Введите сторону 'A' треугольника: ");
                    sideA = Triangle.GetDouble();
                    Console.Write($"Введите сторону 'В' треугольника: ");
                    sideB = Triangle.GetDouble();
                    Triangle oneTriangle = new Triangle(sideA, sideB);
                    Console.WriteLine();
                    oneTriangle.Print();

                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую кнопку для возврата в меню.");
                    Console.ReadLine();
                    continue;
                }                
                if (numberMenu == 3)
                {
                    Console.Write($"Введите сторону 'A' ромба: ");
                    sideA = Rhombus.GetDouble();
                    Console.Write($"Введите чему равна высота ромба: ");
                    hight = Rhombus.GetDouble();
                    Rhombus oneRhombus = new Rhombus(sideA, hight);
                    Console.WriteLine();
                    oneRhombus.Print();

                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую кнопку для возврата в меню.");
                    Console.ReadLine();
                    continue;
                }                
                if (numberMenu == 4)
                {
                    Console.Write($"Введите сторону 'A' прямоугольника: ");
                    sideA = Rectangle.GetDouble();
                    Console.Write($"Введите сторону 'В' прямоугольника: ");
                    sideB = Rectangle.GetDouble();
                    Rectangle oneRectangle = new Rectangle(sideA, sideB);
                    Console.WriteLine();
                    oneRectangle.Print();

                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую кнопку для возврата в меню.");
                    Console.ReadLine();
                    continue;
                }                
                if (numberMenu == 5)
                {
                    Console.Write($"Введите сторону 'A' параллелограмма: ");
                    sideA = Parallelogram.GetDouble();
                    Console.Write($"Введите сторону 'В' параллелограмма: ");
                    sideB = Parallelogram.GetDouble();
                    Parallelogram oneParallelogram = new Parallelogram(sideA, sideB);
                    Console.WriteLine();
                    oneParallelogram.Print();

                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую кнопку для возврата в меню.");
                    Console.ReadLine();
                    continue;
                }                
                if (numberMenu == 6)
                {
                    Console.Write($"Введите 1е основание 'A' трапеции: ");
                    sideA = Trapeze.GetDouble();
                    Console.Write($"Введите  2е основание 'В' трапеции: ");
                    sideB = Trapeze.GetDouble();
                    Console.Write($"Введите высоту трапеции: ");
                    hight = Trapeze.GetDouble();
                    Trapeze oneTrapeze = new Trapeze(sideA, sideB, hight);
                    Console.WriteLine();
                    oneTrapeze.Print();

                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую кнопку для возврата в меню.");
                    Console.ReadLine();
                    continue;
                }                
                if (numberMenu == 7)
                {
                    Console.Write($"Введите радиус круга: ");
                    r = Сircle.GetDouble();
                    Сircle oneСircle = new Сircle(r);
                    Console.WriteLine();
                    oneСircle.Print();

                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую кнопку для возврата в меню.");
                    Console.ReadLine();
                    continue;
                }               
                if (numberMenu == 8)
                {
                    Console.Write($"Введите первый радиус элипса: ");
                    r = Ellipse.GetDouble();                    
                    Console.Write($"Введите второй радиус элипса: ");
                    r2 = Ellipse.GetDouble();
                    Ellipse oneEllipse = new Ellipse(r, r2);
                    Console.WriteLine();
                    oneEllipse.Print();

                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую кнопку для возврата в меню.");
                    Console.ReadLine();
                    continue;
                }
                if (numberMenu == 9)
                {
                    GeometricalFigure[] figures = new GeometricalFigure[8];

                    for (int i = 0; i < 8; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write($"Введите сторону квадрата: ");
                            sideA = Square.GetDouble();
                            sideB = sideA;
                            figures[i] = new Square(sideA, sideB);                         
                        }
                        else if (i == 1)
                        {
                            Console.Write($"Введите сторону 'A' треугольника: ");
                            sideA = Triangle.GetDouble();
                            Console.Write($"Введите сторону 'В' треугольника: ");
                            sideB = Triangle.GetDouble();
                            figures[i] = new Triangle(sideA, sideB);
                        }
                        else if (i == 2)
                        {
                            Console.Write($"Введите сторону 'A' ромба: ");
                            sideA = Rhombus.GetDouble();
                            Console.Write($"Введите чему равна высота ромба: ");
                            hight = Rhombus.GetDouble();
                            figures[i] = new Rhombus(sideA, hight);
                        }
                        else if (i == 3)
                        {
                            Console.Write($"Введите сторону 'A' прямоугольника: ");
                            sideA = Rectangle.GetDouble();
                            Console.Write($"Введите сторону 'В' прямоугольника: ");
                            sideB = Rectangle.GetDouble();
                            figures[i] = new Rectangle(sideA, sideB);
                        }
                        else if (i == 4)
                        {
                            Console.Write($"Введите сторону 'A' параллелограмма: ");
                            sideA = Parallelogram.GetDouble();
                            Console.Write($"Введите сторону 'В' параллелограмма: ");
                            sideB = Parallelogram.GetDouble();
                            figures[i] = new Parallelogram(sideA, sideB);
                        }
                        else if (i == 5)
                        {
                            Console.Write($"Введите 1е основание 'A' трапеции: ");
                            sideA = Trapeze.GetDouble();
                            Console.Write($"Введите  2е основание 'В' трапеции: ");
                            sideB = Trapeze.GetDouble();
                            Console.Write($"Введите высоту трапеции: ");
                            hight = Trapeze.GetDouble();
                            figures[i] = new Trapeze(sideA, sideB, hight);
                        }                        
                        else if (i == 6)
                        {
                            Console.Write($"Введите радиус круга: ");
                            r = Сircle.GetDouble();
                            figures[i] = new Сircle(r);
                        }                        
                        else if (i == 7)
                        {
                            Console.Write($"Введите первый радиус элипса: ");
                            r = Ellipse.GetDouble();
                            Console.Write($"Введите второй радиус элипса: ");
                            r2 = Ellipse.GetDouble();
                            figures[i] = new Ellipse(r, r2);
                        }                        
                    }

                    Console.WriteLine();
                    CompoundShape compoundShape = new CompoundShape(figures);

                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую кнопку для возврата в меню.");
                    Console.ReadLine();
                    continue;
                }
                if (numberMenu == 10)
                {
                    yesNo = false;
                }
            } while (yesNo);
        }
    }
}
