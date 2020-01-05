using System;

namespace ManualFourDz1
{
     class Trapeze : GeometricalFigure
    {
        double hight;

        public Trapeze(double sideA, double sideB, double hight) : base(sideA, sideB)
        {
            this.hight = hight;
        }
        public override double PrimeterFigure()
        {
          
            return Math.Sqrt(Math.Pow(Math.Abs(sideA - sideB) / 2, 2) + Math.Pow(hight, 2)) * 2 + sideA + sideB;
        }
        public override double AreaShape()
        {
            return ((sideA + sideB) * hight) / 2;
        }
        public override void Print()
        {
            Console.WriteLine($"Периметр трапеции = {PrimeterFigure()}");
            Console.WriteLine($"Площадь трапеции = {AreaShape()}");
        }
    }
}
