using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Maquinas
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Maquina maquina { get; set; }

        public void OnGet()        
        {
        }
    }
}
