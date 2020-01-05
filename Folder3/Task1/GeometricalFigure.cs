using System;
using System.Collections.Generic;
using System.Text;

namespace ManualFourDz1
{
     abstract class GeometricalFigure
    {
        public double sideA;
        public double sideB;
        public double r;
        public const double Pi = 3.14;

        public GeometricalFigure(double r)
        {
            this.r = r;
        }
        public GeometricalFigure(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public abstract double PrimeterFigure();
        public abstract double AreaShape();
        public abstract void Print();
        public static double GetDouble()
        {
            return double.Parse(Console.ReadLine());   
        }
    }
}
