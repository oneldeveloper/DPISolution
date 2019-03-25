using DPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Model
{
    public class Dpi : IDpi
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateProduced { get; set; }
        public DateTime DateExpirationOrService { get; set; }
        public DateTime? DateLastService { get; set; }
        public DateTime? DateDeactivation { get; set; }
    }
}
