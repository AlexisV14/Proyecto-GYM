using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Intensidades
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Intensidad intensidad { get; set; }

        public void OnGet()        
        {
        }
    }
}
