using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Shape
    {
        protected Shape(double height, double weight)
        {
            this.Height = height;
            this.Weight = weight;
        }

        public double Height { get; protected set; }

        public double Weight { get; protected set; }

        public abstract double CalculateArea();
     

        public abstract double CalculatePerimeter();
       

        public virtual string Draw()
        {
            return "Draw():";
        }

        
    }
}
