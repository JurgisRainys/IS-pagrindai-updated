using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project2.Entities.Models
{
    public partial class Uzsakymai
    {
        public Uzsakymai()
        {
            UzsakymoPrekes = new HashSet<UzsakymoPrekes>();
        }

        public DateTime PateikimoData { get; set; }
        public decimal Kaina { get; set; }
        public DateTime? UzdarymoData { get; set; }
        public int Busena { get; set; }
        [Key]
        public int Id { get; set; }
        public int FkPirkejas { get; set; }

        public UzsakymoBusenos BusenaNavigation { get; set; }
        public Vartotojai FkPirkejasNavigation { get; set; }
        public Mokejimai Mokejimai { get; set; }
        public ICollection<UzsakymoPrekes> UzsakymoPrekes { get; set; }
    }
}
