using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{
    public enum EstadoProductoAcabado
    {
        EMISOR, CALIDAD, PLANIFICACION, LOGISTICA, FINALIZADA
    }
    class FichaNoConformidadProductoAcabado
    {
        [Key]
        public int IdFicha { get; set; }
        public EstadoProductoAcabado Estado { get; set; }

        public FichaNoConformidad FichaNoConformidad { get; set; }

        public FichaCalidad FichaCalidad { get; set; }
        public FichaPlanificacion FichaPlanificacion { get; set; }
        public FichaLogistica FichaLogistica { get; set; }

    }
}
