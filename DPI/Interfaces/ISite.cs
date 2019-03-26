using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    /* This is a site of a factory.
    Is a concrete location where warehouses are defined */
    public interface ISite : IEntity, IAddress
    {
        string Name { get; set; }
        IFactory Factory { get; set; }
        int FactoryId { get; set; }

    }
}
