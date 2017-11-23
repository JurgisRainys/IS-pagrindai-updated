using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project2.Entities.Models
{
    public partial class KrepselioPrekes
    {
        public DateTime IkelimoData { get; set; }
        [Key]

        public int Id { get; set; }
        public int FkPirkejas { get; set; }
        public int FkPreke { get; set; }

        public Vartotojai FkPirkejasNavigation { get; set; }
        public Preke FkPrekeNavigation { get; set; }
    }
}
