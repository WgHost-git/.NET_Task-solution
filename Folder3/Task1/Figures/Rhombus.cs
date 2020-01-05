using System;

namespace ManualFourDz1
{
    class Rhombus : GeometricalFigure
    {
        double hight;

        public Rhombus(double sideA, double sideB) : base(sideA, sideB)
        { }
        public override double PrimeterFigure()
        {
            return sideA * 4; 
        }
        public override double AreaShape()
        {
            hight = sideB * Math.Sin(60);
            return sideA * hight;
        }
        public override void Print()
        {
            Console.WriteLine($"Периметр ромба = {PrimeterFigure()}");
            Console.WriteLine($"Площадь ромба = {AreaShape()}");
        }
    }
}
