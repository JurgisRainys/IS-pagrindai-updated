using System;
using System.Collections.Generic;

namespace project2.Entities.Models
{
    public partial class VartotojoTipai
    {
        public VartotojoTipai()
        {
            Vartotojai = new HashSet<Vartotojai>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Vartotojai> Vartotojai { get; set; }
    }
}
