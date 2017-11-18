using System;
using System.Collections.Generic;

namespace project2.Entities.Models
{
    public partial class KomentaroBusenos
    {
        public KomentaroBusenos()
        {
            Komentarai = new HashSet<Komentarai>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Komentarai> Komentarai { get; set; }
    }
}
