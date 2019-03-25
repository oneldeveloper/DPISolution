using DPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Model
{
    public class DpiComposer
    {
        public int DpiFatherId { get; set; }
        public int DpiChildId { get; set; }
        public ushort NumberOfChilds { get; set; }
    }
}
