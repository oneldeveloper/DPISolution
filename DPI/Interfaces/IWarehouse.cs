using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    /* thi is a warehouse where the dpi are stocked  */
    public interface IWarehouse : IEntity
    {
        string Name { get; set; }
        string Department { get; set; }
        ISite Site { get; set; }
        int SiteId { get; set; }
    }
}
