using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    public interface ICustomer : IEntity
    {
        string Name { get; set; }
    }
}
