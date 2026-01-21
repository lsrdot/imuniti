using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoVacinas.Models {
    [Table("Cadernetas")]
    public class Caderneta {
        [Key]
        public int Id { get; set; }

        [ForeignKey("MembroId")]
        public int MembroId { get; set; }
        public virtual Membros Membro { get; set; }

        public virtual List<DetalhesVacina> DetalhesVacinas { get; set; } = new List<DetalhesVacina>();

        public virtual List<Vacina> Vacinas { get; set; } = new List<Vacina>();

        public Caderneta() { }
    }
}
