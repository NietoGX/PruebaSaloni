using System.ComponentModel.DataAnnotations;

public class TipoIncidenciaSeccion
{
    [Key]
    public int IdSeccion { get; set; }
    public int IdIncidencia { get; set; }
    public Seccion Seccion { get; set; }
    public Incidencia Incidencia { get; set; }
}