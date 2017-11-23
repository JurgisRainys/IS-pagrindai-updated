using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project2.Entities.Models
{
    public partial class StebimosPrekes
    {
        public DateTime IkelimoData { get; set; }
        [Key]

        public int Id { get; set; }
        public int FkPrikejas { get; set; }
        public int FkPreke { get; set; }

        public Preke FkPrekeNavigation { get; set; }
        public Vartotojai FkPrikejasNavigation { get; set; }
    }
}
