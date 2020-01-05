using System;
using System.Collections.Generic;
using System.Text;

namespace ManualFourDz1
{
    class Ellipse : GeometricalFigure
    {
        double r2;

        public Ellipse(double r, double r2) : base(r)
        {
            this.r2 = r2;
        }
        public override double PrimeterFigure()
        {
            return 2 * Pi * Math.Sqrt((Math.Pow(r, 2) + Math.Pow(r2, 2)) / 2);
        }
        public override double AreaShape()
        {
            return Pi * r * r2;
        }
        public override void Print()
        {
            Console.WriteLine($"Периметр круга = {PrimeterFigure()}");
            Console.WriteLine($"Площадь круга = {AreaShape()}");
        }
    }
}
