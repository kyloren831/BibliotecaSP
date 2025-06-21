using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("PERMISOS_ROL", Schema = "TB_OWNER")]
    public class PermisoRol
    {
        [Column("IDROL")]
        public int IdRol { get; set; }
        [Column("IDPANTALLA")]
        public int IdPantalla { get; set; }
        [Column("INSERTAR")]
        public char Insertar { get; set; }
        [Column("MODIFICAR")]
        public char Modificar { get; set; }
        [Column("BORRAR")]
        public char Borrar { get; set; }
        [Column("CONSULTAR")]
        public char Consultar { get; set; }
        [Column("FECHACREACION")]
        public DateTime FechaCreacion { get; set; }

        public Rol Rol { get; set; }
        public Pantalla Pantalla { get; set; }
    }
}
