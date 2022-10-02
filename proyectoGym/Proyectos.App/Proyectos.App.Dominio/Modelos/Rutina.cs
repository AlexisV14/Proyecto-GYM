using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Modelos
{
    public class Rutina
    {
         //atributos de la clase usuario
        
        [Display(Name = "Id Rutina")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Ejercicios")]
        public string ejercicios { get; set; }
        [Required]        
        [Display(Name = "Observaciones")]
        public string observaciones{ get; set; }
        [Required]        
        [Display(Name = "Rutina Intensidad")]
        public int intensidad { get; set; }
        
    }
}