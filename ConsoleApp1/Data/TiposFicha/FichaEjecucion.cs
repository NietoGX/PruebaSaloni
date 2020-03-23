using System;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{
    class FichaEjecucion
    {
        [Key]
        public int IdFicha { get; set; }
        public DateTime FechaEjecucion { get; set; }
        public int IdResponsableEjecucion { get; set; }
        public int IdPropuesta { get; set; }
        public int IdDecision { get; set; }
        public string Descripcion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
