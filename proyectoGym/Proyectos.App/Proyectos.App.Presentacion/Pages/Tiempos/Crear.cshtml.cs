using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Tiempos
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Tiempo tiempo { get; set; }

        public void OnGet()        
        {
        }
    }
}
