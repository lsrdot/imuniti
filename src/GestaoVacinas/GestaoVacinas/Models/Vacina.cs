using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoVacinas.Models {

    [Table("Vacinas")]
    public class Vacina {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(500, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
        public string Descricao { get; set; }

        [ScaffoldColumn(false)]
        public int? IdadeEmMeses { get; set; }

        [Display(Name = "Data recomendada de aplicação")]
        [DataType(DataType.Date)]
        public DateTime? DataRecomendada { get; set; }

        [ScaffoldColumn(false)]
        public bool IsVacinaPadrao { get; set; }

        [InverseProperty("Vacina")]
        public virtual ICollection<DetalhesVacina> Detalhes { get; set; } = new List<DetalhesVacina>();

        public virtual List<Caderneta> Cadernetas { get; set; } = new List<Caderneta>();

        public Vacina() { }

        public Vacina(int id, string nome, string descricao, int? idadeEmMeses, bool isVacinaPadrao) {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            IdadeEmMeses = idadeEmMeses;
            IsVacinaPadrao = isVacinaPadrao;
        }
    }
}
