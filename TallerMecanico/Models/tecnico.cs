using System;
using System.Collections.Generic;

namespace TallerMecanico.Models
{
    public partial class Tecnico
    {
        public Tecnico()
        {
            Ordentallers = new HashSet<Ordentaller>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Rol { get; set; }

        public virtual ICollection<Ordentaller> Ordentallers { get; set; }
    }
}
