using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Maquinas_Rutinas
{
    
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Maquina_rutina maquina_rutina { get; set; }

        public void OnGet()
        {
            maquina_rutina = new Maquina_rutina {
              maquirut_maqui_id = 3, 
               maquirut_rut_id = 2,
              
               
            };
        }
    }
}
