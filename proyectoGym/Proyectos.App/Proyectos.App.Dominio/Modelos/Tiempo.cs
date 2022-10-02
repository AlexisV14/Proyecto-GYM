using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Modelos
{
    public class Tiempo
    {
         //atributos de la clase usuario
        
        [Display(Name = "Id Tiempo")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Duracion")]
        public DateTime duracion{ get; set; }
       
        
    }
}