using System;
using System.Collections.Generic;

namespace TallerMecanico.Models
{
    public partial class Auto
    {
        public Auto()
        {
            Ordentallers = new HashSet<Ordentaller>();
        }

        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Patente { get; set; }
        public int? Año { get; set; }
        public string? Color { get; set; }
        public string? NChasis { get; set; }
        public int? IdTitular { get; set; }

        public virtual Titular? oTitular { get; set; }
        public virtual ICollection<Ordentaller> Ordentallers { get; set; }
    }
}
