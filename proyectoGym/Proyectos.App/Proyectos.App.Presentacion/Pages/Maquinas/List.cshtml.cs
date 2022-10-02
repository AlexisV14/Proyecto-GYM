using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Maquinas
{
    public class ListModel : PageModel
    {   
        public IEnumerable<Maquina> maquinas { get; set; }
        public ListModel(){
            cargarTemporales();
        }

        public async Task OnGet()
        {
            cargarTemporales();
            //formadores = await _contexto.formador.ToListAsync();            
        }

        public void cargarTemporales(){
            maquinas = new List<Maquina>()
            {
                new Maquina{id=1, tipo="102030", pesomin=0,pesomax=50.36},
                new Maquina{id=2, tipo="304050", pesomin=0,pesomax=50.63},
                new Maquina{id=3, tipo="607080", pesomin=0,pesomax=100.36 },
                new Maquina{id=4, tipo="901020", pesomin=0,pesomax=45.23}
            };
        }
    }
}


