using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project2.Entities.Models
{
    public partial class UzsakymoPrekes
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FkPreke { get; set; }
        public int FkUzsakymas { get; set; }

        public Preke FkPrekeNavigation { get; set; }
        public Uzsakymai FkUzsakymasNavigation { get; set; }
    }
}
