using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Intensidades
{
    public class ListModel : PageModel
    {   
        public IEnumerable<Intensidad> intensidad { get; set; }
        public ListModel(){
            cargarTemporales();
        }

        public async Task OnGet()
        {
            cargarTemporales();
            //formadores = await _contexto.formador.ToListAsync();            
        }

        public void cargarTemporales(){
            intensidad = new List<Intensidad>()
            {
                new Intensidad{id=1, tipo="alta", abreviatura= "a"},
                new Intensidad{id=2, tipo="media",abreviatura= "m"},
                new Intensidad{id=3, tipo="baja",abreviatura= "b"},
                new Intensidad{id=4, tipo="media",abreviatura= "m"}
            };
        }
    }
}


