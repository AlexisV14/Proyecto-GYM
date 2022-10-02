using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Modelos
{
      public class Plan
      
    {
         //atributos de la clase usuario
        
        [Display(Name = "Plan ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Nombre Plan")]
        public string nombre{ get; set; }
        [Required]        
        [Display(Name = "Precio")]
        public double precio{ get; set; }
        [Required]        
        [Display(Name = "Plan rutina")]
        public int plan_rut_id{ get; set; }
        [Required]        
        [Display(Name = "Plan tiempo")]
        public int tiempo{ get; set; }
        
    }
}