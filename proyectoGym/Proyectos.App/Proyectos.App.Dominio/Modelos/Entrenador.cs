using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Modelos
{
    public class Entrenador
    {
         //atributos de la clase usuario
        [Display(Name = "Entrenador ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Nro. Identficación")]
        public string identificacion{ get; set; }
        [Required]        
        [Display(Name = "Nombre del Entrenador")]
        public string nombre{ get; set; }
        [Required]        
        [Display(Name = "Apellido del Entrenador")]
        public string apellido{ get; set; }
        [Display(Name = "Telefono del Entrenador")]
        public string telefono{ get; set; }
        [Required]        
        [Display(Name = "Correo Electrónico")]
        public string mail{ get; set; }
        [Required]        
        [Display(Name = "edad")]
        public int edad{ get; set; }
        [Required]        
        [Display(Name = "Rut id")]
        public int rutid{ get; set; }
        
    }
}