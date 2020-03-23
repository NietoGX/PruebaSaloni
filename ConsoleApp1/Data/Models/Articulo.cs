using System;
using System.ComponentModel.DataAnnotations;

public class Articulo
{
    [Key]
    public int IdArticulo { get; set; }
    public string Descripcion { get; set; }
    public bool Interno { get; set; }
    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }
}