using BusinnessLayer.Logic;
using BusinnessLayer.Models;
using System;
using Unity;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer ioc = new UnityContainer();
            ioc.RegisterType<ICircle, Circle>();
            ioc.RegisterType<IRectangle, Rectangle>();
            ioc.RegisterType<ISquare, Square>();
            var diag = ioc.AddExtension(new Diagnostic());

            //var c = ioc.Resolve<Circle>();
            //var r = ioc.Resolve<Rectangle>();
            //var s = ioc.Resolve<Square>();
            var c = new Circle(2.73);
            var r = new Rectangle(4, 66.453);
            var s = new Square(5.77);
            var hc = new HyperCircle(5);

            var shapes = new ShapesCollector(c, r, s);
            Console.WriteLine(shapes.ToString());
        }
    }
}
