using System;
using System.Collections.Generic;
using System.Text;

namespace ManualFourDz1
{
    class CompoundShape
    {
        double compoundShapeResult;

        public GeometricalFigure[] compoundShape;
        public CompoundShape(GeometricalFigure[] compoundShape)
        {
            this.compoundShape = compoundShape;
            Print();
        }
        public double AreaShape()
        {
            foreach (var item in compoundShape)
            {
                compoundShapeResult += item.AreaShape();
            }
            return compoundShapeResult;
        }
        public void Print()
        {
            Console.WriteLine($"Площадь составной фигуры = {AreaShape()}\n ");
        }
    }
}
