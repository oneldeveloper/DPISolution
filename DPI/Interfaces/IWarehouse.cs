using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    public interface IWarehouse : IEntity
    {
        string Name { get; set; }
        string Department { get; set; }
        ISite Site { get; set; }
        int SiteId { get; set; }
    }
}
