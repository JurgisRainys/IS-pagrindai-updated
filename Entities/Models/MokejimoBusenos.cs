using System;
using System.Collections.Generic;

namespace project2.Entities.Models
{
    public partial class MokejimoBusenos
    {
        public MokejimoBusenos()
        {
            Mokejimai = new HashSet<Mokejimai>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Mokejimai> Mokejimai { get; set; }
    }
}
