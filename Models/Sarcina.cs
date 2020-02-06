using System;
using System.Collections.Generic;

namespace PracticeDatabaseFirst.Models
{
    public partial class Sarcina
    {
        public int SarcinaId { get; set; }
        public string NumeSarcina { get; set; }
        public bool? Indeplinita { get; set; }
        public int? CategorieId { get; set; }
        public int? IngrijitorId { get; set; }

        public virtual Categorie Categorie { get; set; }
        public virtual Ingrijitor Ingrijitor { get; set; }
    }
}
