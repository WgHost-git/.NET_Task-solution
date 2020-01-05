using System;

namespace ManualFourDz1
{
    class Triangle : GeometricalFigure
    {
        public Triangle(double sideA, double sideB) : base(sideA, sideB)
        { }
        public override double PrimeterFigure()
        {
            return sideA + sideB + ((sideA * sideA) + (sideB * sideB));
        }
        public override double AreaShape()
        {
            return (sideA * sideB)/2; 
        }
        public override void Print()
        {
            Console.WriteLine($"Периметр треугольника = {PrimeterFigure()}");
            Console.WriteLine($"Площадь треугольника = {AreaShape()}");
        }
    }
}
