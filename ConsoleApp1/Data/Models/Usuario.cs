using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Usuario
{
    [Key]
    public int IDUsuario { get; set; }

    public string Nombre { get; set; }

    public string Email { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public ICollection<Seccion> Secciones;

    public ICollection<FichaNoConformidad> Fichas;



}