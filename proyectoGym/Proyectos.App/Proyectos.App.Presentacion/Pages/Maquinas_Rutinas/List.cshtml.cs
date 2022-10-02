using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Maquinas_Rutinas
{
    public class ListModel : PageModel
    {   
        public IEnumerable<Maquina_rutina> maquina_rutina { get; set; }
        public ListModel(){
            cargarTemporales();
        }

        public async Task OnGet()
        {
            cargarTemporales();
            //formadores = await _contexto.formador.ToListAsync();            
        }

        public void cargarTemporales(){
            maquina_rutina = new List<Maquina_rutina>()
            {
                new Maquina_rutina{maquirut_maqui_id=1, maquirut_rut_id=2},
                new Maquina_rutina{maquirut_maqui_id=2,maquirut_rut_id=3},
                new Maquina_rutina{maquirut_maqui_id=3, maquirut_rut_id=1},
                new Maquina_rutina{maquirut_maqui_id=4, maquirut_rut_id=9}
            };
        }
    }
}


