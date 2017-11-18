using System;
using System.Collections.Generic;

namespace project2.Entities.Models
{
    public partial class UzsakymoBusenos
    {
        public UzsakymoBusenos()
        {
            Uzsakymai = new HashSet<Uzsakymai>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Uzsakymai> Uzsakymai { get; set; }
    }
}
