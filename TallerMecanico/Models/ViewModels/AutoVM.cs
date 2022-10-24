using Microsoft.AspNetCore.Mvc.Rendering;

namespace TallerMecanico.Models.ViewModels
{
    public class AutoVM
    {
        public Auto oAuto { get; set; } 
        public List<SelectListItem>oListaTitular { get; set; }

    }
}
