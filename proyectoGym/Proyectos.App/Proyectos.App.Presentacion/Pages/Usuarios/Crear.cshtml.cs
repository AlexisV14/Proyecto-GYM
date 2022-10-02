using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio.Modelos;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Pages.Usuarios
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorios _appContext;
        [BindProperty]
        public Usuario usuario { get; set; }

        public CrearModel(){
            //cargar desde la base de datos tabla Usuarios
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppContext());
            //cargarTemporales();
        }
       

        public IActionResult OnGet(int? usuarioId)
        {
            if (usuarioId.HasValue)
            {
                usuario = _appContext.GetUsuario(usuarioId.Value);
            }
            else
            {
                usuario = new Usuario();
            }
            if (usuario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(usuario.id > 0)
            {
               usuario = _appContext.UpdateUsuario(usuario);
            }
            else
            {
                //estudiante.vigente = true;
               _appContext.AddUsuario(usuario);
            }
            return Redirect("List");
            
        }
    }
}