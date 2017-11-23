using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project2.Entities.Models
{
    public partial class KomentaroBusenos
    {
        public KomentaroBusenos()
        {
            Komentarai = new HashSet<Komentarai>();
        }
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Komentarai> Komentarai { get; set; }
    }
}
