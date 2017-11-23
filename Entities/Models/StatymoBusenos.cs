using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project2.Entities.Models
{
    public partial class StatymoBusenos
    {
        public StatymoBusenos()
        {
            Statymai = new HashSet<Statymai>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Statymai> Statymai { get; set; }
    }
}
