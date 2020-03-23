using System;
using System.ComponentModel.DataAnnotations;

public class Proveedor
{
    [Key]
    public int IdProveedor { get; set; }
    public string Descripcion { get; set; }
    public bool Interno { get; set; }
    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }
}