using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PRUEBA.Data.Models
{
    public class Empresa

    {
        [Key]
        public int IdEmpresa { get; set; }

        [Required]
        public string NombreEmpresa { get; set; }

        public ICollection<Area> Areas;

        public ICollection<EmpresaAreaSeccionUsuario> Roles;
    }
}
