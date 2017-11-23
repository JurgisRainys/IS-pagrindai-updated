using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project2.Entities.Models
{
    public partial class MokejimoBusenos
    {
        public MokejimoBusenos()
        {
            Mokejimai = new HashSet<Mokejimai>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Mokejimai> Mokejimai { get; set; }
    }
}
