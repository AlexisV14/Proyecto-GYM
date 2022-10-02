using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Rutinas
{
    public class ListModel : PageModel
    {   
        public IEnumerable<Rutina> rutina { get; set; }
        public ListModel(){
            cargarTemporales();
        }

        public async Task OnGet()
        {
            cargarTemporales();
            //formadores = await _contexto.formador.ToListAsync();            
        }

        public void cargarTemporales(){
            rutina = new List<Rutina>()
            {
                new Rutina {id=1, ejercicios ="lagartijas", observaciones= "ninguna",intensidad = 6},
                new Rutina {id=2, ejercicios ="abdominales",observaciones= "r",intensidad = 6},
                new Rutina {id=3, ejercicios ="pierna",observaciones= "b",intensidad = 6},
                new Rutina {id=4, ejercicios ="natacion",observaciones= "m",intensidad = 6}
            };
        }
    }
}


