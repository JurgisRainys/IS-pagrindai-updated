using System;
using System.Collections.Generic;

namespace project2.Entities.Models
{
    public partial class StatymoBusenos
    {
        public StatymoBusenos()
        {
            Statymai = new HashSet<Statymai>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Statymai> Statymai { get; set; }
    }
}
