using System;
using System.Collections.Generic;

namespace TallerMecanico.Models
{
    public partial class Titular
    {
        public Titular()
        {
            Autos = new HashSet<Auto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
 
        

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
