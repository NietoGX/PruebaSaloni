using System;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{
    class FichaLogistica
    {
        [Key]
        public string Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaLogistica { get; set; }
        public Usuario ResponsableLogistica { get; set; }
        public int ResponsableLogisticaId { get; set; }
        public Decision Decision { get; set; }
        public int DecisionId { get; set; }
        public string DescripcionLogistica { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
