using System;
using System.Collections.Generic;
using System.Text;
using DPI.Interfaces;

namespace DPI.Model
{
    class Customer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
