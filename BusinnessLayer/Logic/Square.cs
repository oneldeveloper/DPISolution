using BusinnessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinnessLayer.Logic
{
    public class Square : ISquare, IShapeProperties
    {
        public double Length { get; set; }

        public Square(double length)
        {
            Length = length;
        }

        public double Area()
        {
            return Length * Length;
        }

        public double Perimeter()
        {
            return Length * 4;
        }
    }
}
