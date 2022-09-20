using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Usuarios
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Usuario usuario { get; set; }

        public void OnGet()        
        {
        }
    }
}
