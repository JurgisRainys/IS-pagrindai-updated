using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project2.Entities.Models
{
    public partial class UzsakymoBusenos
    {
        public UzsakymoBusenos()
        {
            Uzsakymai = new HashSet<Uzsakymai>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Uzsakymai> Uzsakymai { get; set; }
    }
}
