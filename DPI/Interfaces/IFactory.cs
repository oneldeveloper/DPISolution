using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    public interface IFactory : IEntity, IAddress
    {
        string Name { get; set; }
        ICustomer Customer { get; set; }
        IEntity CustomerId { get; set; }
    }
}
