using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UsuarioRolDTO
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Usuario { get; set; }
        public string Rol { get; set; }
    }
}
