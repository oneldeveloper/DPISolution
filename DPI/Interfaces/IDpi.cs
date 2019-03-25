using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    public interface IDpi : IEntity
    {
        DateTime DateCreated { get; set; }
        DateTime DateProduced { get; set; }
        DateTime DateExpirationOrService { get; set; }
        DateTime? DateLastService { get; set; }
        DateTime? DateDeactivation { get; set; }
    }
}
