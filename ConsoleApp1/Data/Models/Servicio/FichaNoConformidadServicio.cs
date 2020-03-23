using PRUEBA.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{

    class FichaNoConformidadServicio
    {
        [Key]
        public int IdFicha { get; set; }
        public EstadoServicio Estado { get; set; }

        public FichaNoConformidad FichaNoConformidad { get; set; }

        public FichaAnalisis FichaAnalisis { get; set; }
        public FichaCompras FichaComppras { get; set; }
        public FichaEjecucion FichaEjecucion { get; set; }


    }
}
