using PRUEBA.Data.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Area
{
    [Key]
    public int IdArea { get; set; }

    public string Nombre { get; set; }
    public Empresa Empresa { get; set; }
    public string EmpresaId { get; set; }
    public Usuario Responsable1 { get; set; }
    public string Responsable1Id { get; set; }
    public Usuario Responsable2 { get; set; }
    public string Responsable2Id { get; set; }

    public Usuario Director { get; set; }
    public string DirectorId { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaCreacion { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaModificacion { get; set; }


}
