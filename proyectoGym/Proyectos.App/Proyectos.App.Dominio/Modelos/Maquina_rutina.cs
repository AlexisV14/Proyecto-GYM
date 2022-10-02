using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Modelos
{
    public class Maquina_rutina
    {
         //atributos de la clase usuario
        
        [Display(Name = "Id maquina")]
        public int maquirut_maqui_id { get; set; }
        [Required]        
        [Display(Name = "rutina id")]
        public int  maquirut_rut_id { get; set; }
       
        
    }
}