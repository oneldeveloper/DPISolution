using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    interface ITag
    {
        byte[] Tid { get; set; }
        byte[] Epc { get; set; }
        byte[] UserMemory { get; set; }
        byte[] ReservedMemory { get; set; }

    }
}
