using System.ComponentModel.DataAnnotations;

namespace GestaoVacinas.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "É obrigatório informar um Email")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É obrigatório informar uma Senha")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "A senha deve conter no mínimo 8 caracteres e no máximo 40")]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        [Compare("ConfirmNewPassword", ErrorMessage = "As senhas fornecidas não são idênticas")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "É obrigatório confirmar a Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar nova senha")]
        public string ConfirmNewPassword { get; set; }
    }
}
