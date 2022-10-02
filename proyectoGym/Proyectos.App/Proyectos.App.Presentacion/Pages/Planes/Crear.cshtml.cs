using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Planes
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Plan plan { get; set; }

        public void OnGet()        
        {
        }
    }
}
