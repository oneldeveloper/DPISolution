using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    /* Every Customer can have one or many factories
    factories can have one or many Sites
    one site can have one or many warehouses */
    public interface IFactory : IEntity, IAddress
    {
        string Name { get; set; }
        ICustomer Customer { get; set; }
        IEntity CustomerId { get; set; }
    }
}
