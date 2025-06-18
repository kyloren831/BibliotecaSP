using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("SISTEMAS", Schema = "TB_OWNER")]
    public class Sistema
    {
        [Key]
        [Column("IDSISTEMA")]
        public int IdSistema { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("FECHACREACION")]
        public DateTime FechaCreacion { get; set; }
        [Column("RUTAEJECUTABLE")]
        public string RutaEjecutable { get; set; }
        
    }
      
}
