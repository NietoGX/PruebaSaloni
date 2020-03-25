using PRUEBA.Data.Enums;
using PRUEBA.Data.Models.TiposFicha;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{
    
    class FichaNoConformidadProductoAcabado : FichaNoConformidad
    {
        
        public EstadoProductoAcabado Estado { get; set; }

        
        public FichaCalidad FichaCalidad { get; set; }
        public string FichaCalidadId { get; set; }
        public FichaPlanificacion FichaPlanificacion { get; set; }
        public string FichaPlanificacionId { get; set; }
        public FichaLogistica FichaLogistica { get; set; }
        public string FichaLogisticaId { get; set; }
        public FichaArticulo FichaArticulo { get; set; }
        public string FichaArticuloId { get; set; }
        public FichaIncidencia FichaIncidencia { get; set; }
        public string FichaIncidenciaId { get; set; }

    }
}
