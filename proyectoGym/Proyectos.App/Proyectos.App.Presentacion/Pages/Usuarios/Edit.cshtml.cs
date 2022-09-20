using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Usuarios
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Usuario usuario { get; set; }

        public void OnGet()
        {
            usuario = new Usuario {
                id = 3, 
               identificacion = "7777777",
               nombre = "CARGANDO NOMBRE DE PRUEBA",
               apellido = "CARGANDO NOMBRE DE PRUEBA",
               telefono = "12345",
               mail = "jorozco",
               edad = 18,
               plan = 1
            };
        }
    }
}
