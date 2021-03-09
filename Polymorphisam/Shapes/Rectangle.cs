using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        //private double height;
        //private double Weight;
        public Rectangle(double height, double weight)
            : base(height, weight)
        {

        }
        
        public override double CalculateArea()
        {
            return this.Height * this.Weight;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.Height + 2 * this.Weight;
        }
        public override string Draw()
        {
            return $"{CalculateArea():f2} {CalculatePerimeter():f2}";
        }

    }
}
