using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace GestaoVacinas.Models {

    [Table("DetalhesVacinas")]
    public class DetalhesVacina {
        [Key]
        public int Id { get; set; }

        [Required]
        public int VacinaId { get; set; }

        [ValidateNever]
        public virtual Vacina Vacina { get; set; }

        [Required]
        public int CadernetaId { get; set; }

        [ValidateNever]
        public virtual Caderneta Caderneta { get; set; }

        [Display(Name = "Data de aplicação")]
        [DataType(DataType.Date)]
        public DateTime? DataAplicacao { get; set; }

        [Display(Name = "Data recomendada de aplicação")]
        [DataType(DataType.Date)]
        public DateTime? DataRecomendada { get; set; }

        [Display(Name = "Nome do vacinador")]
        [StringLength(50, ErrorMessage = "O {0} deve ter no máximo {1} caracteres.")]
        public string? NomeVacinador { get; set; }

        [Display(Name = "Lote")]
        [StringLength(20, ErrorMessage = "O {0} deve ter no máximo {1} caracteres.")]
        public string? Lote { get; set; }

        [Display(Name = "Data de validade")]
        [DataType(DataType.Date)]
        public DateTime? DataValidade { get; set; }

        [Display(Name = "Código do estabelecimento de saúde (CNES)")]
        [StringLength(20, ErrorMessage = "O {0} deve ter no máximo {1} caracteres.")]
        public string? Cnes { get; set; }

        [Display(Name = "Observações")]
        [StringLength(500, ErrorMessage = "O {0} deve ter no máximo {1} caracteres.")]
        public string? Observacoes { get; set; }

        [Display(Name = "Status")]
        public StatusVacina Status { get; set; } = StatusVacina.Futura;

        public DetalhesVacina() { }

        public void AtualizarStatus() {
            if (DataRecomendada.HasValue == true) {
                var hoje = DateTime.Today;
                var dataRecomendada = DataRecomendada.Value.Date;
                var umaSemanaAntes = dataRecomendada.AddDays(-7);

                if (DataAplicacao.HasValue) {
                    Status = StatusVacina.Aplicada;
                } else if (hoje > dataRecomendada) {
                    Status = StatusVacina.Pendente;
                } else if (hoje >= umaSemanaAntes && hoje <= dataRecomendada) {
                    Status = StatusVacina.Proxima;
                } else {
                    Status = StatusVacina.Futura;
                }
            } else {
                Status = StatusVacina.Futura;
            }
        }
    }
}
