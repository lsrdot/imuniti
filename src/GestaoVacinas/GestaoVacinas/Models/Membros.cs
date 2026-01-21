using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace GestaoVacinas.Models;

[Table("Membros")]
public class Membros
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Apelido")]
    [Required(ErrorMessage = "O apelido é obrigatório.")]
    [StringLength(maximumLength: 30, MinimumLength = 2,
        ErrorMessage = "O apelido deverá conter entre 2 e 30 caracteres.")]
    public string? Apelido { get; set; }

    [Display(Name = "Nome Completo")]
    [Required(ErrorMessage = "O nome completo é obrigatório.")]
    [StringLength(maximumLength: 50, MinimumLength = 5,
        ErrorMessage = "O nome completo deverá conter entre 5 e 50 caracteres.")]
    public string? NomeCompleto { get; set; }

    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
    [DataType(DataType.Date, ErrorMessage = "Data inválida.")]
    [Range(typeof(DateTime), "1900-01-01", "2100-01-01", ErrorMessage = "A data de nascimento deve estar entre 1900 e 2100.")]
    public DateTime? DataNascimento { get; set; }

    [Display(Name = "CPF")]
    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 dígitos.")]
    public string? Cpf { get; set; }

    [Display(Name = "Cartão Nacional de Saúde")]
    [StringLength(15, MinimumLength = 15, ErrorMessage = "O CNS deve ter 15 dígitos.")]
    public string? Cns { get; set; }

	public virtual Caderneta Caderneta { get; set; }

	[ForeignKey("Usuario")]
	public string UserId { get; set; }

	[ValidateNever]
	public virtual Users Usuario { get; set; }
}