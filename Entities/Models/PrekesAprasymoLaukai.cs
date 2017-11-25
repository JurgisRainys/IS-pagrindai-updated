using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project2.Entities.Models
{
    public partial class PrekesAprasymoLaukai
    {
        public string Laukas { get; set; }
        public string Aprasymas { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FkPreke { get; set; }

        public Preke FkPrekeNavigation { get; set; }
    }
}
