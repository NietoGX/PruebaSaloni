using System;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{

    class FichaPlanificacion
    {
        [Key]
        public string Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaPlanificacion { get; set; }
        public int IdResponsablePlanificacion { get; set; }
        public int IdDecision { get; set; }
        public int CantidadDevuelta { get; set; }
        public int CantidadConforme { get; set; }
        public string GastosACargoDe { get; set; }
        public string ComentarioProveedor { get; set; }
        public string DescripcionDecision { get; set; }

        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
