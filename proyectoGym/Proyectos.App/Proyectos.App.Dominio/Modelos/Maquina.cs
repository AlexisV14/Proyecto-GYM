using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Modelos
{
    public class Maquina
    {
         //atributos de la clase usuario
        
        [Display(Name = "Id maquina")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "tipo")]
        public string tipo { get; set; }
        [Required]        
        [Display(Name = "Peso minimo")]
        public double pesomin { get; set; }
        [Required]        
        [Display(Name = "Peso maximo")]
        public double pesomax { get; set; }
        
    }
}