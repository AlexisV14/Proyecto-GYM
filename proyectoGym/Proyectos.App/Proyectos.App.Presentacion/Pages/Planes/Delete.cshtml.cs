using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Planes
{
    
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Plan plan { get; set; }

        public void OnGet()
        {
            plan = new Plan {
            id=1,
            nombre="Basico ",
            precio=25.63,
            plan_rut_id =6,
            tiempo=3
            };
        }
    }
}
