using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project2.Entities.Models
{
    public partial class Preke
    {
        public Preke()
        {
            Komentarai = new HashSet<Komentarai>();
            KrepselioPrekes = new HashSet<KrepselioPrekes>();
            PrekesAprasymoLaukai = new HashSet<PrekesAprasymoLaukai>();
            Statymai = new HashSet<Statymai>();
            StebimosPrekes = new HashSet<StebimosPrekes>();
            UzsakymoPrekes = new HashSet<UzsakymoPrekes>();
        }

        public decimal Kaina { get; set; }
        public string Pavadinimas { get; set; }
        public string Nuotrauka { get; set; }
        public double Nuolaida { get; set; }
        public DateTime IkelimoData { get; set; }
        public int Tipas { get; set; }
        public int Busena { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FkTiekejas { get; set; }

        public PrekesBusenos BusenaNavigation { get; set; }
        public Vartotojai FkTiekejasNavigation { get; set; }
        public PrekesTipai TipasNavigation { get; set; }
        public ICollection<Komentarai> Komentarai { get; set; }
        public ICollection<KrepselioPrekes> KrepselioPrekes { get; set; }
        public ICollection<PrekesAprasymoLaukai> PrekesAprasymoLaukai { get; set; }
        public ICollection<Statymai> Statymai { get; set; }
        public ICollection<StebimosPrekes> StebimosPrekes { get; set; }
        public ICollection<UzsakymoPrekes> UzsakymoPrekes { get; set; }
    }
}
