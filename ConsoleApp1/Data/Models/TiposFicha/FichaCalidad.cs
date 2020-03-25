using System;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{
    class FichaCalidad
    {
        [Key]
        public string Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaCalidad { get; set; }
        public int IdResponsableCalidad { get; set; }
        public int IdMotivo { get; set; }
        public int IdDecision { get; set; }
        public string DescripcionProblema { get; set; }
        public string DescripcionSolucion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
