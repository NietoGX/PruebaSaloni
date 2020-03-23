using System.ComponentModel.DataAnnotations;

public class TipoDecisionSeccion
{
    [Key]
    public int IdDecision { get; set; }
    public int IdSeccion { get; set; }
    public Decision Decision { get; set; }
    public Seccion Seccion { get; set; }
}