using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project2.Entities.Models
{
    public partial class Ivertinimai
    {
        public double Balas { get; set; }
        public string Aprasymas { get; set; }
        public string Pavadinimas { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FkPirkejas { get; set; }
        public int FkTiekejas { get; set; }

        public Vartotojai FkPirkejasNavigation { get; set; }
        public Vartotojai FkTiekejasNavigation { get; set; }
    }
}
