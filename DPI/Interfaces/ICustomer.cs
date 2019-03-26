using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    /*This Specify the main customer that own identify the access to the related data.
    All others concrete models are tied to this account */
    public interface ICustomer : IEntity
    {
        string Name { get; set; }
    }
}
