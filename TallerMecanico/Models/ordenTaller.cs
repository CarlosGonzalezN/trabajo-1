using System;
using System.Collections.Generic;

namespace TallerMecanico.Models
{
    public partial class Ordentaller
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string? Descripcion { get; set; }
        public int? Km { get; set; }
        public DateTime? StartDate { get; set; }
        public int IdEstado { get; set; }
        public string? Solucion { get; set; }
        public DateTime? EndDate { get; set; }
        public int IdTaller { get; set; }
        public int IdAuto { get; set; }
        public int IdTecnico { get; set; }

        public virtual Auto IdAutoNavigation { get; set; } = null!;
        public virtual Categorium IdCategoriaNavigation { get; set; } = null!;
        public virtual Estado IdEstadoNavigation { get; set; } = null!;
        public virtual Taller IdTallerNavigation { get; set; } = null!;
        public virtual Tecnico IdTecnicoNavigation { get; set; } = null!;
    }
}
