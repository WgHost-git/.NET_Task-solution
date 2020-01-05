using System;

namespace ManualFourDz1
{
    class Rectangle : GeometricalFigure
    {
        public Rectangle(double sideA, double sideB) : base(sideA, sideB)
        { }
        public override double PrimeterFigure()
        {
            return (sideA + sideB) * 2;
        }
        public override double AreaShape()
        {
            return sideA * sideB;
        }
        public override void Print()
        {
            Console.WriteLine($"Периметр прямоугольника = {PrimeterFigure()}");
            Console.WriteLine($"Площадь прямоугольника = {AreaShape()}");
        }
    }
}
