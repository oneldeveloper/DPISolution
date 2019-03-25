using BusinnessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinnessLayer.Logic
{
    public class Rectangle : IRectangle, IShapeProperties
    {
        public double Height { get; set; }
        public double Length { get; set; }

        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }

        public double Area()
        {
            return Length * Height;
        }

        public double Perimeter()
        {
            return (2 * Length) + (2 * Height);
        }
    }
}
