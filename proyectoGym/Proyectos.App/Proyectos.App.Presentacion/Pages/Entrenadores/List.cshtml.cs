using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

using Proyectos.App.Dominio.Modelos;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Pages.Entrenadores
{
    //[Authorize]
    public class ListModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Entrenador> entrenador {get; set;} 
        public string searchString;          

        public ListModel()
        {
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppContext());
        }
       
        public void OnGet()
        {
            entrenador = _appContext.GetAllEntrenadores(searchString);
        }        

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            entrenador = _appContext.GetAllEntrenadores(searchString);
            return Page();
        }
        
    }
}