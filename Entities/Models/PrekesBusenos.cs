﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project2.Entities.Models
{
    public partial class PrekesBusenos
    {
        public PrekesBusenos()
        {
            Preke = new HashSet<Preke>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Preke> Preke { get; set; }
    }
}
