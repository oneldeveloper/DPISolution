using BusinnessLayer.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinnessLayer.Models
{
    public interface ICircle : IShapeProperties
    {
        double Radius { get; set; }
    }
}
