using BusinnessLayer.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinnessLayer.Models
{
    public interface IRectangle : ISquare
    {
        double Height { get; set; }
    }
}
