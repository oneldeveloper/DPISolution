using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    public interface IAddress
    {
        string Address1 { get; set; }
        string Address2 { get; set; }
        string ZipCode { get; set; }
        string State { get; set; }
        string Country { get; set; }
    }
}
