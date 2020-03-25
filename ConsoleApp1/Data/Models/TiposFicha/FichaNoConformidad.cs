using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public abstract class FichaNoConformidad
{
    [Key]
    public string Id { get; set; }
    public Usuario Emisor { get; set; }
    [Required]
    public string EmisorId { get; set; }
    public Proveedor Proveedor { get; set; }
    [Required]
    public int ProveedorId { get; set; }
    public Articulo Articulo { get; set; }
    [Required]
    public int ArticuloId { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaCreacion { get; set; }
    [DataType(DataType.Date)]
    public DateTime FechaModificacion { get; set; }

    //PUEDE HABER MÁS DE UNA DECISIÓN POR FICHA
    public ICollection<TipoDecisionSeccion> Decisiones { get; set; }
    //SÓLO PUEDE HABER UN TIPO DE INCIDENCIA POR FICHA
    public TipoIncidenciaSeccion Incidencia { get; set; }

}