using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;

namespace Proyectos.App.Presentacion.Pages.Usuarios
{
    public class ListModel : PageModel
    {   
        public IEnumerable<Usuario> usuarios { get; set; }
        public ListModel(){
            cargarTemporales();
        }

        public async Task OnGet()
        {
            cargarTemporales();
            //formadores = await _contexto.formador.ToListAsync();            
        }

        public void cargarTemporales(){
            usuarios = new List<Usuario>()
            {
                new Usuario{id=1, identificacion="102030", nombre="Jhon Jairo ",apellido="Orozco",telefono ="45552", mail="xx@xx", edad=18, plan=1},
                new Usuario{id=2, identificacion="304050", nombre="Luz Dary ",apellido="Martinez", telefono ="5515",mail="xx@xx", edad=45, plan=2},
                new Usuario{id=3, identificacion="607080", nombre="Mateo ",apellido="Orozco" ,telefono ="54165",mail="xx@xx", edad=36, plan=3},
                new Usuario{id=4, identificacion="901020", nombre="Mario Enrique ",apellido="Montoya",telefono ="5451",mail="xx@xx", edad=20,plan=2}
            };
        }
    }
}


