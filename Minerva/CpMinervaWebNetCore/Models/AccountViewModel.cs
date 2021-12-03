using System.ComponentModel.DataAnnotations;

namespace CpMinervaWebNetCore.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public string usuario { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        public string clave { get; set; }
        [Display(Name = "Recordarme")]
        public bool recordarme { get; set; }
    }
}
