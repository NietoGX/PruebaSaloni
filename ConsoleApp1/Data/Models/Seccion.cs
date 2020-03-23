using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Seccion
{
    [Key]
    public int IdSeccion { get; set; }
    public int IdArea { get; set; }
    public string NombreSeccion { get; set; }

    public DateTime FechaCreacion { get; set; }
    
    public DateTime FechaModificacion { get; set; }
    public Area Area { get; set; }

    public ICollection<TipoDecisionSeccion> Decisiones { get; set; }
    public ICollection<TipoIncidenciaSeccion> Incidencias { get; set; }
    public ICollection<EmpresaAreaSeccionUsuario> Roles { get; set; }
    public ICollection<FichaNoConformidad> Fichas { get; set; }




}