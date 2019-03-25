using BusinnessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinnessLayer.Logic
{
    public class HyperCircle : ICircle
    {
        public double Radius { get; set; }

        public HyperCircle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Radius * 1000;
        }

        public double Perimeter()
        {
            return Radius * 2;
        }
    }
}
