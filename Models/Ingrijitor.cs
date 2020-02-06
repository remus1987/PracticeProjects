using System;
using System.Collections.Generic;

namespace PracticeDatabaseFirst.Models
{
    public partial class Ingrijitor
    {
        public Ingrijitor()
        {
            Sarcina = new HashSet<Sarcina>();
        }

        public int IngrijitorId { get; set; }
        public string NumeIngrijitor { get; set; }
        public int? Telefon { get; set; }

        public virtual ICollection<Sarcina> Sarcina { get; set; }
    }
}
