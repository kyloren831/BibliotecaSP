using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PermisosUsuarioDTO
    {
        public int IdUsuario { get; set; }
        public int IdPantalla { get; set; }
        public string Usuario { get; set; }
        public string Pantalla { get; set; }
        public char Insertar { get; set; }
        public char Modificar { get; set; }
        public char Borrar { get; set; }
        public char Consultar { get; set; }
    }
}
