using System;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{
    class FichaLogistica
    {
        [Key]
        public int IdFicha { get; set; }
        public DateTime FechaLogistica { get; set; }
        public int idResponsableLogistica { get; set; }
        public int IdDecision { get; set; }
        public string DescripcionLogistica { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
