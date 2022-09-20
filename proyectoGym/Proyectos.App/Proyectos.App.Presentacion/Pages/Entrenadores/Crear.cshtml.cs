using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Entrenadores
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Entrenador entrenador { get; set; }

        public void OnGet()        
        {
        }
    }
}
