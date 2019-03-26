using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    /* This is the managin interface for dpis
    Here are specified what the concrete class should do
    The concrete class should implement also the basic core rules
    to manage dpis 
     */
    public interface IManageDPI
    {
        IEnumerable<IDpi> AllDpis { get; }
        IEnumerable<IDpi> ExpiredDpis { get; }
        IEnumerable<IDpi> ServicedDpis { get; }
        IEnumerable<IDpi> DeactivatedDpis { get; }

    }
}
