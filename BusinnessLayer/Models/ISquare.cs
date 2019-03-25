using BusinnessLayer.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinnessLayer.Models
{
    public interface ISquare : IShapeProperties
    {
        double Length { get; set; }
    }
}
