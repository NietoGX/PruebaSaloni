using PRUEBA.Data.Enums;
using PRUEBA.Data.Models.TiposFicha;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{

    class FichaNoConformidadServicio : FichaNoConformidad
    {
        
        public EstadoServicio Estado { get; set; }

        public FichaAnalisis FichaAnalisis { get; set; }
        public string FichaAnalisisId { get; set; }
        public FichaCompras FichaComppras { get; set; }
        public string FichaComprasId { get; set; }
        public FichaEjecucion FichaEjecucion { get; set; }
        public string FichaEjecucionId { get; set; }
        public FichaArticuloEFIMED FichaArticuloEFIMED { get; set; }
        public string FichaArticuculoEFIMEDID { get; set; }
        public FichaIncidencia FichaIncidencia { get; set; }
        public string FichaIncidenciaId { get; set; }

    }
}
