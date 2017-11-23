using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project2.Entities.Models
{
    public partial class Statymai
    {
        public decimal Suma { get; set; }
        public DateTime StatymoData { get; set; }
        public DateTime UzdarymoData { get; set; }
        public int Busena { get; set; }
        [Key]

        public int Id { get; set; }
        public int FkPirkejasid { get; set; }
        public int FkPrekeid { get; set; }

        public StatymoBusenos BusenaNavigation { get; set; }
        public Vartotojai FkPirkejas { get; set; }
        public Preke FkPreke { get; set; }
    }
}
