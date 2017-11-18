using System;
using System.Collections.Generic;

namespace project2.Entities.Models
{
    public partial class Komentarai
    {
        public string Tekstas { get; set; }
        public DateTime Data { get; set; }
        public string Pavadinimas { get; set; }
        public int Busena { get; set; }
        public int Id { get; set; }
        public int FkVartotojas { get; set; }
        public int FkPreke { get; set; }

        public KomentaroBusenos BusenaNavigation { get; set; }
        public Preke FkPrekeNavigation { get; set; }
        public Vartotojai FkVartotojasNavigation { get; set; }
    }
}
