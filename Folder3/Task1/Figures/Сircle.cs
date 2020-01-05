using System;
using System.Collections.Generic;
using System.Text;

namespace ManualFourDz1
{
    class Сircle : GeometricalFigure
    {
        public Сircle(double r) : base(r)
        { }
        public override double PrimeterFigure()
        {
            return 2 * Pi * r;
        }
        public override double AreaShape()
        {
            return Pi * Math.Pow(r, 2);
        }
        public override void Print()
        {
            Console.WriteLine($"Периметр круга = {PrimeterFigure()}");
            Console.WriteLine($"Площадь круга = {AreaShape()}");
        }
    }
}
