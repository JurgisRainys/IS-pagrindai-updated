using System;
using System.Collections.Generic;

namespace project2.Entities.Models
{
    public partial class UzsakymoPrekes
    {
        public int Id { get; set; }
        public int FkPreke { get; set; }
        public int FkUzsakymas { get; set; }

        public Preke FkPrekeNavigation { get; set; }
        public Uzsakymai FkUzsakymasNavigation { get; set; }
    }
}
