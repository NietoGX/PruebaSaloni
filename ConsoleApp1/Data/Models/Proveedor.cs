﻿using System;
using System.ComponentModel.DataAnnotations;

public class Proveedor
{
    [Key]
    public int IdProveedor { get; set; }
    [Required]
    public string Descripcion { get; set; }
    public bool Interno { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaCreacion { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaModificacion { get; set; }
}