using System;

namespace ManualFourDz1
{
    class Square : GeometricalFigure
    {     
        public Square(double sideA, double sideB) : base(sideA, sideB)
        { }
        public override double PrimeterFigure()
        {
            return sideA * 4;
        }
        public override double AreaShape()
        {
            return sideA * sideB; 
        }
        public override void Print()
        {
            Console.WriteLine($"Периметр квадрата = {PrimeterFigure()}");
            Console.WriteLine($"Площадь квадрата = {AreaShape()}");          
        }
    }
}
