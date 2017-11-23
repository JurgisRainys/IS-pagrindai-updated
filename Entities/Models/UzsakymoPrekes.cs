using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project2.Entities.Models
{
    public partial class UzsakymoPrekes
    {
        [Key]
        public int Id { get; set; }
        public int FkPreke { get; set; }
        public int FkUzsakymas { get; set; }

        public Preke FkPrekeNavigation { get; set; }
        public Uzsakymai FkUzsakymasNavigation { get; set; }
    }
}
