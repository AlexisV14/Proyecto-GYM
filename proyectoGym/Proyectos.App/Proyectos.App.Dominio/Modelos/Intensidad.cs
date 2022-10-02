using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Modelos
{
    public class Intensidad
    {
         //atributos de la clase usuario
       
        [Display(Name = "Id Intesidad")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Tipo")]
        public string tipo{ get; set; }
        [Required]        
        [Display(Name = "Abreviatura")]
        public string abreviatura{ get; set; }
        
    }
}