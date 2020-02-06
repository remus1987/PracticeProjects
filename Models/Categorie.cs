using System;
using System.Collections.Generic;

namespace PracticeDatabaseFirst.Models
{
    public partial class Categorie
    {
        public Categorie()
        {
            Sarcina = new HashSet<Sarcina>();
        }

        public int CategorieId { get; set; }
        public string NumeCategorie { get; set; }

        public virtual ICollection<Sarcina> Sarcina { get; set; }
    }
}
