using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("USUARIO_ROL", Schema = "TB_OWNER")]
    public class UsuarioRol
    {
        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }
        [Column("IDROL")]
        public int IdRol { get; set; }
        public Usuario Usuario { get; set; }
        public Rol Rol { get; set; }
    }
}
