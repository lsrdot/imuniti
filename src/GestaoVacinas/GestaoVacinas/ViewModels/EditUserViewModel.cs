using System.ComponentModel.DataAnnotations;

namespace GestaoVacinas.ViewModels;

public class EditUserViewModel
{
    [Required(ErrorMessage = "É obrigatório informar um email válido.")]
    [StringLength(100, ErrorMessage = "O email pode ter no máximo 100 caracteres.")]
    [EmailAddress(ErrorMessage = "Email inválido!")]
    public string Email { get; set; }

    [Required(ErrorMessage = "É obrigatório informar a senha atual.")]
    [DataType(DataType.Password)]
    [Display(Name = "Senha Atual")]
    public string SenhaAtual { get; set; }

    [Required(ErrorMessage = "É obrigatório informar uma nova senha.")]
    [StringLength(40, MinimumLength = 8, ErrorMessage = "A senha deve conter no mínimo 8 caracteres e no máximo 40.")]
    [DataType(DataType.Password)]
    [Display(Name = "Nova Senha")]
    public string Senha { get; set; }

    [Required(ErrorMessage = "É obrigatório confirmar a nova senha.")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirmar Nova Senha")]
    [Compare("Senha", ErrorMessage = "As senhas fornecidas não são idênticas.")]
    public string ConfirmarSenha { get; set; }
}