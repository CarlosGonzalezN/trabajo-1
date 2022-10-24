using System;
using System.Collections.Generic;

namespace TallerMecanico.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Ordentallers = new HashSet<Ordentaller>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Ordentaller> Ordentallers { get; set; }
    }
}
