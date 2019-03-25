using BusinnessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinnessLayer.Logic
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }
        private readonly double _pi = Math.PI;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return _pi * Radius * Radius ;
        }

        public double Perimeter()
        {
            return 2 * _pi * Radius;
        }
    }
}
