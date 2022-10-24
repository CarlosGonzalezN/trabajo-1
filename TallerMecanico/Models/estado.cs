using System;
using System.Collections.Generic;

namespace TallerMecanico.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Ordentallers = new HashSet<Ordentaller>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Ordentaller> Ordentallers { get; set; }
    }
}
