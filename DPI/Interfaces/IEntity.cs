using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    /* This is the basic element to identify the element in the set of data
    Do it should be better to shift to a guid? */
    public interface IEntity
    {
        int Id { get; set; }
    }
}
