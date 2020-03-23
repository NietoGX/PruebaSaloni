using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public abstract class FichaNoConformidad
{
    [Key]
    public int IdFicha { get; set; }
    public string FichaReferencia { get; set; }
    public Usuario Emisor { get; set; }
    public Proveedor Proveedor { get; set; }
    public Articulo Articulo { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }

    //PUEDE HABER MÁS DE UNA DECISIÓN POR FICHA
    public ICollection<TipoDecisionSeccion> Decisiones { get; set; }
    //SÓLO PUEDE HABER UN TIPO DE INCIDENCIA POR FICHA
    public TipoIncidenciaSeccion Incidencia { get; set; }

}