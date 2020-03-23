using PRUEBA.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{

    class FichaNoConformidadMedioAmbiente
    {
        [Key]
        public int IdFicha { get; set; }
        public EstadoEME Estado { get; set; }

        public FichaNoConformidad FichaNoConformidad { get; set; }
        public FichaAnalisis FichaAnalisis { get; set; }
        public FichaEjecucion FichaEjecucion { get; set; }
    }
}
