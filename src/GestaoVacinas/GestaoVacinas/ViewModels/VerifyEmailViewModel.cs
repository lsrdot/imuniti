using System.ComponentModel.DataAnnotations;

namespace GestaoVacinas.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "É obrigatório informar um Email")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }
    }
}
