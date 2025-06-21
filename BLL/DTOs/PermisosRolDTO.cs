using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PermisosRolDTO
    {
        public int IdRol { get; set; }
        public int IdPantalla { get; set; }
        public string Rol { get; set; }
        public string Pantalla { get; set; }
        public char Insertar { get; set; }
        public char Modificar { get; set; }
        public char Borrar { get; set; }
        public char Consultar { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
