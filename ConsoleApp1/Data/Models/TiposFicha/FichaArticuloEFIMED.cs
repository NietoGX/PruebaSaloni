using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRUEBA.Data.Models.TiposFicha
{
    class FichaArticuloEFIMED
    {
        [Key]
        public string Id { get; set; }
        //public Ubicacion?
        public string Notas { get; set; }
        public int ArticuloId { get; set; }
        public Articulo Articulo { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
