using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRUEBA.Data.Models.TiposFicha
{
    class FIchaArticulo
    {
        [Key]
        public string Id { get; set; }
        public int NumAlbaran { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaAlbaran { get; set; }
        public int NumPedido { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaPedido { get; set; }
        public int CantidadTotal { get; set; }
        public int CantidadAfectada { get; set; }
        //public Ubicacion?
        public string Notas { get; set; }


        public int ArticuloId { get; set; }
        public Articulo Articulo { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }


    }
}
