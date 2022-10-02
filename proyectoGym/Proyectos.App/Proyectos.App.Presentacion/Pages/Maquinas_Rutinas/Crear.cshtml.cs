using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Maquinas_Rutinas
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Maquina_rutina maquina_rutina { get; set; }

        public void OnGet()        
        {
        }
    }
}
