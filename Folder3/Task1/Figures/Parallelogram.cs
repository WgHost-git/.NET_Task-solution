using System;

namespace ManualFourDz1
{
    class Parallelogram : GeometricalFigure
    {
        double hight;

        public Parallelogram(double sideA, double sideB) : base(sideA, sideB)
        {
        }
        public override double PrimeterFigure()
        {
            return (sideA + sideB) * 2;
        }
        public override double AreaShape()
        {
            hight = sideB * Math.Sin(60); 

            return sideA * hight;
        }
        public override void Print()
        {
            Console.WriteLine($"Периметр параллелограмма = {PrimeterFigure()}");
            Console.WriteLine($"Площадь параллелограмма = {AreaShape()}");
        }
    }
}
