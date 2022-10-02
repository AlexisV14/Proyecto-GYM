using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Maquinas
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Maquina maquina { get; set; }

        public void OnGet()
        {
            maquina = new Maquina {
               id = 3, 
               tipo = "Cardio",
               pesomin = 0.56,
               pesomax = 1000.56,
            };
        }
    }
}
