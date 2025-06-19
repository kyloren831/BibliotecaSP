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
        public DbSet<Pantalla> Pantallas { get; set; }
        public DbSet<Sistema> Sistemas {  get; set; }
        public DbSet<PermisoUsuario> PermisosUsuarios {  get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<UsuarioRol> UsuarioRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configurar llave compuesta para permisosUsuario
            modelBuilder.Entity<PermisoUsuario>()
            .HasKey(x => new { x.IdUsuario, x.IdPantalla });

            //Configurar llave compuesta para UsuarioRol
            modelBuilder.Entity<UsuarioRol>()
           .HasKey(x => new { x.IdUsuario, x.IdRol });

            //Llaves foraneas para Permisos_Usuario
            modelBuilder.Entity<PermisoUsuario>()
                .HasOne(up => up.Usuario)
                .WithMany(u => u.PermisoUsuarios)
                .HasForeignKey(up=>up.IdUsuario);

            modelBuilder.Entity<PermisoUsuario>()
               .HasOne(up => up.Pantalla)
               .WithMany(p => p.PermisoUsuarios)
               .HasForeignKey(up => up.IdPantalla);

            //Llaves foraneas para Usuario_Rol
            modelBuilder.Entity<UsuarioRol>()
                .HasOne(up => up.Usuario)
                .WithMany(u => u.UsuarioRoles)
                .HasForeignKey(up => up.IdUsuario);

            modelBuilder.Entity<UsuarioRol>()
                .HasOne(up => up.Rol)
                .WithMany(u => u.UsuarioRol)
                .HasForeignKey(up => up.IdRol);

        }


    }
}
