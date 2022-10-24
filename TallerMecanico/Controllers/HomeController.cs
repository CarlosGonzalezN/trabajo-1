using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.WebEncoders.Testing;
using System.Diagnostics;
using TallerMecanico.Models;
using TallerMecanico.Models.ViewModels;

namespace TallerMecanico.Controllers
{
    public class HomeController : Controller
    {
        private readonly tallerMecanicoContext _DBContext;

        public HomeController(tallerMecanicoContext context)
        {
            _DBContext = context;
        }

        public IActionResult Index()
        {
            List<Auto> lista = _DBContext.Autos.Include(t=>t.oTitular).ToList();
            return View(lista);
        }
        [HttpGet]
        public IActionResult Auto_Detalle()
        {
            AutoVM oAutoVM = new AutoVM()
            {
                oAuto = new Auto(),

                oListaTitular = _DBContext.Titular.Select(titular => new SelectListItem() {
                    Text = titular.Apellido,
                    Value = titular.Id.ToString()
                }).ToList()

            };
            return View(oAutoVM);


        }

        [HttpPost]
        public IActionResult Auto_Detalle(AutoVM oAutoVM)
        {
            if (oAutoVM.oAuto.Id == 0)
            {
                _DBContext.Autos.Add(oAutoVM.oAuto);
            }
            _DBContext.SaveChanges();
            return RedirectToAction("Index","Home");


        }

    }
}