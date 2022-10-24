using Microsoft.AspNetCore.Mvc;
using NetCoreApi.Model;

namespace NetCoreApi.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class clienteController : Controller
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listaCliente() 
        {
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    id="1",
                    nombre="carlos",
                    correo="carlos@gmail.cm",
                    edad="31"
                },
                new Cliente
                {
                    id="2",
                    nombre="nahuel ",
                    correo="nahuel@gmail.cm",
                    edad="30"
                },
                new Cliente
                {
                    id="3",
                    nombre="gonzalez",
                    correo="gonzalez@gmail.cm",
                    edad="32"
                }
            };
            return clientes ;
        }
        [HttpPost]
        [Route("Crear")]
        public IActionResult
    }
}
