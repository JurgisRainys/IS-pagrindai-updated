using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project2.Entities.Models
{
    public partial class VartotojoTipai
    {
        public VartotojoTipai()
        {
            Vartotojai = new HashSet<Vartotojai>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Vartotojai> Vartotojai { get; set; }
    }
}
