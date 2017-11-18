using System;
using System.Collections.Generic;

namespace project2.Entities.Models
{
    public partial class Vartotojai
    {
        public Vartotojai()
        {
            IvertinimaiFkPirkejasNavigation = new HashSet<Ivertinimai>();
            IvertinimaiFkTiekejasNavigation = new HashSet<Ivertinimai>();
            Komentarai = new HashSet<Komentarai>();
            KrepselioPrekes = new HashSet<KrepselioPrekes>();
            Preke = new HashSet<Preke>();
            Statymai = new HashSet<Statymai>();
            StebimosPrekes = new HashSet<StebimosPrekes>();
            Uzsakymai = new HashSet<Uzsakymai>();
        }

        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string ElPastas { get; set; }
        public string Telefonas { get; set; }
        public string Adresas { get; set; }
        public bool ArAktyvus { get; set; }
        public DateTime SukurimoData { get; set; }
        public string Slaptazodis { get; set; }
        public int Tipas { get; set; }
        public int Id { get; set; }

        public VartotojoTipai TipasNavigation { get; set; }
        public ICollection<Ivertinimai> IvertinimaiFkPirkejasNavigation { get; set; }
        public ICollection<Ivertinimai> IvertinimaiFkTiekejasNavigation { get; set; }
        public ICollection<Komentarai> Komentarai { get; set; }
        public ICollection<KrepselioPrekes> KrepselioPrekes { get; set; }
        public ICollection<Preke> Preke { get; set; }
        public ICollection<Statymai> Statymai { get; set; }
        public ICollection<StebimosPrekes> StebimosPrekes { get; set; }
        public ICollection<Uzsakymai> Uzsakymai { get; set; }
    }
}
