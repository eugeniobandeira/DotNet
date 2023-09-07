using Course.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Course.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
