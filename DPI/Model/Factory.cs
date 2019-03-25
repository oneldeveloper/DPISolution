using DPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Model
{
    public class Factory : IFactory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public virtual IEnumerable<ISite> Sites { get; set; }
        public ICustomer Customer { get; set; }
        public IEntity CustomerId { get; set; }
    }
}
