using BusinnessLayer.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using BusinnessLayer.Models;

namespace ShapesApp
{
    public class ShapesCollector
    {
        private ICircle _circle;
        private IRectangle _rectangle;
        private ISquare _square;
        public ShapesCollector(ICircle circle, IRectangle rectangle, ISquare square)
        {
            _circle = circle;
            _rectangle = rectangle;
            _square = square;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Circle: r=" + _circle.Radius.ToString() + " A=" + _circle.Area().ToString() + " P=" + _circle.Perimeter().ToString() + "\r\n");
            sb.Append("Rectangle: l, h=" + _rectangle.Length.ToString() + ", " + _rectangle.Height.ToString() + " A=" + _rectangle.Area().ToString() + " P=" + _rectangle.Perimeter().ToString() + "\r\n");
            sb.Append("Square: l=" + _square.Length.ToString() + " A=" + _square.Area().ToString() + " P=" + _square.Perimeter().ToString() + "\r\n");
            return sb.ToString();
        }

    }
}
