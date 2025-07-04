﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("USUARIOS", Schema = "TB_OWNER")]
    public class Usuario
    {
        [Key]
        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("CORREO")]
        public string Correo { get; set; }

        [Column("CLAVE")]
        public string Clave { get; set; }

        [Column("ACTIVO")]
        public char Activo { get; set; }

        [Column("FECHACREACION")]
        public DateTime FechaCreacion { get; set; }

        public List<PermisoUsuario> PermisoUsuarios { get; set; }
        public List<UsuarioRol> UsuarioRoles {  get; set; }
    }
}
