using System;
using System.Collections.Generic;

namespace TallerMecanico.Models
{
    public partial class Taller
    {
        public Taller()
        {
            Ordentallers = new HashSet<Ordentaller>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Cuit { get; set; }

        public virtual ICollection<Ordentaller> Ordentallers { get; set; }
    }
}
