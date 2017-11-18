using System;
using System.Collections.Generic;

namespace project2.Entities.Models
{
    public partial class PrekesTipai
    {
        public PrekesTipai()
        {
            Preke = new HashSet<Preke>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Preke> Preke { get; set; }
    }
}
