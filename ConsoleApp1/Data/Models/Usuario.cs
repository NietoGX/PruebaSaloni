using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Usuario
{
    //[Key]
    //public int Id { get; set; }
    [Required]
    public string Nombre { get; set; }
    [Key]
    public string Email { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public ICollection<Seccion> Secciones;

}