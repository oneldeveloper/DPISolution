using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DPI.Interfaces;


namespace DPI.Logic
{
    public class ManageFactoryDPI : IManageDPI
    {
        public IEnumerable<IDpi> AllDpis { get; private set; }
        public IEnumerable<IDpi> RegularDpis { get; private set; }
        public IEnumerable<IDpi> ExpiredDpis { get; private set; }
        public IEnumerable<IDpi> ServicedDpis { get; private set; }
        public IEnumerable<IDpi> DeactivatedDpis { get; private set; }

        public ManageFactoryDPI(IFactory factory)
        {
            //AllDpis = get all dpi from factory
            ServicedDpis = AllDpis.Where(x => x.DateExpirationOrService < DateTime.Now).ToList();
            RegularDpis = AllDpis.Where(x => x.DateDeactivation == null)
                                 .Where(x => x.DateExpirationOrService > DateTime.Now)
                                 .ToList();
            ExpiredDpis = AllDpis.Where(x => x.DateLastService != null).ToList();
            DeactivatedDpis = AllDpis.Where(x => x.DateDeactivation != null).ToList();
        }
    }
}
