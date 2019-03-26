using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Interfaces
{
    /* This is the main object that the application will manage.
    DPI is a concrete product that has to be traced in lifetime 
    and it's assignation to a worker
    Dpi can live its own or can be composed of many other Dpi elements
    through the Composer Entity */
    public interface IDpi : IEntity
    {
        DateTime DateCreated { get; set; }
        DateTime DateProduced { get; set; }
        DateTime DateExpirationOrService { get; set; }
        DateTime? DateLastService { get; set; }
        DateTime? DateDeactivation { get; set; }
    }
}
