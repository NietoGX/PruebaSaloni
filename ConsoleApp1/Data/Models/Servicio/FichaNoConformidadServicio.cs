using PRUEBA.Data.Enums;
using PRUEBA.Data.Models.TiposFicha;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{

    class FichaNoConformidadServicio : FichaNoConformidad
    {
        [Key]
        public string Id { get; set; }
        public EstadoServicio Estado { get; set; }

        public FichaNoConformidad FichaNoConformidad { get; set; }

        public FichaAnalisis FichaAnalisis { get; set; }
        public FichaCompras FichaComppras { get; set; }
        public FichaEjecucion FichaEjecucion { get; set; }
        public FichaArticuloEFIMED FichaArticuloEFIMED { get; set; }
        public FichaIncidencia FichaIncidencia { get; set; }


    }
}
