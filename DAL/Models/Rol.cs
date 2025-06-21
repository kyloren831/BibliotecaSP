using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("ROLES", Schema = "TB_OWNER")]
    public class Rol
    {
        [Key]
        [Column("IDROL")]
        public int IdRol { get; set; }
        [Column("NOMBREROL")]
        public string NombreRol { get; set; }
        public List<UsuarioRol> UsuarioRol { get; set; }
        public List<PermisoRol> PermisosRol{ get; set; }
    }
}
