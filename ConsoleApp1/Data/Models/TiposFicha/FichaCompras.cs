using System;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{
    class FichaCompras
    {
        [Key]
        public string Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaCompras { get; set; }
        public Usuario ResponsableCompras { get; set; }
        public int ResponsableComprasId { get; set; }
        public Decision Propuesta { get; set; }
        public int PropuestaId { get; set; }
        public Decision Decision { get; set; }
        public int DecisionId { get; set; }
        public string Descripcion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
