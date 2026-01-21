using GestaoVacinas.Models;
using System.Collections.Generic;

namespace GestaoVacinas.ViewModels {
    public class CadernetaDetailsViewModel {
        public Caderneta Caderneta { get; set; }
        public List<Vacina> VacinasPadrao { get; set; }
        public List<Vacina> VacinasDisponiveis { get; set; }
        public List<Vacina> VacinasComplementares { get; set; }
    }
}