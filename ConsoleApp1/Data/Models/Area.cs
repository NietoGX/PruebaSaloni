using PRUEBA.Data.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Area
{
    [Key]
    public int IdArea { get; set; }

    public string Nombre { get; set; }
    public Empresa Empresa { get; set; }
    public Usuario Responsable1 { get; set; }
    public Usuario Responsable2 { get; set; }

    public Usuario Director { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }


}
