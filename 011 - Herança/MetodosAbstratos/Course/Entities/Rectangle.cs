using Course.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class Rectangle : Shape
    {
        public double Widht { get; set; }
        public double Height { get; set; }
        public Rectangle(Color color, double width, double height) 
            : base(color) 
        { 
            Widht = width;
            Height = height;
        }
        public override double Area()
        {
            return Widht * Height;
        }
    }
}
