using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Modelos
{
    public class Usuario
    {
         //atributos de la clase usuario
        [Display(Name = "Usuario ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Nro. Identficación")]
        public string identificacion{ get; set; }
        [Required]        
        [Display(Name = "Nombre del Usuario")]
        public string nombre{ get; set; }
        [Required]        
        [Display(Name = "Apellido del Usuario")]
        public string apellido{ get; set; }
        [Display(Name = "Telefono del Usuario")]
        public string telefono{ get; set; }
        [Required]        
        [Display(Name = "Correo Electrónico")]
        public string mail{ get; set; }
        [Required]        
        [Display(Name = "edad")]
        public int edad{ get; set; }
        [Required]        
        [Display(Name = "Plan")]
        public int plan{ get; set; }
        
    }
}