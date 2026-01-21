using System.ComponentModel.DataAnnotations;

namespace GestaoVacinas.ViewModels;
    public class LoginViewModel
    {
        [Required(ErrorMessage = "É obrigatório informar um Email")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É obrigatório informar uma Senha")]
        [DataType(DataType.Password)]
        public string Senha{ get; set; }

        [Display(Name = "Lembrar Senha")]
        public bool RememberMe { get; set; }

    }

