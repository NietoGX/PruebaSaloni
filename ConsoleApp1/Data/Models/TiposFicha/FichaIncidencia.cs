using System;
using System.Collections.Generic;
using System.Text;

namespace PRUEBA.Data.Models.TiposFicha
{
    class FichaIncidencia
    {
        public string Id { get; set; }
        public bool EsGrave { get; set; }
        public Incidencia TipoIncidencia { get; set; }
        public int TipoIncidenciaId{get;set; }
       
        public string DescripcionIncidencia { get; set; }
        public bool AfectaProduccion { get; set; }
        public bool EsPropuesta { get; set; }//Si no es propuesta es decision
        public Decision Decision { get; set; }
        public int DecisionId { get; set; }
        
    }
}
