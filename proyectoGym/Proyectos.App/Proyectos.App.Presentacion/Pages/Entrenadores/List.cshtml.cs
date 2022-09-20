using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Entrenadores
{
    public class ListModel : PageModel
    {   
        public IEnumerable<Entrenador> entrenadores { get; set; }
        public ListModel(){
            cargarTemporales();
        }

        public async Task OnGet()
        {
            cargarTemporales();
            //formadores = await _contexto.formador.ToListAsync();            
        }

        public void cargarTemporales(){
            entrenadores = new List<Entrenador>()
            {
                new Entrenador{id=1, identificacion="102030", nombre="Jhon Jairo ",apellido="Orozco",telefono ="45552", mail="xx@xx", edad=18, rutid=1},
                new Entrenador{id=2, identificacion="304050", nombre="Luz Dary ",apellido="Martinez", telefono ="5515",mail="xx@xx", edad=45, rutid=2},
                new Entrenador{id=3, identificacion="607080", nombre="Mateo ",apellido="Orozco" ,telefono ="54165",mail="xx@xx", edad=36,rutid=2},
                new Entrenador{id=4, identificacion="901020", nombre="Mario Enrique ",apellido="Montoya",telefono ="5451",mail="xx@xx", edad=20,rutid=3}
            };
        }
    }
}


