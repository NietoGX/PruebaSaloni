using System;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{
    class FichaCalidad
    {
        [Key]
        public int IdFicha { get; set; }
        public DateTime FechaCalidad { get; set; }
        public int IdResponsableCalidad { get; set; }
        public int IdMotivo { get; set; }
        public int IdDecision { get; set; }
        public string DescripcionProblema { get; set; }
        public string DescripcionSolucion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
