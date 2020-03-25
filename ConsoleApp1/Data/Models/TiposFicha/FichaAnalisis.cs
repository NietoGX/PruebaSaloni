using System;
using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Data.Models
{
    class FichaAnalisis
    {
        [Key]
        public string Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaAnalisis { get; set; }
        public Usuario ResponsableAnalisis { get; set; }
        public int ResponsableAnalisisId { get; set; }
        public Decision Propuesta { get; set; }
        public int PropuestaId { get; set; }
        public Decision Decision { get; set; }
        public int DecisionId { get; set; }
        public string Descripcion { get; set; }
        
    }
}
