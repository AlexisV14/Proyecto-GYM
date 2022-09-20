using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Entrenadores
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Entrenador entrenador { get; set; }

        public void OnGet()
        {
            entrenador = new Entrenador {
                id = 3, 
               identificacion = "7777777",
               nombre = "CARGANDO NOMBRE DE PRUEBA",
               apellido = "CARGANDO NOMBRE DE PRUEBA",
               telefono = "12345",
               mail = "jorozco",
               edad = 18,
               rutid = 1
            };
        }
    }
}
