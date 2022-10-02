using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Planes
{
    public class ListModel : PageModel
    {   
        public IEnumerable<Plan> plan { get; set; }
        public ListModel(){
            cargarTemporales();
        }

        public async Task OnGet()
        {
            cargarTemporales();
            //formadores = await _contexto.formador.ToListAsync();            
        }

        public void cargarTemporales(){
            plan = new List<Plan>()
            {
                new Plan{id=1,nombre="Basico ",precio=25.63,plan_rut_id =6, tiempo=3},
                new Plan{id=2,nombre="VIP",precio=630.2, plan_rut_id=1,tiempo=6},
                new Plan{id=3,nombre="VIP Anual",precio=599.900 ,plan_rut_id =2,tiempo=6},
              
            };
        }
    }
}


