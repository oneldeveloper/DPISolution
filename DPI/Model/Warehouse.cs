using System;
using System.Collections.Generic;
using System.Text;
using DPI.Interfaces;

namespace DPI.Model
{
    class Warehouse : IWarehouse
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public ISite Site { get; set; }
        public int SiteId { get; set; }
    }
}
