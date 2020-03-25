using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Seccion
{
    [Key]
    public int IdSeccion { get; set; }
    [Required]
    public int IdArea { get; set; }
    public Area Area { get; set; }
    [Required]
    public string NombreSeccion { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaCreacion { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaModificacion { get; set; }
    

    public ICollection<TipoDecisionSeccion> Decisiones { get; set; }
    public ICollection<TipoIncidenciaSeccion> Incidencias { get; set; }
    public ICollection<EmpresaAreaSeccionUsuario> Roles { get; set; }
    public ICollection<FichaNoConformidad> Fichas { get; set; }




}