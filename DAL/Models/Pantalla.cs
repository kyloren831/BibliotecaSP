using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{

    [Table("PANTALLAS", Schema = "TB_OWNER")]
    public class Pantalla
    {
        [Key]
        [Column("IDPANTALLA")]
        public int IdPantalla { get; set; }
        [Column("IDSISTEMA")]
        public int IdSistema { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("FECHACREACION")]
        public DateTime FechaCreacion { get; set; }

        public List<PermisoUsuario> PermisoUsuarios { get; set; }
    }
}
