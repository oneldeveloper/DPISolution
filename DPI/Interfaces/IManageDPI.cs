using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    public interface IManageDPI
    {
        IEnumerable<IDpi> AllDpis { get; }
        IEnumerable<IDpi> ExpiredDpis { get; }
        IEnumerable<IDpi> ServicedDpis { get; }
        IEnumerable<IDpi> DeactivatedDpis { get; }

    }
}
