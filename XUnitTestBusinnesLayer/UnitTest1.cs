using BusinnessLayer.Logic;
using System;
using Xunit;

namespace XUnitTestBusinnesLayer
{
    public class UnitTest1
    {
        [Fact]
        public void TestCircle()
        {
            double _r = 2.67;
            double _area = Math.PI * _r * _r;
            double _perimeter = 2 * Math.PI * _r;
            var c = new Circle(2.67);
            Assert.Equal(_r, c.Radius);
            Assert.Equal(_area, c.Area());
            Assert.Equal(_perimeter, c.Perimeter());
        }
        [Fact]
        public void TestSquare()
        {
            double _length = 2.67;
            double _area = _length * _length;
            double _perimeter = _length * 4;
            var s = new Square(12.36);
            s.Length = _length;
            Assert.Equal(_length, s.Length);
            Assert.Equal(_area, s.Area());
            Assert.Equal(_perimeter, s.Perimeter());
        }

    }
}
