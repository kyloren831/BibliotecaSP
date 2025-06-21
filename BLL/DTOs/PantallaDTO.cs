using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PantallaDTO
    {
        public int IdPantalla { get; set; }
        public int IdSistema { get; set; }
        public string NombrePantalla { get; set; }
        public string NombreSistema { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
