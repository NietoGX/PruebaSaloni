using PRUEBA.Data.Models.TiposFicha;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{
    public enum EstadoProductoAcabado
    {
        EMISOR, CALIDAD, PLANIFICACION, LOGISTICA, FINALIZADA
    }
    class FichaNoConformidadProductoAcabado : FichaNoConformidad
    {
        [Key]
        public string Id { get; set; }
        public EstadoProductoAcabado Estado { get; set; }

        public FichaNoConformidad FichaNoConformidad { get; set; }

        public FichaCalidad FichaCalidad { get; set; }
        public FichaPlanificacion FichaPlanificacion { get; set; }
        public FichaLogistica FichaLogistica { get; set; }
        public FIchaArticulo FichaArticulo { get; set; }
        public FichaIncidencia FichaIncidencia { get; set; }

    }
}
