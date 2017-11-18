using System;
using System.Collections.Generic;

namespace project2.Entities.Models
{
    public partial class PrekesAprasymoLaukai
    {
        public string Laukas { get; set; }
        public string Aprasymas { get; set; }
        public int Id { get; set; }
        public int FkPreke { get; set; }

        public Preke FkPrekeNavigation { get; set; }
    }
}
