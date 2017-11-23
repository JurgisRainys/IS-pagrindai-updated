using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project2.Entities.Models
{
    public partial class UzsakymoBusenos
    {
        public UzsakymoBusenos()
        {
            Uzsakymai = new HashSet<Uzsakymai>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Uzsakymai> Uzsakymai { get; set; }
    }
}
