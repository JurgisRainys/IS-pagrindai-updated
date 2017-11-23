using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project2.Entities.Models
{
    public partial class Ivertinimai
    {
        public double Balas { get; set; }
        public string Aprasymas { get; set; }
        public string Pavadinimas { get; set; }
        [Key]
        public int Id { get; set; }
        public int FkPirkejas { get; set; }
        public int FkTiekejas { get; set; }

        public Vartotojai FkPirkejasNavigation { get; set; }
        public Vartotojai FkTiekejasNavigation { get; set; }
    }
}
