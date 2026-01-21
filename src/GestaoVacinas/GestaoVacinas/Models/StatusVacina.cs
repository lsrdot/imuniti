using System.ComponentModel.DataAnnotations;

namespace GestaoVacinas.Models {

    public enum StatusVacina {
        [Display(Name = "Aplicada")]
        Aplicada,
        [Display(Name = "Próxima")]
        Proxima,
        [Display(Name = "Pendente")]
        Pendente,
        [Display(Name = "Futura")]
        Futura
    }

}
