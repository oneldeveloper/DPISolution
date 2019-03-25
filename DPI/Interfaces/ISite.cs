using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    public interface ISite : IEntity, IAddress
    {
        string Name { get; set; }
        IFactory Factory { get; set; }
        int FactoryId { get; set; }

    }
}
