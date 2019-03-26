using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    /*This object is related to an RFID tag that is collected from the field
    This object has to be elaborated to generate or identificate a DPI object 
    This object has the only menaning to be the bridge between the tag structure and the model object dpi*/

    interface ITag
    {
        byte[] Tid { get; set; }
        byte[] Epc { get; set; }
        byte[] UserMemory { get; set; }
        byte[] ReservedMemory { get; set; }

    }
}
