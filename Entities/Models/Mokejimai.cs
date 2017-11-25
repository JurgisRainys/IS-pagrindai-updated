using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project2.Entities.Models
{
    public partial class Mokejimai
    {
        public DateTime Data { get; set; }
        public int Busena { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FkUzsakymas { get; set; }

        public MokejimoBusenos BusenaNavigation { get; set; }
        public Uzsakymai FkUzsakymasNavigation { get; set; }
    }
}
