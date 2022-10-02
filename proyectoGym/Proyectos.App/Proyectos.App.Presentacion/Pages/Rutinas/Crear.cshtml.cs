using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Rutinas
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Rutina rutina { get; set; }

        public void OnGet()        
        {
        }
    }
}
