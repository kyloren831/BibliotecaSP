using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DbContextBiblioteca : DbContext
    {
        public DbContextBiblioteca() : base (new DbContextOptionsBuilder<DbContextBiblioteca>().UseOracle(Configuracion.StringConexion).Options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }



    }
}
