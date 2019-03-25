using System;
using System.Collections.Generic;
using System.Text;
using DPI.Interfaces;

namespace DPI.Model
{
    public class Site : ISite
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public IFactory Factory { get; set; }
        public int FactoryId { get; set; }
        public virtual IEnumerable<IWarehouse> Warehouses { get; set; }

    }
}
